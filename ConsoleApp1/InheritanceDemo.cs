using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class InheritanceDemo
	{
		private int age;
		
		public virtual int Age
		{
			
			get { return age; }
			set { age = value; }
		}

	}
	class Test3 : InheritanceDemo
	{
        public override int Age 
		{ 
			get => base.Age; 
			set => base.Age = value; 

			
		}
    }

}
