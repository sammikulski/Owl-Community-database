/*Project 4 - Final Project - Owl Community Database
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski, with code provided by Prof. Frank Friedman, Temple University
*This OwlMember model class assigns the default values and methods
* that we want an instance of this class to have. 
* Constructor is also written here too, some methods are overridden
* this class is used as our parent class, since other classes
* inherit its attributes
* 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// For serialization
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace OwlCommunityDB.Models
{
    [Serializable()]
    public abstract class OwlMember
    {
        private int hiddenID;   // Owl ID
        private string hiddenName; // Owl name
        private DateTime hiddenBirthDate;   // Owl birth date


        // Parameterless Constructor
        public OwlMember()
        {
            hiddenID = 0;
            hiddenName = "";
            hiddenBirthDate = DateTime.Now;

        }  // end Owl Parameterless Constructor

        // Parameterized Constructor
        public OwlMember(int id, string name, DateTime bd)
        {
            hiddenName = name;
            hiddenBirthDate = bd;
            hiddenID = id;
        }  // end Owl Parameterized Constructor


        // Accessor/Mutator for id
        public int owlID
        {
            get
            {
                return hiddenID;
            } //  end get
            set   // (string value)
            {
                hiddenID = value;
            }  // end get
        }  // End Property


        // Accessor/mutator for name
        public string OwlName
        {
            get
            {
                return hiddenName;
            }  // end get
            set   // (string value)
            {
                hiddenName = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for birth date
        public DateTime owlBirthDate
        {
            get
            {
                return hiddenBirthDate;
            }  // end get
            set   // (DateTime value)
            {
                hiddenBirthDate = value;
            }  // end get
        }  // end Property

        // Enable controls for the object to be edited 
        public virtual void Edit(frmMainForm f)
        {
            f.gbOwlMember.Enabled = true;
            f.txtID.Enabled = true;
            f.txtName.Enabled = true;
            f.dtBday.Enabled = true;
        }


        // Save data from form to object
        public virtual void Save(frmMainForm f)
        {
            hiddenName = f.txtName.Text;
            hiddenBirthDate = DateTime.Parse(f.dtBday.Text);
            hiddenID = Convert.ToInt32(f.txtID.Text);
        }  // end Save


        // Display data in object on form
        public virtual void Display(frmMainForm f)
        {
            f.txtName.Text = hiddenName;
            f.dtBday.Text = hiddenBirthDate.ToShortDateString();
            f.txtID.Text = hiddenID.ToString();
        }  // end Display


        // This toString function overrides the Object toString function
        // The base refers to Object because this class inherits Object by default
        public override string ToString()
        {
            string s = "ObjectType       : " + base.ToString() + "\n";
            s += "OwlName     : " + hiddenName + "\n";
            s += "OwlBirthDate: " + hiddenBirthDate.ToShortDateString() + "\n";
            s += "OwlID       :" + hiddenID;
            return s;
        }  // end ToString

    }
}
