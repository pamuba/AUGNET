using ClassLibrary1;

namespace ClassLibrary1
{
    public class AccessDemo
    {
        internal string name;
        protected internal string dept="Sales";
        private protected int age = 100;
    }
   
}
namespace NewNameSpace {

    class AccessDemoTest: AccessDemo
    {
        public void fn()
        {
            AccessDemoTest ob = new AccessDemoTest();
            var val = ob.dept;
        }
    }
}
