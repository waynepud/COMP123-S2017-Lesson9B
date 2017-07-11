using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Wayne Pud
 * Date: July 11, 2017
 * Description: This is the SuperHuman class that extends the human class
 * Version: 0.4 - Added DisplayPowers method
 */
namespace COMP123_S2017_Lesson9B
{
    /// <summary>
    /// This is the SuperHuman class.
    /// </summary>
    public class SuperHuman : Human
    {
        //Private instance variables(field)
        private List<Power> _powers;


        //Public properties
        public List<Power> Powers
        {
            get
            {
                return this._powers; //this returns a reference
            }
        }
            

        //Constructors

            /// <summary>
            /// This is the main constructors for the SuperHuman class.
            /// It takes one parameter - name (string)
            /// </summary>
            /// <param name="name"></param>
        public SuperHuman(string name) : base (name)
        {
            this._initialize();
        }
   
       
        //Private methods
        
        /// <summary>
        /// This method intitialzes, instantiates and assigns values to the property
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>(); //creates an empty list
        }

        /// <summary>
        /// This method adds a power to the Power List.
        /// It takes two parameters - name(string) - rank(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        //Public methods

        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }

        /// <summary>
        /// This method displays each of the powers stored in the powers list
        /// </summary>
        public void DisplayPowers()
        {
            foreach (Power power in this.Powers)
            {
                Console.WriteLine("Power: " + power.Name + " Rank: " +power.Rank );
            }
        }
    }
}