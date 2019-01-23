/*Project 4 - Final Project - Owl Community Database
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski, with code provided by Prof. Frank Friedman, Temple University
*This undergrad student model class assigns the default values and methods
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
    public class UndergradStudent : Student
    {
        private decimal studentTuition;
        private int studentCredits;
        private string studentYear;

        // Default Constructor
        public UndergradStudent()
        {
            studentTuition = 0;
            studentCredits = 0;
            studentYear = "";
        }

        // Constructor that sets attributes 
        public UndergradStudent(int id, string name, DateTime dob, string major, decimal gpa,
            decimal tuition, string year, int credits) : base(id, name, dob, major, gpa)
        {
            studentTuition = tuition;
            studentCredits = credits;
            studentYear = year;
        }

        // Get and Set Student Tuition
        public decimal StudentTuition
        {
            get
            {
                return studentTuition;
            }
            set
            {
                studentTuition = value;
            }
        }

        // Get and Set Credits
        public int StudentCredits
        {
            get
            {
                return studentCredits;
            }
            set
            {
                studentCredits = value;
            }
        }

        // Get and Set Student Class Year 
        public string StudentYear
        {
            get
            {
                return studentYear;
            }
            set
            {
                studentYear = value;
            }
        }

        // Enable controls on form to edit object
        public override void Edit(frmMainForm f)
        {
            base.Edit(f);
            f.gbUndergrad.Enabled = true;
            f.txtTuition.Enabled = true;
            f.txtCredits.Enabled = true;
            f.menuYear.Enabled = true;
        }

        // Save data from form to object
        public override void Save(frmMainForm f)
        {
            base.Save(f);
            studentTuition = Convert.ToDecimal(f.txtTuition.Text);
            studentCredits = Convert.ToInt32(f.txtCredits.Text);
            studentYear = f.menuYear.ToString();
        }


        // Display data in object on form
        public override void Display(frmMainForm f)
        {
            base.Display(f);
            f.txtTuition.Text = studentTuition.ToString();
            f.txtGPA.Text = studentGPA.ToString();
            f.menuYear.Text = studentYear.ToString();
            f.txtCredits.Text = studentCredits.ToString();
        }

        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Undergraduate Student Info: " + "\n";
            s += "Tuition: " + studentTuition.ToString() + "\n";
            s += "Credits: " + studentCredits.ToString() + "\n";
            s += "Year   : " + studentYear;
            return s;
        }
    }
}
