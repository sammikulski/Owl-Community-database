/*Project 4 - Final Project - Owl Community Database
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski, with code provided by Prof. Frank Friedman, Temple University
*This database class keeps track of all information needed to retrieve
* information from our local database. We can insert records, update records, 
* delete records, and use select statements.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using OwlCommunityDB.Models;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Globalization;

namespace OwlCommunityDB.Classes
{
    public class Database
    {

        // Connection string for OwlMemberDB (Microsoft Access) in the Resources folder
        string strConnection = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                               "Data Source=../Debug/Resources/OwlMemberDB.accdb";

        //insertion methods (inserts a record into the database)
        private bool InsertOwlMember(int OwlMemberID, string Name, DateTime BD)
        {
            //sql statement:
            String strInsertOwlMember = "INSERT INTO OWLMEMBER (fldID, fldName, fldBirthDate) " +
                "VALUES(" + OwlMemberID + " , '" + Name + "', '" + BD.ToString() + "' );";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertOwlMember, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert Owl Member error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }


        }
        //inserts a student into the database
        public bool InsertStudent(int OwlMemberID, string Name, DateTime BD, string Major, decimal GPA)
        {
            //when we insert a record into the student table, we also insert it into owlmember table
            InsertOwlMember(OwlMemberID, Name, BD);
            // SQL insert statement for student
            string strInsertStudent = "INSERT INTO STUDENT (fldID, fldMajor, fldGPA) " +
                "VALUES(" + OwlMemberID + " , '" + Major + "' , '" + GPA + "' );";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertStudent, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert Student error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }
        //inserts an undergraduate student 
        public bool InsertUndergradStudent(int OwlMemberID, string Name, DateTime BD, string Major, decimal GPA, decimal Tuition, string Year, int Credits){
            //when we insert an undergrad student, we also need to put it in the student table
            //which then puts it in the Owl member table
            InsertStudent(OwlMemberID, Name, BD, Major, GPA);
            //sql statement:
            string strInsertUndergradStudent = "INSERT INTO UNDERGRADUATESTUDENT (fldID, fldTuition, fldYear, fldCredits) " +
                "VALUES(" + OwlMemberID + " , '$" + Tuition + "' , '" + Year + "' , '" + Credits + "' );";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertUndergradStudent, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert Undergrad Student error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }
        }

        public bool InsertGradStudent(int OwlMemberID, string Name, DateTime BD, string Major, decimal GPA, string degree, decimal stipend)
        {
            //when we insert a grad student, we also need to put it in the student table
            //which then puts it in the Owl member table
            InsertStudent(OwlMemberID, Name, BD, Major, GPA);

            //sql statemenr:
            string strInsertGradStudent = "INSERT INTO GRADUATESTUDENT (fldID, fldDegreeProgram, fldStipend) " +
                "VALUES(" + OwlMemberID + " , '" + degree + "' , '$" + stipend + "' );";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertGradStudent, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert Grad Student error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }

        //insertion of a faculty member:
        public bool InsertFaculty(int OwlMemberID, string Name, DateTime BD, string Dept, string rank)
        {
            //when we insert a record  into thr faculty table, we also insert a record into the Owl Member table
            InsertOwlMember(OwlMemberID, Name, BD);
            // SQL insert statement for student
            string strInsertFaculty = "INSERT INTO FACULTY (fldID, fldDepartment, fldRank) " +
                "VALUES(" + OwlMemberID + " , '" + Dept + "' , '" + rank + "' );";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertFaculty, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert faculty error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }

        //insertion for a chairperson
        public bool InsertChair(int OwlMemberID, string Name, DateTime BD, string Dept, string rank, decimal stipend)
        {
            //when we insert a record into the chairperson table, we also insert a record into the faculty table
            //this, in return, inserts a record into the owlmember table as well
            InsertFaculty(OwlMemberID, Name, BD, Dept, rank);

            //sql statement:
            string strInsertChair = "INSERT INTO CHAIRPERSON (fldID, fldStipend) " +
                "VALUES(" + OwlMemberID + " , '$" + stipend + "' );";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertChair, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert chair error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }

        //this is called to find a person in the database
        //if found, it fills in the textboxes on the form with the appropriate info
        //returns true if a match was found
        public bool SelectOwlMember(int OwlMemberID, frmMainForm f)
        {
            int found = 0;
            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {
                try
                {
                    connection.Open();

                    using (OleDbCommand command1 = new OleDbCommand("SELECT * FROM OWLMEMBER WHERE fldID = " + OwlMemberID, connection))
                    {
                        OleDbDataReader reader = command1.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                f.gbOwlMember.BackColor = Color.LimeGreen;
                                f.txtID.Enabled = false;
                                f.txtID.Text = Convert.ToString(reader.GetInt32(0));
                                f.txtName.Text = reader.GetString(1);
                                f.dtBday.Value = reader.GetDateTime(2);
                            }
                            found++;
                        }
                    }
                    using (OleDbCommand command2 = new OleDbCommand("SELECT * FROM STUDENT WHERE fldID = " + OwlMemberID, connection))
                    {
                        OleDbDataReader reader = command2.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                f.gbStudent.BackColor = Color.LimeGreen;
                                f.txtMajor.Text = reader.GetString(1);
                                f.txtGPA.Text = reader.GetDecimal(2).ToString();
                            }
                            found++;
                        }
                    }
                    using (OleDbCommand command3 = new OleDbCommand("SELECT * FROM UNDERGRADUATESTUDENT WHERE fldID = " + OwlMemberID, connection))
                    {
                        OleDbDataReader reader = command3.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                f.gbUndergrad.BackColor = Color.LimeGreen;
                                f.txtID.Text = Convert.ToString(reader.GetInt32(0));
                                f.txtTuition.Text = Convert.ToString(reader.GetDecimal(1));
                                f.txtCredits.Text = Convert.ToString(reader.GetValue(3));
                                f.menuYear.Text = reader.GetValue(2).ToString();
                            }
                            found++;
                        }
                    }
                    using (OleDbCommand command4 = new OleDbCommand("SELECT * FROM GRADUATESTUDENT WHERE fldID = " + OwlMemberID, connection))
                    {
                        OleDbDataReader reader = command4.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                f.gbGrad.BackColor = Color.LimeGreen;
                                f.menuDegree.Text = reader.GetString(1) ;
                                f.txtGradStipend.Text = reader.GetDecimal(2).ToString();
                               
                            }
                            found++;
                        }
                    }
                    using (OleDbCommand command5 = new OleDbCommand("SELECT * FROM FACULTY WHERE fldID = " + OwlMemberID, connection))
                    {
                        OleDbDataReader reader = command5.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                f.gbFaculty.BackColor = Color.LimeGreen;
                                f.txtDepartment.Text = reader.GetString(1);
                                f.menuRank.Text = reader.GetString(2);
                            }
                            found++;
                        }
                    }
                    using (OleDbCommand command6 = new OleDbCommand("SELECT * FROM CHAIRPERSON WHERE fldID = " + OwlMemberID, connection))
                    {
                        OleDbDataReader reader = command6.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                f.gbChairperson.BackColor = Color.LimeGreen;
                                f.txtChairStipend.Text = reader.GetDecimal(1).ToString();
                            }
                            found++;
                        }
                    }
                    connection.Close();
                }
                catch (OleDbException ex)
                {
                    Console.Write("Error: " + ex.Message);
                    connection.Close();
                }
            }  // end using block
            if (found == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            // FormController.clear(this);
        }

        //we use this method check the database that there are no duplicated before we insert a new record
        //returns true if a selection was found
        public bool SelectMemberForAdd(int personID, frmMainForm f)
        {

            int found = 0;
            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command1 = new OleDbCommand("SELECT * FROM OWLMEMBER WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command1.ExecuteReader();
                        if (reader.HasRows)
                        {
                            found++;
                        }
                    }
                    using (OleDbCommand command2 = new OleDbCommand("SELECT * FROM STUDENT WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command2.ExecuteReader();
                        if (reader.HasRows)
                        {
                            found++;
                        }
                    }
                    using (OleDbCommand command3 = new OleDbCommand("SELECT * FROM UNDERGRADUATESTUDENT WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command3.ExecuteReader();
                        if (reader.HasRows)
                        {
                            found++;
                        }
                    }
                    using (OleDbCommand command4 = new OleDbCommand("SELECT * FROM GRADUATESTUDENT WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command4.ExecuteReader();
                        if (reader.HasRows)
                        {
                            found++;
                        }
                    }
                    using (OleDbCommand command5 = new OleDbCommand("SELECT * FROM FACULTY WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command5.ExecuteReader();
                        if (reader.HasRows)
                        {
                            found++;
                        }
                    }
                    using (OleDbCommand command6 = new OleDbCommand("SELECT * FROM CHAIRPERSON WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command6.ExecuteReader();
                        if (reader.HasRows)
                        {
                            found++;
                        }
                    }
                    connection.Close();
                }
                catch (OleDbException ex)
                {
                    Console.Write("Error: " + ex.Message);
                    connection.Close();
                }
            }  // end using block
            if (found == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            // FormController.clear(this);
        }

        //this method is called after a person is found from a search and the user wants to edit the information
        //returns true if an update was performed
        public bool UpdateOwlMember(int OwlMemberId, string name, DateTime BD)
        {
            string strUpdateOwlMember = "UPDATE OwlMember SET fldName = '" + name + "' , " +
               "fldBirthDate = '" + BD + "' WHERE fldId = " + OwlMemberId;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateOwlMember, myConnection);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update OwlMember error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }
            return true; //returns true if update was successful
        }

        //called when we want to update a record in the student table
        public bool UpdateStudent(int OwlMemberId, string name, DateTime BD, string major, decimal gpa)
        {
            UpdateOwlMember(OwlMemberId, name, BD);
            string strUpdateStudent = "UPDATE Student SET fldMajor = '" + major + "' , " +
                "fldGPA = '" + gpa + "' WHERE fldID = " + OwlMemberId;
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateStudent, myConnection);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update OwlMember error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }
            return true; //returns true if update was successful
        }


        //called when we want to update a record in the undergraduate student table
        public bool UpdateUndergradStudent(int OwlMemberId, string name, DateTime BD, string major, decimal gpa, decimal tuition, string year, int credits)
        {
            UpdateStudent(OwlMemberId, name, BD, major, gpa);
            string strUpdateUndergrad = "UPDATE UndergraduateStudent SET fldTuition = '" + tuition + "' , " +
               "fldYear = '" + year + "' , " + "fldCredits = '" + credits + "' WHERE fldId = " + OwlMemberId;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateUndergrad, myConnection);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update OwlMember error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }
            return true; //returns true if update was successful
        }

        //called when we want to update a record in the graduate student table
        public bool UpdateGradStudent(int OwlMemberId, string name, DateTime BD, string major, decimal gpa, string degree, decimal stipend)
        {
            UpdateStudent(OwlMemberId, name, BD, major, gpa);
            string strUpdateGrad = "UPDATE GraduateStudent SET fldDegreeProgram = '" + degree + "' , " +
                "fldStipend = '" + stipend + "'WHERE fldId = " + OwlMemberId;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateGrad, myConnection);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update OwlMember error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }
            return true; //returns true if update was successful
        }

        //called when we want to update a record in the faculty table
        public bool UpdateFaculty(int OwlMemberId, string name, DateTime BD, string dept, string rank)
        {
            UpdateOwlMember(OwlMemberId, name, BD);
            string strUpdateFaculty = "UPDATE FACULTY SET fldDepartment = '" + dept + "', " + "fldRank = '" + rank + "' WHERE fldID = " + OwlMemberId + ";";
                
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateFaculty, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update Faculty error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        }

        //called when we want to update a record in the chairperson table
        public bool UpdateChair(int OwlMemberId, string name, DateTime BD, string dept, string rank, decimal stipend)
        {
            UpdateFaculty(OwlMemberId, name, BD, dept, rank);
            string strUpdateChair = "UPDATE CHAIRPERSON SET fldStipend = '" + stipend + "' WHERE fldID = " + OwlMemberId + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateChair, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update Chair error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful

        }

        //deletes records from owlmember, student, undergraduatestudent, graduatestudent, faculty and chairperson tables
        //delted a record based on the owlmemberID

            //if a record is not found, the record will not be deleted
        public void Delete(int id)
        {
            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command1 = new OleDbCommand("DELETE FROM OWLMEMBER WHERE fldID = " + id, connection))
                    {
                        OleDbDataReader reader = command1.ExecuteReader();
                    }
                    using (OleDbCommand command2 = new OleDbCommand("DELETE FROM STUDENT WHERE fldID = " + id, connection))
                    {
                        OleDbDataReader reader = command2.ExecuteReader();
                    }
                    using (OleDbCommand command3 = new OleDbCommand("DELETE FROM UNDERGRADUATESTUDENT WHERE fldID = " + id, connection))
                    {
                        OleDbDataReader reader = command3.ExecuteReader();
                    }
                    using (OleDbCommand command4 = new OleDbCommand("DELETE FROM GRADUATESTUDENT WHERE fldID = " + id, connection))
                    {
                        OleDbDataReader reader = command4.ExecuteReader();
                    }
                    using (OleDbCommand command5 = new OleDbCommand("DELETE FROM FACULTY WHERE fldID = " + id, connection))
                    {
                        OleDbDataReader reader = command5.ExecuteReader();
                    }
                    using (OleDbCommand command6 = new OleDbCommand("DELETE FROM CHAIRPERSON WHERE fldID = " + id, connection))
                    {
                        OleDbDataReader reader = command6.ExecuteReader();
                    }

                    connection.Close();
                }
                catch (OleDbException ex)
                {
                    Console.Write("Error in deleting: " + ex.Message);
                    connection.Close();
                }
            }
        }

        //find all undergraduate students, graduate students, faculty, and chairpersons
        //creates an instance of each class
        public void createOwlMemberList()
        {
            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {
                try
                {
                    connection.Open();

                    using (OleDbCommand command1 = new OleDbCommand("SELECT OWLMEMBER.fldID, OWLMEMBER.fldName, OWLMEMBER.fldBirthDate, "
                                + "STUDENT.fldMajor, STUDENT.fldGPA "
                                + "FROM (OWLMEMBER INNER JOIN STUDENT ON OWLMEMBER.fldID = STUDENT.fldID);", connection))
                    {
                        OleDbDataReader reader = command1.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                DateTime bday = reader.GetDateTime(2);
                                string major = reader.GetString(3);
                                decimal gpa = reader.GetDecimal(4);
                                Student student = new Student(id, name, bday, major, gpa);
                                //GlobalData.owlList.addToList(student);
                            }
                        }
                    }

                    using (OleDbCommand command2 = new OleDbCommand("SELECT OWLMEMBER.fldID, OWLMEMBER.fldName, OWLMEMBER.fldBirthDate, "
                                + "STUDENT.fldMajor, STUDENT.fldGPA, "
                                + "UNDERGRADUATESTUDENT.fldTuition, UNDERGRADUATESTUDENT.fldYear, UNDERGRADUATESTUDENT.fldCredits "
                                + "FROM (OWLMEMBER INNER JOIN STUDENT ON OWLMEMBER.fldID = STUDENT.fldID) INNER JOIN UNDERGRADUATESTUDENT ON STUDENT.fldID = UNDERGRADUATESTUDENT.fldID;", connection))
                    {
                        OleDbDataReader reader = command2.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                DateTime bday = reader.GetDateTime(2);
                                string major = reader.GetString(3);
                                decimal gpa = reader.GetDecimal(4);
                                decimal tuition = reader.GetDecimal(5);
                                string year = reader.GetString(6);
                                int credits = reader.GetInt32(7);
                                UndergradStudent UG = new UndergradStudent(id, name, bday, major, gpa, tuition, year, credits);
                                //GlobalData.owlList.addToList(UG);
                            }
                        }

                    }
                    using (OleDbCommand command3 = new OleDbCommand("SELECT OWLMEMBER.fldID, OWLMEMBER.fldName,OWLMEMBER.fldBirthdate, "
                                + "STUDENT.fldMajor, STUDENT.fldGPA, "
                                + "GRADUATESTUDENT.fldDegreeProgram, GRADUATESTUDENT.fldStipend "
                                + "FROM (OWLMEMBER INNER JOIN STUDENT ON OWLMEMBER.fldID = STUDENT.fldID) INNER JOIN GRADUATESTUDENT ON STUDENT.fldID = GRADUATESTUDENT.fldID;", connection))
                    {
                        OleDbDataReader reader = command3.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())

                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                DateTime bday = reader.GetDateTime(2);
                                string major = reader.GetString(3);
                                decimal gpa = reader.GetDecimal(4);
                                string program = reader.GetString(5);
                                decimal stipend = reader.GetDecimal(6);
                                GradStudent GS = new GradStudent(id, name, bday, major, gpa, program, stipend);
                               // GlobalData.owlList.addToList(GS);
                            }
                        }
                    }
                    using (OleDbCommand command4 = new OleDbCommand("SELECT OWLMEMBER.fldID, OWLMEMBER.fldName, OWLMEMBER.fldBirthDate, "
                        + "FACULTY.fldDepartment, FACULTY.fldRank "
                        + "FROM OWLMEMBER INNER JOIN FACULTY ON OWLMEMBER.fldID = FACULTY.fldId;", connection))
                    {
                        OleDbDataReader reader = command4.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())

                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                DateTime bday = reader.GetDateTime(2);
                                string dept = Convert.ToString(reader.GetTextReader(3));
                                string rank = Convert.ToString(reader.GetTextReader(4));
                                Faculty member = new Faculty(id, name, bday, dept, rank);
                                //GlobalData.owlList.addToList(member);
                            }
                        }
                    }
                    using (OleDbCommand command5 = new OleDbCommand("SELECT OWLMEMBER.fldID, OWLMEMBER.fldName,OWLMEMBER.fldBirthdate, "
                        + "FACULTY.fldDepartment, FACULTY.fldRank, CHAIRPERSON.fldStipend "
                        + "FROM (OWLMEMBER INNER JOIN FACULTY ON OWLMEMBER.fldID = FACULTY.fldId) INNER JOIN CHAIRPERSON ON FACULTY.fldID = CHAIRPERSON.fldID;", connection))
                    {
                        OleDbDataReader reader = command5.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())

                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                DateTime bday = reader.GetDateTime(2);
                                string dept = reader.GetString(3);
                                string rank = reader.GetString(4);
                                decimal stipend = reader.GetDecimal(5);
                                Chairperson chair = new Chairperson(id, name, bday, dept, rank, stipend);
                                //GlobalData.owlList.addToList(chair);
                            }

                        }
                    }
                    connection.Close();
                }
                catch (OleDbException ex)
                {

                    Console.Write("Error: " + ex.Message);
                    connection.Close();

                }
            }
        }


    }
}


