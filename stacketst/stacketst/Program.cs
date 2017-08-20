using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stacketst
{

    public class CarsBase
    {
        public string DisplayName { get; set; }
        public CarsBase()
        {
            DisplayName = "Base Car";

        }
    }
    public class Toyota : CarsBase
    {
       
        public int number_of_wheels { get; set; }
        public double fuel_capacity { get; set; }
        public string engine_type { get; set; }

        public Toyota()
        {
            fuel_capacity = 4.2;
        number_of_wheels = 4;
  engine_type = EngineType.name_engines.UZ.ToString();
        }
 
    }

    public class TestClass
    {
        
        static void Main()
        {
            var myVar = new Toyota();
            Console.WriteLine(myVar.DisplayName);
            Console.ReadLine();     
    }
}
  
}

