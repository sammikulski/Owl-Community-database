/*Project 4 - Final Project - Owl Community Database
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski, with code provided by Prof. Frank Friedman, Temple University
*This form managed the controls contained in the MainForm, and allows
* for manipulation of our data, and other classes
* We can Add, search, delete, and update/edit an OwlMember
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OwlCommunityDB.Controllers;
using OwlCommunityDB.Classes;
using System.Text.RegularExpressions;

namespace OwlCommunityDB
{
    public partial class frmMainForm : Form
    {

        //intialization:
        private Database db = new Database();

        private int selectedMember; // Keeps track of selected member type
        // Owl Member Attributes
        private int ID;
        private string name;

        // Faculty Attributes
        private string facultyDepartment;
        private decimal chairStipend;

        // Student Attributes
        private string studentMajor;
        private decimal studentGPA;
        private int studentCredits;
        private decimal studentTuition;
        private decimal gradStipend;

        // Attributes used for tracking state
        Models.OwlMember member;
        private bool addMode = false;
        private bool editMode = false;

        //startup:
        public frmMainForm()
        {
            InitializeComponent();
            FormController.resetForm(this);
            FormController.clear(this);
            db.createOwlMemberList();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }
        //resets and clears form
        //disables edit buttons
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            FormController.clear(this);
            FormController.resetForm(this);

        }

        //writes out file
        private void btnExit_Click(object sender, EventArgs e)
        {
            //SerializableFile.writeToFile(GlobalData.owlList, "StoreFile.bin");
            this.Close();
        }

        // For Creating Undergraduate Student
        private void btnCreateUndergrad_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = true;
            selectedMember = 1;
            btnCreateGrad.Enabled = false;
            btnCreateFaculty.Enabled = false;
            btnCreateChair.Enabled = false;

            //enable inputs:
            txtID.Enabled = true;
            txtID.Focus();
            txtID.Select();
            txtName.Enabled = true;
            dtBday.Enabled = true;
            txtMajor.Enabled = true;
            txtGPA.Enabled = true;
            menuYear.Enabled = true;
            txtTuition.Enabled = true;
            txtCredits.Enabled = true;


            FormController.formAddMode(this);
            FormController.activateUndergraduateStudent(this);
            addMode = true;

        }

        // For Creating Grad Student
        private void btnCreateGrad_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = true;
            selectedMember = 2;
            btnCreateUndergrad.Enabled = false;
            btnCreateFaculty.Enabled = false;
            btnCreateChair.Enabled = false;

            //enable inputs:
            txtID.Enabled = true;
            txtID.Focus();
            txtID.Select();
            txtName.Enabled = true;
            dtBday.Enabled = true;
            txtMajor.Enabled = true;
            txtGPA.Enabled = true;
            txtGradStipend.Enabled = true;
            menuDegree.Enabled = true;


            FormController.formAddMode(this);
            FormController.activateGraduateStudent(this);
            addMode = true;
        }

        //For creating faculty member
        private void btnCreateFaculty_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = true;
            selectedMember = 3;
            btnCreateUndergrad.Enabled = false;
            btnCreateGrad.Enabled = false;
            btnCreateChair.Enabled = false;

            txtID.Enabled = true;
            txtID.Focus();
            txtID.Select();
            txtName.Enabled = true;
            dtBday.Enabled = true;
            txtDepartment.Enabled = true;
            menuRank.Enabled = true;



            FormController.formAddMode(this);
            FormController.activateFaculty(this);
            addMode = true;

        }

        //for creating a chairperson
        private void btnCreateChair_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = true;
            selectedMember = 4;
            btnCreateUndergrad.Enabled = false;
            btnCreateGrad.Enabled = false;
            btnCreateFaculty.Enabled = false;

            txtID.Enabled = true;
            txtID.Focus();
            txtID.Select();
            txtName.Enabled = true;
            dtBday.Enabled = true;
            txtDepartment.Enabled = true;
            menuRank.Enabled = true;
            txtChairStipend.Enabled = true;

            FormController.formAddMode(this);
            FormController.activateChairperson(this);
            addMode = true;

        }

        //when the create button is initally clicked, this method
        //is used to decide "what" we will actually create, depending on what selectedMember is
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (addMode == true)
            {
                //if generic owlmember attributes are valid
                if (Validation.validateOwlMemberID(this) && Validation.validateName(this))
                {

                    int parsedValue = Convert.ToInt32(txtID.Text);
                    if (!int.TryParse(txtID.Text, out parsedValue))
                    {
                        MessageBox.Show("This field can only contain numbers");
                        FormController.resetForm(this);
                        txtID.Focus();
                        return;
                    }
                    if (db.SelectMemberForAdd(Convert.ToInt32(txtID.Text), this) == true)
                    {
                        MessageBox.Show("The ID for this Owl Member already exists");
                        FormController.resetForm(this);
                        txtID.Focus();
                        return;
                    }

                }

                //if the student attributes are valid
                if ((selectedMember == 1 || selectedMember == 2) && Validation.validateMajor(this) && Validation.validateGPA(this))
                {
                    if (selectedMember == 1)
                    {
                        //if credits and tuition are valid, we can add an undergraduate student
                        if ((Validation.validateCredits(this) && Validation.validateTuition(this) && Validation.menuYearValidation(this) && (selectedMember == 1)))
                        {
                            // Create Undergrad Student
                            ID = Convert.ToInt32(txtID.Text);
                            studentGPA = Convert.ToDecimal(txtGPA.Text);
                            studentMajor = Convert.ToString(txtMajor.Text);
                            studentTuition = Convert.ToDecimal(txtTuition.Text);
                            studentCredits = Convert.ToInt32(txtCredits.Text);
                            name = Convert.ToString(txtName.Text);
                            string year = menuYear.SelectedItem.ToString();

                            GlobalData.database.InsertUndergradStudent(ID, name, dtBday.Value.Date, studentMajor, studentGPA, studentTuition, year, studentCredits);

                            successfullyCreated();

                        }//end of undergrad

                    }




                    //if the stipend is valid, we can create a graduate student
                    else if ((selectedMember == 2) && Validation.validateGradStipend(this) && Validation.menuDegreeValidation(this))
                    {
                        // Create Graduate Student

                        ID = Convert.ToInt32(txtID.Text);
                        name = Convert.ToString(txtName.Text);
                        studentGPA = Convert.ToDecimal(txtGPA.Text);
                        studentMajor = Convert.ToString(txtMajor.Text);
                        gradStipend = Convert.ToDecimal(txtGradStipend.Text);


                        GlobalData.database.InsertGradStudent(ID, name, dtBday.Value.Date, studentMajor, studentGPA, menuDegree.SelectedItem.ToString(), gradStipend);
                        successfullyCreated();

                    }//end of graduate


                }//end of student attributes

                if ((selectedMember == 3 || selectedMember == 4) && Validation.validateDept(this) && Validation.menuRankValidation(this))
                {
                    // Create Faculty
                    if (selectedMember == 3)
                    {

                        ID = Convert.ToInt32(txtID.Text);
                        name = Convert.ToString(txtName.Text);
                        facultyDepartment = Convert.ToString(txtDepartment.Text);

                        GlobalData.database.InsertFaculty(ID, name, dtBday.Value.Date, facultyDepartment, menuRank.SelectedItem.ToString());
                        successfullyCreated();
                    }

                    if (selectedMember == 4 && Validation.validateChairStipend(this))
                    {
                        if (selectedMember == 4)
                        {
                            ID = Convert.ToInt32(txtID.Text);
                            name = Convert.ToString(txtName.Text);
                            facultyDepartment = Convert.ToString(txtDepartment.Text);
                            chairStipend = Convert.ToDecimal(txtChairStipend.Text);

                            GlobalData.database.InsertChair(ID, name, dtBday.Value.Date, facultyDepartment, menuRank.SelectedItem.ToString(), chairStipend);
                            successfullyCreated();
                        }
                    }

                }//end of faculty
            }//end of owl members




        }// end of create click

        //after a record is created, we show a message and reset the form
        private void successfullyCreated()
        {
            MessageBox.Show("OwlMember succesfully created!");
            FormController.clear(this);
        }


        //search for an owl member using the 9 digit ID
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEnterID.Text) || String.IsNullOrWhiteSpace(txtEnterID.Text) || (txtEnterID.Text.Length != 9))
            {
                MessageBox.Show("Please enter an extisting 9-Digit TUID. This Field cannot be blank");
                txtEnterID.Text = "";
                txtEnterID.Focus();
                txtEnterID.Select();
            }
            else
            {
                FormController.deactivateAddButtons(this);
                if (GlobalData.database.SelectOwlMember(Convert.ToInt32(txtEnterID.Text), this))
                {
                    btnEdit.Enabled = true;
                    btnProcessEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    MessageBox.Show("Person found");
                }
                else
                {
                    MessageBox.Show("No member exists with that TUID.", "Owl Member Not Found");
                    txtEnterID.Text = "";
                    txtEnterID.Focus();
                    txtEnterID.Select();
                }

            }

        }

        //edit button is enabled after an OwlMember is found
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnProcessEdit.Enabled = true;

            if (gbUndergrad.BackColor == Color.LimeGreen)
            {
                FormController.activateUndergraduateStudent(this);
            }
            if (gbGrad.BackColor == Color.LimeGreen)
            {
                FormController.activateGraduateStudent(this);
            }
            if (gbFaculty.BackColor == Color.LimeGreen)
            {
                FormController.activateFaculty(this);
            }
            if (gbChairperson.BackColor == Color.LimeGreen)
            {
                FormController.activateChairperson(this);
            }

        }

        //Ask user to confirm their deletion via dialogueresult (yes or no)
        //deletes the record from the database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            FormController.deactivateAddButtons(this);
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed deleting this record?", "Deletion Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                db.Delete(Convert.ToInt32(txtID.Text));
                FormController.resetForm(this); ;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }


        }

        //Sets the color to green, disable and enable relevant buttons and text boxes, for editing current person
        //calls update methods from database class
        //resets form afterwards
        private void btnProcessEdit_Click(object sender, EventArgs e)
        {
            if (gbUndergrad.BackColor == Color.LimeGreen)
            {
                ID = Convert.ToInt32(txtID.Text);
                studentGPA = Convert.ToDecimal(txtGPA.Text);
                studentMajor = Convert.ToString(txtMajor.Text);
                studentTuition = Convert.ToDecimal(txtTuition.Text);
                studentCredits = Convert.ToInt32(txtCredits.Text);
                name = Convert.ToString(txtName.Text);


                db.UpdateUndergradStudent(ID, name, dtBday.Value.Date, studentMajor, studentGPA, studentTuition, menuYear.SelectedItem.ToString(), studentCredits);

                MessageBox.Show("Undergrad Student has Been updated");
                FormController.resetForm(this);
            }
            if (gbGrad.BackColor == Color.LimeGreen)
            {
                ID = Convert.ToInt32(txtID.Text);
                name = Convert.ToString(txtName.Text);
                studentGPA = Convert.ToDecimal(txtGPA.Text);
                studentMajor = Convert.ToString(txtMajor.Text);
                gradStipend = Convert.ToDecimal(txtGradStipend.Text);

                db.UpdateGradStudent(ID, name, dtBday.Value.Date, studentMajor, studentGPA, menuDegree.SelectedItem.ToString(), gradStipend);

                MessageBox.Show("Grad Student has Been updated");
                FormController.resetForm(this);
            }
            if (gbChairperson.BackColor == Color.LimeGreen)
            {
                ID = Convert.ToInt32(txtID.Text);
                name = Convert.ToString(txtName.Text);
                facultyDepartment = Convert.ToString(txtDepartment.Text);
                chairStipend = Convert.ToDecimal(txtChairStipend.Text);
                db.UpdateChair(ID, name, dtBday.Value.Date, facultyDepartment, menuRank.Text, chairStipend);


                MessageBox.Show("Chairperson has Been updated");
                FormController.resetForm(this);
            }
            if (gbFaculty.BackColor == Color.LimeGreen)
            {
                ID = Convert.ToInt32(txtID.Text);
                name = Convert.ToString(txtName.Text);
                facultyDepartment = Convert.ToString(txtDepartment.Text);
                db.UpdateFaculty(ID, name, dtBday.Value.Date, facultyDepartment, menuRank.SelectedItem.ToString());

                MessageBox.Show("Faculty Member has Been updated");
                FormController.resetForm(this);


            }

        }
    }
}


