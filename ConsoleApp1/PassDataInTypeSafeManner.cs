using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PassDataInTypeSafeManner
    {
        static void Main(string[] args)
        {
            ResultCallbackDelegate resultCallbackDelegate = new ResultCallbackDelegate(ResultCallbackMethod);
            int Number = 5;

            NumberHelper obj = new NumberHelper(Number, resultCallbackDelegate);
            Thread th = new Thread(new ThreadStart(obj.CalculateSum));
            th.Start();
           

            //int Max = 5;
            //NumHelper numHelper = new NumHelper(Max);
            //Thread th = new Thread(new ThreadStart(numHelper.DisplayNumbers));
            //th.Start();

            //ParameterizedThreadStart pth = new ParameterizedThreadStart(new PassDataInTypeSafeManner().DisplayNumbers);
            //Thread th= new Thread(pth);
            //th.Start("a11");
        }
        public static void ResultCallbackMethod(int results) {
            Console.WriteLine("The Result is:"+results);
        }
        //public void DisplayNumbers(object Max) { 
        //    int max = Convert.ToInt32(Max);
        //    for (int i = 0; i <= max; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
    }
}
