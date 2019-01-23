/*Project 4 - Final Project - Owl Community Database
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski, with code provided by Prof. Frank Friedman, Temple University
*This student model class assigns the default values and methods
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

    // Client inherits the data and methods in Person
    [Serializable()]
    public class Student : OwlMember
    {
        private string hiddenStudentMajor;
        private decimal hiddenStudentGPA;

        // Parameterless Constructor
        public Student()
        {
            hiddenStudentMajor = "";
            hiddenStudentGPA = 0.0m;

        } // end Employee Parameterless Constructor


        // Parameterized Constructor
        public Student(int id, string name, DateTime dob,  // For Person Constructor
            string m, decimal gpa) : base(id, name, dob)
        {
            hiddenStudentMajor = m;
            hiddenStudentGPA = gpa;
        }  // end Employee Parameterized Constructor


        // Accessor/mutator for job title
        public string studentMajor
        {
            get
            {
                return hiddenStudentMajor;
            }  // end get
            set   // (string value)
            {
                hiddenStudentMajor = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for job title
        public decimal studentGPA
        {
            get
            {
                return hiddenStudentGPA;
            }  // end get
            set   // (string value)
            {
                hiddenStudentGPA = value;
            }  // end get
        }  // end Property

        // Save data from form to object
        public override void Save(frmMainForm f)
        {
            base.Save(f);
            hiddenStudentMajor = f.txtMajor.Text;
            hiddenStudentGPA = Convert.ToDecimal(f.txtGPA.Text);
        } // end Save


        // Display data in object on form
        public override void Display(frmMainForm f)
        {
            base.Display(f);
            f.txtMajor.Text = hiddenStudentMajor;
            f.txtGPA.Text = hiddenStudentGPA.ToString();
        }  // end Display


        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Student Info: " + hiddenStudentGPA + hiddenStudentGPA.ToString(); ;
            return s;
        }  // end ToString

    }  // end Student class
}
