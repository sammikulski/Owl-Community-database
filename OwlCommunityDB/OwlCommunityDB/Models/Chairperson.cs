/*Project 4 - Final Project - Owl Community Database
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski, with code provided by Prof. Frank Friedman, Temple University
*This chairperson model class assigns the default values and methods
* that we want an instance of this class to have. 
* Constructor is also written here too, some methods are overridden
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwlCommunityDB.Models
{
    [Serializable()]
    public class Chairperson : Faculty
    {

        private decimal stipend;

        // Parameterless Constructor 
        public Chairperson()
        {
            stipend = 0;
        }

        // Parameterized Consutrctor 
        public Chairperson(int id, string name, DateTime dob, string rank,
            string department, decimal chairStipend) : base(id, name, dob, department, rank)
        {
            stipend = chairStipend;
        }

        // Getter and Setter for Stipend
        public decimal Stipend
        {
            get
            {
                return stipend;
            }
            set
            {
                stipend = value;
            }
        }

        // Enable controls on form to edit object
        public override void Edit(frmMainForm f)
        {
            base.Edit(f);
            f.gbChairperson.Enabled = true;
            f.txtChairStipend.Enabled = true;
        }

        // Save data from form to object
        public override void Save(frmMainForm f)
        {
            base.Save(f);
            stipend = Convert.ToDecimal(f.txtChairStipend.Text);
        }

        // Display data in object on form
        public override void Display(frmMainForm f)
        {
            base.Display(f);
            f.txtChairStipend.Text = stipend.ToString();
        }

        // This toString function overrides the Object toString function
        // The base refers to Object because this class inherits Object by default
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Chairperson Info: " + "\n";
            s += "Stipend: " + stipend.ToString() + "\n";
            return s;
        }

    }
}
