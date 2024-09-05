using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class CustomException:Exception {
        public CustomException(string Message): base(Message)
        { }
        public CustomException(string Message, Exception ob) : base(Message, ob)
        { }
        public override string Message
        {
            get {
                return "Divisor Cannot be a Zero";
            }
        }
        public override string? HelpLink {
            get {
                return "Get More help:https://learn.microsoft.com/en-us/dotnet/api/system.exception?view=net-8.0";
            }
        }
    }
    internal class ExceptionHandlingDemo
    {
      
        static void Main(string[] args)
        {
            int num1, num2, num3;
            try
            {
                Console.WriteLine("Enter First Number");
                num1 = 22;//int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                num2 = int.Parse(Console.ReadLine());
                if (num2 == 0) {
                    throw new CustomException("Cant be ZERO!!!");
                }
                num3 = num1 / num2;
                Console.WriteLine($"Result:{num3}");
            }
            catch (Exception ex)
            {

                Console.WriteLine("InnerException:"+ex.InnerException);
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine(ex.HelpLink);
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine(ex.Message);
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine(ex.Source);
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine(ex.StackTrace);
                //throw ex;
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    //throw ex;
            //}
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.WriteLine("Done");
        }

    }
}
