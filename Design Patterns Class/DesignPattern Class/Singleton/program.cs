﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;

namespace DesignPattern_Class
{
    class program
    {

        static void Main(string[] args)
        {
            SingletonPatternDemo();

        }

        private static void SingletonPatternDemo()
        {

            SerialNumberGenerator generator = SerialNumberGenerator.Instance;


            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
        
        }

    



    }


}
