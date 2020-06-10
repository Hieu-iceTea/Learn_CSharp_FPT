using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNet.CodeLean.Lab_03
{
    class Car
    {
        public string make;
        public string model;
        public string color;
        public int yearBuilt;

        public void Start()
        {
            Console.WriteLine(model + " ...Start");
        }

        public void Stop()
        {
            Console.WriteLine(model + " ...Stop");
        }
    }
}
