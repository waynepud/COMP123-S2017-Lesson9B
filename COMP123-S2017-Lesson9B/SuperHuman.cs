using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Wayne Pud
 * Date: July 11, 2017
 * Description: This is the SuperHuman class that extends the human class
 * Version: 0.2 - Added _initialize method
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

        //Public methods
    }
}