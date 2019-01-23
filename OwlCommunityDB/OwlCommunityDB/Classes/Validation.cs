/*Project 4 - Final Project - Owl Community Database
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski, with code provided by Prof. Frank Friedman, Temple University
*This validation class is used to validate all the user inputted data
* in the form, to be sure that it is the correct format, and that it is 
* ready to be inserted into the database.
* Helps maintain consistency in our data
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OwlCommunityDB.Classes
{
    class Validation
    {
        private frmMainForm f;
        //parameterized Constructor 
        public Validation(frmMainForm form)
        {
            f = form;
        }

        //method used to verify txt string input is not empy and does not contain white space
        //returns true if not empty
        public static bool notEmpty(string str)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool isInteger(string str)
        {
            int result;
            if (Int32.TryParse(str, out result))
            {
                return true;
            }
            return false;
        }

        //verifies that input can be converted to a positive decimal
        //can only contain two decimal places
        //returns true if the decimal is positive and contains only two places
        private static bool isPositiveDecimal(string str)
        {
            decimal value;
            if (Decimal.TryParse(str, out value)) // convertible to decimal
            {
                if (value >= 0.00m) // greater than or equal to zero
                {
                    return true;
                }
                else // negative decimal
                {
                    MessageBox.Show(str + " is not greater than or equal to zero");
                }
            }
            else // not convertible
            {
                MessageBox.Show(str + " is not convertible to a decimal");
            }
            return false;
        }


        //verify owl member name cannot be blank
        //verify name follows regular expression rules
        //returns true if determined valid
        public static bool validateName(frmMainForm f)
        {
            if (notEmpty(f.txtName.Text))
            {
                if (Regex.IsMatch(f.txtName.Text, "^[A-Za-z ]+$"))
                {
                    return true;
                }
                MessageBox.Show("Owl Member Name cannot include special characters or numbers");
                return false;

            }
            MessageBox.Show("OwlMember Name cannot be empty");
            return false;
        }

        //validates that the owl member ID is a 9 digit integer, not negative, not blank
        public static bool validateOwlMemberID(frmMainForm f)
        {
            if (notEmpty(f.txtID.Text)) // not empty string
            {
                if (isInteger(f.txtID.Text)) // is integer
                {
                   if(f.txtID.Text.Length != 9)
                    {
                        MessageBox.Show("the OwlMemberID must be a 9 digit integer");
                        return false;
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("OwlMemberID must be a 9-Digit positive integer");
                    return false;
                }
            }
            MessageBox.Show("OwlMemberID must not be empty");
            return false;
        }
        public static bool menuYearValidation(frmMainForm f)
        {
            try
            {
                f.menuYear.SelectedItem.ToString();
                return true;
            }
            catch
            {
                MessageBox.Show("The drop down menu cannot be left blank");
                return false;
            }
        }
        public static bool menuRankValidation(frmMainForm f)
        {
            try
            {
              f.menuRank.SelectedItem.ToString();
                return true;
            }
            catch
            {
                MessageBox.Show("The drop down menu cannot be left blank");
                return false;
            }
                
        }
        public static bool menuDegreeValidation(frmMainForm f)
        {
            try
            {
                f.menuDegree.SelectedItem.ToString();
                return true;
            }
            catch
            {
                MessageBox.Show("The drop down menu cannot be left blank");
                return false;
            }
        }

        //validates that credits is a positive integer
        public static bool validateCredits(frmMainForm f)
        {
            if (notEmpty(f.txtCredits.Text)) // not empty
            {
                if (isInteger(f.txtCredits.Text) &&  isPositiveDecimal(f.txtCredits.Text)) // convertible and greater than or equal to 0.00
                {
                    return true;
                }
                return false;
            }
            MessageBox.Show("Credits is empty");
            return false;
        }

        //validates tuition is a positive decimal and is not null
        public static bool validateTuition (frmMainForm f)
        {
            if (notEmpty(f.txtTuition.Text)) // not empty
            {
                if (isPositiveDecimal(f.txtTuition.Text)) // convertible and greater than or equal to 0.00
                {
                    return true;
                }
                MessageBox.Show("Tuition is not valid");
                return false;
               
            }
            MessageBox.Show("Tuition is empty");
            return false;

        }


        //verifies that the Dept txt input contains only alphabetic characters, and is not empty
        public static bool validateDept(frmMainForm f)
        {
            if (notEmpty(f.txtDepartment.Text)) // not empty string
            {
                if (Regex.IsMatch(f.txtDepartment.Text, "^[A-Za-z ]+$"))
                {
                    return true;
                }
                MessageBox.Show("Department cannot include special character or numbers");
                return false;
            }
            MessageBox.Show("Department field cannot be empty");
            return false;
        }

        //verifies that the major txt input contains only alphabetic characters, and is not empty
        public static bool validateMajor(frmMainForm f)
        {
            if (notEmpty(f.txtMajor.Text)) // not empty string
            {
                if (Regex.IsMatch(f.txtMajor.Text, "^[A-Za-z ]+$"))
                {
                    return true;
                }
                MessageBox.Show("Major field cannot include special character or numbers");
                return false;
            }
            MessageBox.Show("Major field cannot be empty");
            return false;
        }


        //validate that grad stipend input is a positive decimal, contains two decimal places, and is not empty
        public static bool validateGradStipend(frmMainForm f)
        {
            if (notEmpty(f.txtGradStipend.Text)) // not empty
            {
                if (isPositiveDecimal(f.txtGradStipend.Text)) // convertible and greater than or equal to 0.00
                {
                    return true;
                }
                MessageBox.Show("Grad Stipend is not valid");
                return false;
            }
            MessageBox.Show("Grad Stipend is empty");
            return false;
        }

        //validate that chair stipend input is a positive decimal, contains two decimal places, and is not empty
        public static bool validateChairStipend(frmMainForm f)
        {
            if (notEmpty(f.txtChairStipend.Text)) // not empty
            {
                if (isPositiveDecimal(f.txtChairStipend.Text)) // convertible and greater than or equal to 0.00
                {
                    return true;
                }
                MessageBox.Show("Chairperson Stipend is not valid");
                return false;
            }
            MessageBox.Show("Chairperson Stipend is empty");
            return false;
        }

        //validates that the GPA is between 0.0 and 4.0, contains only two decimal places
        //returns true if the gpa is valid
        public static bool validateGPA(frmMainForm f)
        {
            if (notEmpty(f.txtGPA.Text))
            {
                if (!Regex.IsMatch(f.txtGPA.Text, @"^[0-4]+(\.\d{2})$"))
                {
                    MessageBox.Show("Please enter a GPA both greater than 0 and less than 4.00");
                    return false;
                }
                else
                {
                    Convert.ToDecimal(f.txtGPA.Text);
                  return true;
                }
            }
            return false;
        }
    }


}

