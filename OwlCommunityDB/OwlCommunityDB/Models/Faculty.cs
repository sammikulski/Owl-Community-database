/*Project 4 - Final Project - Owl Community Database
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski, with code provided by Prof. Frank Friedman, Temple University
*This faculty model class assigns the default values and methods
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
    public class Faculty : OwlMember
    {
        private string department;
        private string rank;

        // Parameterless Constructor 
        public Faculty()
        {
            department = "";
            rank = "";
        }

        // Parameterized Constructor
        public Faculty(int id, string name, DateTime dob, string dept, string facultyRank) : base(id, name, dob)
        {
            department = dept;
            rank = facultyRank;
        }

        // Getter and Setter for Department
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        // Getter and Setter for Rank
        public string Rank
        {
            get
            {
                return rank;
            }
            set
            {
                rank = value;
            }
        }

        // Enable controls on form to edit object
        public override void Edit(frmMainForm f)
        {
            base.Edit(f);
            f.gbFaculty.Enabled = true;
            f.txtDepartment.Enabled = true;
            f.menuRank.Enabled = true;
        }

        // Save data from form to object
        public override void Save(frmMainForm f)
        {
            base.Save(f);
            rank = f.menuRank.SelectedItem.ToString();
            department = f.txtDepartment.Text;
        }

        // Display data in object on form
        public override void Display(frmMainForm f)
        {
            base.Display(f);
            f.menuRank.Text = rank.ToString();
            f.txtDepartment.Text = department;
        }


        // This toString function overrides the Object toString function
        // The base refers to Object because this class inherits Object by default
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Faculty Info: " + "\n";
            s += "Rank      : " + rank + "\n";
            s += "Department : " + department;
            return s;
        }

    }
}
