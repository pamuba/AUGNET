namespace ConsoleApp1
{

    class ProtectedDemo1
    {
        public void Sum(int i, int j)
        {
            Console.WriteLine("Inherited Fn");

        }
        public void Sum(int i, float j)
        {

        }
        public void Sum(float i, int j)
        {

        }
        public void Sum(float i, int j, int k)
        {

        }
        public void Sum(int i, float j, int k)
        {

        }


    }

    class Test1 : ProtectedDemo1
    {
        public void Sum(int i, int j)
        {
            Console.WriteLine("Own Fn");
        }


        static void Main(string[] args)
        {
            Test1 ob = new Test1();
            ob.Sum(1, 2);

            ProtectedDemo1 pd = new Test1();
            pd.Sum(1, 2);

        }

    }


}