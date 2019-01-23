/*Project 4 - Final Project - Owl Community Database
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski, with code provided by Prof. Frank Friedman, Temple University
*This gradStudent model class assigns the default values and methods
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

    public class GradStudent : Student
    {
        private decimal stipend;
        private string degreeProgram;

        public GradStudent()
        {
            stipend = 0;
            degreeProgram = "";
        }

        public GradStudent(int id, string name, DateTime dob, string major, decimal gpa,
           string dp, decimal stip) : base(id, name, dob, major, gpa)
        {
            stipend = stip;
            degreeProgram = dp;
        }
        // Getter and setter for Stipend
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

        // Getter and setter for degreeProgram
        public string DegreePrime
        {
            get
            {
                return degreeProgram;
            }
            set
            {
                degreeProgram = value;
            }
        }

        // Enable controls on form to edit object
        public override void Edit(frmMainForm f)
        {
            base.Edit(f);
            f.gbGrad.Enabled = true;
            f.txtGradStipend.Enabled = true;
            f.menuDegree.Enabled = true;
        }
        // Save data from form to object
        public override void Save(frmMainForm f)
        {
            base.Save(f);
            stipend = Convert.ToDecimal(f.txtGradStipend.Text);
            degreeProgram = f.menuDegree.ToString();

        }

        // Display data in object on form
        public override void Display(frmMainForm f)
        {
            base.Display(f);
            f.txtGradStipend.Text = stipend.ToString();
            f.menuDegree.Text = degreeProgram;
        }

        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Graduate Student Info: " + "\n";
            s += "Stipend: " + stipend.ToString() + "\n";
            s += "Program: " + degreeProgram;
            return s;
        }
    }
}
