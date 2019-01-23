/*Project 4 - Final Project - Owl Community Database
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski, with code provided by Prof. Frank Friedman, Temple University
*This form controller class is used to control the form, from multiple places
* throughout the program. we use it to reset our form to its inital state,
* control groupboxes, and let our main class know when add mode is true.
* It mainly controls the attributes and properties of the objects on our form.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace OwlCommunityDB.Controllers
{
    public class FormController
    {
        private frmMainForm f;

        public FormController(frmMainForm parentForm)
        {
            f = parentForm;
        }
        public static void resetForm(frmMainForm f)
        {
            //  Reset button components
            f.btnClearForm.Enabled = true;
            f.btnDelete.Enabled = false;
            f.btnEdit.Enabled = false;
            f.btnFind.Enabled = true;
            f.btnCreate.Enabled = false;
            f.btnProcessEdit.Enabled = false;
            


            f.btnCreateFaculty.Enabled = true;
            f.btnCreateFaculty.Text = "Create Faculty";
            f.btnCreateChair.Enabled = true;
            f.btnCreateChair.Text = "Create Chairperson";
            f.btnCreateGrad.Enabled = true;
            f.btnCreateGrad.Text = "Create Graduate Student";
            f.btnCreateUndergrad.Enabled = true;
            f.btnCreateUndergrad.Text = "Create Undergraduate";
            

            // Reset group components
            f.gbOwlMember.Enabled = false;
            f.gbOwlMember.BackColor = Color.Gainsboro;
            f.gbStudent.Enabled = false;
            f.gbStudent.BackColor = Color.Gainsboro;
            f.gbFaculty.Enabled = false;
            f.gbFaculty.BackColor = Color.Gainsboro;
            f.gbUndergrad.Enabled = false;
            f.gbUndergrad.BackColor = Color.Gainsboro;
            f.gbGrad.Enabled = false;
            f.gbGrad.BackColor = Color.Gainsboro;
            f.gbChairperson.BackColor = Color.Gainsboro;
            f.gbChairperson.Enabled = false;

            // Reset Text boxes
            f.txtID.Enabled = false;
            f.txtName.Enabled = false;
            f.dtBday.Enabled = false;
            f.txtDepartment.Enabled = false;
            f.menuRank.Enabled = false;
            f.txtMajor.Enabled = false;
            f.txtTuition.Enabled = false;
            f.menuYear.Enabled = false;
            f.txtCredits.Enabled = false;
            f.menuDegree.Enabled = false;
            f.txtGradStipend.Enabled = false;
            f.txtChairStipend.Enabled = false;

            f.menuDegree.SelectedIndex = -1;
            f.menuYear.SelectedIndex = -1;
            f.menuRank.SelectedIndex = -1;
            f.dtBday.Text = "12/31/2006";

        } // end resetForm



        // Activates and deactivates necessary form buttons
        //    when in add mode
        public static void formAddMode(frmMainForm f)
        {
            f.btnClearForm.Enabled = true;
            f.btnDelete.Enabled = false;
            f.btnEdit.Enabled = false;
            f.btnFind.Enabled = false;
        }  // end formAddMode


        // Enable/disable buttons when not in edit mode
        public static void activateAddButtons(frmMainForm f)
        {
            f.btnCreateGrad.Enabled = true;
            f.btnCreateChair.Enabled = true;
            f.btnCreateUndergrad.Enabled = true;
            f.btnCreateFaculty.Enabled = true;
        }  // end activateAddButtons


        // Enable/disable buttons when not in edit mode
        public static void deactivateAddButtons(frmMainForm f)
        {
            f.btnCreateGrad.Enabled = false;
            f.btnCreateChair.Enabled = false;
            f.btnCreateUndergrad.Enabled = false;
            f.btnCreateFaculty.Enabled = false;
        }  // end deactivateAddButtons


        // Enables OwlMember textboxes and highlights the OwlMember groupbox
        public static void activateOwlMember(frmMainForm f)
        {
            f.gbOwlMember.Enabled = true;
            f.gbOwlMember.BackColor = Color.LimeGreen;
            //f.txtID.Enabled = true;
            f.txtName.Enabled = true;
            f.dtBday.Enabled = true;

        }  // end activateOwlMember


        //  Enables Student textboxes and highlights the Student groupbox
        public static void activateStudent(frmMainForm f)
        {
            activateOwlMember(f);
            f.gbStudent.Enabled = true;
            f.txtMajor.Enabled = true;
            f.txtGPA.Enabled = true;
            f.gbStudent.BackColor = Color.LimeGreen;
        }  // end ActivateStudent


        // Enables Faculty textboxes and highlights the Faculty groupbox
        public static void activateFaculty(frmMainForm f)
        {
            activateOwlMember(f);
            f.txtDepartment.Enabled = true;
            f.menuRank.Enabled = true;
            f.gbFaculty.Enabled = true;
            f.gbFaculty.BackColor = Color.LimeGreen;
            f.gbStudent.BackColor = Color.Red;
        }  // end activateFaculty


        // Enables Undergrad Student textboxes and highlights the Undergrad Student groupbox
        public static void activateUndergraduateStudent(frmMainForm f)
        {
            activateStudent(f);   // Student must be activated too
            f.txtTuition.Enabled = true;
            f.txtCredits.Enabled = true;
            f.menuYear.Enabled = true;
            f.gbUndergrad.Enabled = true;
            f.gbUndergrad.BackColor = Color.LimeGreen;
        }  // end activateUndergraduateStudent


        // Enables Worker textboxes and highlights the Graduate Student groupbox
        public static void activateGraduateStudent(frmMainForm f)
        {
            activateStudent(f);  // Student must be activated too
            f.menuDegree.Enabled = true;
            f.txtGradStipend.Enabled = true;
            f.gbGrad.Enabled = true;
            f.gbGrad.BackColor = Color.LimeGreen;
        }  // end activateGraduateStudent


        // Enables Chairperson textboxes and highlights the Chairperson groupbox
        public static void activateChairperson(frmMainForm f)
        {
            f.gbChairperson.BackColor = Color.LimeGreen;
            activateFaculty(f);  // Faculty must be activated too
            f.txtChairStipend.Enabled = true;
            f.gbChairperson.Enabled = true;
           
            
            
            
            
        }  // end activateChairperson


        // Disables OwlMember textboxes and highlights the OwlMember groupbox
        public static void deactivateOwlMember(frmMainForm f)
        {
            deactivateStudent(f);
            deactivateFaculty(f);
            f.gbOwlMember.Enabled = false;
            f.gbOwlMember.BackColor = Color.Red;
        }  // end deactivateOwlMember


        // Disables Student textboxes and highlights the Student groupbox
        public static void deactivateStudent(frmMainForm f)
        {
            deactivateUndergraduateStudent(f);   // Must deactivate UG Student too
            deactivateGraduateStudent(f);        // Must deactivate Grad Student too
            f.gbStudent.Enabled = false;
            f.gbStudent.BackColor = Color.Red;
        }  // end deactivateStudent


        // Disables Faculty textboxes and highlights the Faculty groupbox
        public static void deactivateFaculty(frmMainForm f)
        {
            f.gbFaculty.Enabled = false;
            f.gbFaculty.BackColor = Color.Red;
        }  // end deactivateFaculty


        // Disables Undergraduate Student textboxes and highlights the Undergrad groupbox
        public static void deactivateUndergraduateStudent(frmMainForm f)
        {
            f.gbUndergrad.Enabled = false;
            f.gbUndergrad.BackColor = Color.Red;
        }  // end deactivateUndergraduateStudent


        // Disables Graduate Student textboxes and highlights the Grad Student groupbox
        public static void deactivateGraduateStudent(frmMainForm f)
        {
            f.gbGrad.Enabled = false;
            f.gbGrad.BackColor = Color.Red;
        }  // end deativateGraduateStudent


        // Disables Chairperson textboxes and highlights the Chairperson groupbox
        public static void deactivateChairperson(frmMainForm f)
        {
            f.gbFaculty.Enabled = false;
            f.gbChairperson.BackColor = Color.Red;
        }   // end deativateChairperson



        // Clear all textboxes on the form
        public static void clear(frmMainForm f)
        {
            f.txtName.Text = "";
            f.dtBday.Text = "";
            f.txtID.Text = "";
            f.txtID.Focus();
            f.txtDepartment.Text = "";
            f.menuRank.Text = "";
            f.txtMajor.Text = "";
            f.txtGPA.Text = "";
            f.txtTuition.Text = "";
            f.menuYear.Text = "";
            f.txtCredits.Text = "";
            f.txtGradStipend.Text = "";
            f.menuDegree.Text = "";
            f.txtChairStipend.Text = "";
            f.txtEnterID.Text = "";
            resetForm(f);
        } // end Clear


    }
}
