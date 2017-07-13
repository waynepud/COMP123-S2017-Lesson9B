using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Wayne Pud
 * Date: July 13, 2017
 * Description: Demo for lesson 9
 * Version: 0.6 - Implemented the superhero class
 */


namespace COMP123_S2017_Lesson9B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("SuperHero Dude", 20);
            superHero.AddPower("Spider Climbing", 50);
            superHero.AddPower("Webcasting", 40);
            superHero.AddPower("Webcasting", 40);
            //SuperHero.DisplayPowers();

            Console.WriteLine(superHero.ToString());
            Console.WriteLine("karma: " + superHero.Karma);
        }
    }
}
