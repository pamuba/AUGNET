using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ConsoleApp1
{
    internal class returnFromASyncFunction :ApiController
    {
        static void Main(string[] args)
        {
            SomeMethod(1);
        }
        public async static void SomeMethod(int id) { 
            var retMessage =  await GetData(id);
            Console.WriteLine(retMessage);
        }
        public static async Task<string> GetData(int id) {
            string message = String.Empty;
            using (var client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"https://jsonplaceholder.typicode.com/posts/{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        message = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        message = $"Error: {response.StatusCode}";
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Request error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }
            }
            return message;
        }
    }
}
