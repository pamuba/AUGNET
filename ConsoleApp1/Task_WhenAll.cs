using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//The asynchronous operation starts and runs concurrently with other code.
//Since we’re not awaiting it, the code that follows continues executing without
//waiting for the task to complete.
namespace ConsoleApp1
{
    internal class Task_WhenAll
    {
        static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(3);
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread Started");
            List<CreditCard> creditCards = CreditCard.GenerateCreditCards(15);
            Console.WriteLine($"Credit Card Generated : {creditCards.Count}");

            ProcessCreditCards(creditCards);

            Console.WriteLine($"Main Thread Completed");
            Console.ReadKey();
        }
        public static async Task<string> ProcessCard(CreditCard creditCard)
        {
            //Here we can do any API Call to Process the Credit Card
            //But for simplicity we are just delaying the execution for 1 second
            await Task.Delay(1000);
            string message = $"Credit Card Number: {creditCard.CardNumber} Name: {creditCard.Name} Processed";
            Console.WriteLine($"Credit Card Number: {creditCard.CardNumber} Processed");
            return message;
        }
        public static async void ProcessCreditCards(List<CreditCard> creditCards)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var tasks = new List<Task<string>>();

            tasks = creditCards.Select(async card => {
                await semaphoreSlim.WaitAsync();

                try { return await ProcessCard(card); }
                finally { semaphoreSlim.Release(); }

            }).ToList();

            string[] responses = await Task.WhenAll(tasks);
            //Console.WriteLine("______________________________________");
            //foreach (var response in responses) {
            //    Console.WriteLine(response);
            //}
            stopwatch.Stop();
            Console.WriteLine($"Processing of {creditCards.Count} Credit Cards Done in {stopwatch.ElapsedMilliseconds / 1000.0} Seconds");

            //var stopwatch = new Stopwatch();
            //stopwatch.Start();
            //var tasks = new List<Task<string>>();
            ////Processing the creditCards using foreach loop
            //foreach (var creditCard in creditCards)
            //{
            //    var response = ProcessCard(creditCard);
            //    tasks.Add(response);
            //}
            ////It will execute all the tasks concurrently
            //await Task.WhenAll(tasks);
            //stopwatch.Stop();
            //Console.WriteLine($"Processing of {creditCards.Count} Credit Cards Done in {stopwatch.ElapsedMilliseconds / 1000.0} Seconds");

        }
        public static async void ProcessCreditCards_with(List<CreditCard> creditCards)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
           
            foreach (var creditCard in creditCards)
            {
                var response = await ProcessCard(creditCard);
            }
           
            stopwatch.Stop();
            Console.WriteLine($"Processing of {creditCards.Count} Credit Cards Done in {stopwatch.ElapsedMilliseconds / 1000.0} Seconds");
        }
    }
    public class CreditCard
    {
        public string CardNumber { get; set; }
        public string Name { get; set; }
        public static List<CreditCard> GenerateCreditCards(int number)
        {
            List<CreditCard> creditCards = new List<CreditCard>();
            for (int i = 0; i < number; i++)
            {
                CreditCard card = new CreditCard()
                {
                    CardNumber = "10000000" + i,
                    Name = "CreditCard-" + i
                };
                creditCards.Add(card);
            }
            return creditCards;
        }
    }
}
