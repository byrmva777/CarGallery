using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Car
    {
     

        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override string ToString() => $"{Marka} - {Model} - {Year}";
    }

    

}
