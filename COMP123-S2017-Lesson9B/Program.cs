using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Wayne Pud
 * Date: July 11, 2017
 * Description: Demo for lesson 9
 * Version: 0.2 - Instantiated an object of type SuperHuman
 */


namespace COMP123_S2017_Lesson9B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("SuperDude");
            superHuman.Powers.Add(new Power("Spider climbing", 50));
        }
    }
}
