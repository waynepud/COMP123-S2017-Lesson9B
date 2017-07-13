using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Wayne Pud
 * Date: July 11, 2017
 * Description: Demo for lesson 9
 * Version: 0.5 - used the tostring method of the superhuman class
 */


namespace COMP123_S2017_Lesson9B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("SuperDude");
            superHuman.AddPower("Spider Climbing", 50);
            superHuman.AddPower("Webcasting", 40);
            superHuman.AddPower("Webcasting", 40);
            //superHuman.DisplayPowers();

            Console.WriteLine(superHuman.ToString());
        }
    }
}
