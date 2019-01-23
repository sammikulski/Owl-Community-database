namespace OwlCommunityDB
{
    partial class frmMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDataProcessing = new System.Windows.Forms.GroupBox();
            this.btnProcessEdit = new System.Windows.Forms.Button();
            this.lblSearchDirections = new System.Windows.Forms.Label();
            this.txtEnterID = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbOwlMember = new System.Windows.Forms.GroupBox();
            this.dtBday = new System.Windows.Forms.DateTimePicker();
            this.gbStudent = new System.Windows.Forms.GroupBox();
            this.lblGPA = new System.Windows.Forms.Label();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.gbGrad = new System.Windows.Forms.GroupBox();
            this.menuDegree = new System.Windows.Forms.ComboBox();
            this.lblDegreeProgram = new System.Windows.Forms.Label();
            this.lblStipend = new System.Windows.Forms.Label();
            this.txtGradStipend = new System.Windows.Forms.TextBox();
            this.gbUndergrad = new System.Windows.Forms.GroupBox();
            this.menuYear = new System.Windows.Forms.ComboBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.txtTuition = new System.Windows.Forms.TextBox();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTuition = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.gbFaculty = new System.Windows.Forms.GroupBox();
            this.menuRank = new System.Windows.Forms.ComboBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.gbChairperson = new System.Windows.Forms.GroupBox();
            this.txtChairStipend = new System.Windows.Forms.TextBox();
            this.lblChairStipend = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.grpBoxNewEntry = new System.Windows.Forms.GroupBox();
            this.btnCreateUndergrad = new System.Windows.Forms.Button();
            this.btnCreateGrad = new System.Windows.Forms.Button();
            this.btnCreateFaculty = new System.Windows.Forms.Button();
            this.btnCreateChair = new System.Windows.Forms.Button();
            this.lblEnterDirections = new System.Windows.Forms.Label();
            this.lblPressBtnDirections = new System.Windows.Forms.Label();
            this.lblWelcomeMsg = new System.Windows.Forms.Label();
            this.gbDataProcessing.SuspendLayout();
            this.gbOwlMember.SuspendLayout();
            this.gbStudent.SuspendLayout();
            this.gbGrad.SuspendLayout();
            this.gbUndergrad.SuspendLayout();
            this.gbFaculty.SuspendLayout();
            this.gbChairperson.SuspendLayout();
            this.grpBoxNewEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDataProcessing
            // 
            this.gbDataProcessing.Controls.Add(this.btnProcessEdit);
            this.gbDataProcessing.Controls.Add(this.lblSearchDirections);
            this.gbDataProcessing.Controls.Add(this.txtEnterID);
            this.gbDataProcessing.Controls.Add(this.btnEdit);
            this.gbDataProcessing.Controls.Add(this.btnFind);
            this.gbDataProcessing.Controls.Add(this.btnCreate);
            this.gbDataProcessing.Controls.Add(this.btnDelete);
            this.gbDataProcessing.Location = new System.Drawing.Point(95, 576);
            this.gbDataProcessing.Name = "gbDataProcessing";
            this.gbDataProcessing.Size = new System.Drawing.Size(588, 90);
            this.gbDataProcessing.TabIndex = 33;
            this.gbDataProcessing.TabStop = false;
            this.gbDataProcessing.Text = "Data Processing";
            // 
            // btnProcessEdit
            // 
            this.btnProcessEdit.Location = new System.Drawing.Point(462, 58);
            this.btnProcessEdit.Name = "btnProcessEdit";
            this.btnProcessEdit.Size = new System.Drawing.Size(75, 23);
            this.btnProcessEdit.TabIndex = 27;
            this.btnProcessEdit.Text = "Process Edit";
            this.btnProcessEdit.UseVisualStyleBackColor = true;
            this.btnProcessEdit.Click += new System.EventHandler(this.btnProcessEdit_Click);
            // 
            // lblSearchDirections
            // 
            this.lblSearchDirections.AutoSize = true;
            this.lblSearchDirections.Location = new System.Drawing.Point(107, 27);
            this.lblSearchDirections.Name = "lblSearchDirections";
            this.lblSearchDirections.Size = new System.Drawing.Size(142, 13);
            this.lblSearchDirections.TabIndex = 26;
            this.lblSearchDirections.Text = "Search for an Existing TUID:";
            // 
            // txtEnterID
            // 
            this.txtEnterID.Location = new System.Drawing.Point(270, 23);
            this.txtEnterID.Name = "txtEnterID";
            this.txtEnterID.Size = new System.Drawing.Size(115, 20);
            this.txtEnterID.TabIndex = 25;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(328, 58);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(406, 22);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 18;
            this.btnFind.Text = "Find/Display";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(51, 58);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(84, 23);
            this.btnCreate.TabIndex = 20;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(194, 58);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Location = new System.Drawing.Point(700, 367);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 51);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbOwlMember
            // 
            this.gbOwlMember.Controls.Add(this.dtBday);
            this.gbOwlMember.Controls.Add(this.gbStudent);
            this.gbOwlMember.Controls.Add(this.gbFaculty);
            this.gbOwlMember.Controls.Add(this.lblID);
            this.gbOwlMember.Controls.Add(this.txtID);
            this.gbOwlMember.Controls.Add(this.lblName);
            this.gbOwlMember.Controls.Add(this.txtName);
            this.gbOwlMember.Controls.Add(this.lblBirthDate);
            this.gbOwlMember.Enabled = false;
            this.gbOwlMember.Location = new System.Drawing.Point(95, 189);
            this.gbOwlMember.Name = "gbOwlMember";
            this.gbOwlMember.Size = new System.Drawing.Size(588, 374);
            this.gbOwlMember.TabIndex = 30;
            this.gbOwlMember.TabStop = false;
            this.gbOwlMember.Text = "OwlMember";
            // 
            // dtBday
            // 
            this.dtBday.CustomFormat = "dd-mm-yyyy";
            this.dtBday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBday.Location = new System.Drawing.Point(447, 23);
            this.dtBday.MaxDate = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            this.dtBday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtBday.Name = "dtBday";
            this.dtBday.Size = new System.Drawing.Size(108, 20);
            this.dtBday.TabIndex = 14;
            this.dtBday.Value = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            // 
            // gbStudent
            // 
            this.gbStudent.Controls.Add(this.lblGPA);
            this.gbStudent.Controls.Add(this.txtMajor);
            this.gbStudent.Controls.Add(this.gbGrad);
            this.gbStudent.Controls.Add(this.gbUndergrad);
            this.gbStudent.Controls.Add(this.lblMajor);
            this.gbStudent.Controls.Add(this.txtGPA);
            this.gbStudent.Enabled = false;
            this.gbStudent.Location = new System.Drawing.Point(19, 172);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Size = new System.Drawing.Size(514, 185);
            this.gbStudent.TabIndex = 13;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = "Student";
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Location = new System.Drawing.Point(302, 20);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(29, 13);
            this.lblGPA.TabIndex = 25;
            this.lblGPA.Text = "GPA";
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(110, 17);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(100, 20);
            this.txtMajor.TabIndex = 24;
            // 
            // gbGrad
            // 
            this.gbGrad.Controls.Add(this.menuDegree);
            this.gbGrad.Controls.Add(this.lblDegreeProgram);
            this.gbGrad.Controls.Add(this.lblStipend);
            this.gbGrad.Controls.Add(this.txtGradStipend);
            this.gbGrad.Enabled = false;
            this.gbGrad.Location = new System.Drawing.Point(272, 57);
            this.gbGrad.Name = "gbGrad";
            this.gbGrad.Size = new System.Drawing.Size(216, 85);
            this.gbGrad.TabIndex = 1;
            this.gbGrad.TabStop = false;
            this.gbGrad.Text = "Graduate Student";
            // 
            // menuDegree
            // 
            this.menuDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuDegree.FormattingEnabled = true;
            this.menuDegree.Items.AddRange(new object[] {
            "Master",
            "Ph.D"});
            this.menuDegree.Location = new System.Drawing.Point(110, 58);
            this.menuDegree.Name = "menuDegree";
            this.menuDegree.Size = new System.Drawing.Size(100, 21);
            this.menuDegree.TabIndex = 30;
            // 
            // lblDegreeProgram
            // 
            this.lblDegreeProgram.AutoSize = true;
            this.lblDegreeProgram.Location = new System.Drawing.Point(14, 62);
            this.lblDegreeProgram.Name = "lblDegreeProgram";
            this.lblDegreeProgram.Size = new System.Drawing.Size(84, 13);
            this.lblDegreeProgram.TabIndex = 1;
            this.lblDegreeProgram.Text = "Degree Program";
            // 
            // lblStipend
            // 
            this.lblStipend.AutoSize = true;
            this.lblStipend.Location = new System.Drawing.Point(16, 20);
            this.lblStipend.Name = "lblStipend";
            this.lblStipend.Size = new System.Drawing.Size(43, 13);
            this.lblStipend.TabIndex = 0;
            this.lblStipend.Text = "Stipend";
            // 
            // txtGradStipend
            // 
            this.txtGradStipend.Location = new System.Drawing.Point(110, 16);
            this.txtGradStipend.Name = "txtGradStipend";
            this.txtGradStipend.Size = new System.Drawing.Size(100, 20);
            this.txtGradStipend.TabIndex = 2;
            // 
            // gbUndergrad
            // 
            this.gbUndergrad.Controls.Add(this.menuYear);
            this.gbUndergrad.Controls.Add(this.txtCredits);
            this.gbUndergrad.Controls.Add(this.txtTuition);
            this.gbUndergrad.Controls.Add(this.lblCredits);
            this.gbUndergrad.Controls.Add(this.lblYear);
            this.gbUndergrad.Controls.Add(this.lblTuition);
            this.gbUndergrad.Enabled = false;
            this.gbUndergrad.Location = new System.Drawing.Point(26, 48);
            this.gbUndergrad.Name = "gbUndergrad";
            this.gbUndergrad.Size = new System.Drawing.Size(200, 124);
            this.gbUndergrad.TabIndex = 0;
            this.gbUndergrad.TabStop = false;
            this.gbUndergrad.Text = "Undergraduate Student";
            // 
            // menuYear
            // 
            this.menuYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuYear.FormattingEnabled = true;
            this.menuYear.Items.AddRange(new object[] {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior"});
            this.menuYear.Location = new System.Drawing.Point(78, 87);
            this.menuYear.Name = "menuYear";
            this.menuYear.Size = new System.Drawing.Size(106, 21);
            this.menuYear.TabIndex = 29;
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(78, 54);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(106, 20);
            this.txtCredits.TabIndex = 28;
            // 
            // txtTuition
            // 
            this.txtTuition.Location = new System.Drawing.Point(78, 19);
            this.txtTuition.Name = "txtTuition";
            this.txtTuition.Size = new System.Drawing.Size(106, 20);
            this.txtTuition.TabIndex = 4;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(10, 58);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(39, 13);
            this.lblCredits.TabIndex = 26;
            this.lblCredits.Text = "Credits";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(10, 91);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 25;
            this.lblYear.Text = "Year";
            // 
            // lblTuition
            // 
            this.lblTuition.AutoSize = true;
            this.lblTuition.Location = new System.Drawing.Point(10, 23);
            this.lblTuition.Name = "lblTuition";
            this.lblTuition.Size = new System.Drawing.Size(39, 13);
            this.lblTuition.TabIndex = 24;
            this.lblTuition.Text = "Tuition";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(71, 21);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(33, 13);
            this.lblMajor.TabIndex = 11;
            this.lblMajor.Text = "Major";
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(344, 17);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(100, 20);
            this.txtGPA.TabIndex = 1;
            // 
            // gbFaculty
            // 
            this.gbFaculty.Controls.Add(this.menuRank);
            this.gbFaculty.Controls.Add(this.txtDepartment);
            this.gbFaculty.Controls.Add(this.lblRank);
            this.gbFaculty.Controls.Add(this.gbChairperson);
            this.gbFaculty.Controls.Add(this.label11);
            this.gbFaculty.Controls.Add(this.lblDepartment);
            this.gbFaculty.Enabled = false;
            this.gbFaculty.Location = new System.Drawing.Point(19, 60);
            this.gbFaculty.Name = "gbFaculty";
            this.gbFaculty.Size = new System.Drawing.Size(514, 105);
            this.gbFaculty.TabIndex = 11;
            this.gbFaculty.TabStop = false;
            this.gbFaculty.Text = "Faculty";
            // 
            // menuRank
            // 
            this.menuRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuRank.FormattingEnabled = true;
            this.menuRank.Items.AddRange(new object[] {
            "Instructor ",
            "Professor",
            "Assosciate Professor",
            "Assistant Professor",
            "Adjunt Professor"});
            this.menuRank.Location = new System.Drawing.Point(311, 19);
            this.menuRank.Name = "menuRank";
            this.menuRank.Size = new System.Drawing.Size(168, 21);
            this.menuRank.TabIndex = 31;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(129, 19);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(100, 20);
            this.txtDepartment.TabIndex = 24;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(268, 23);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(33, 13);
            this.lblRank.TabIndex = 28;
            this.lblRank.Text = "Rank";
            // 
            // gbChairperson
            // 
            this.gbChairperson.Controls.Add(this.txtChairStipend);
            this.gbChairperson.Controls.Add(this.lblChairStipend);
            this.gbChairperson.Enabled = false;
            this.gbChairperson.Location = new System.Drawing.Point(12, 45);
            this.gbChairperson.Name = "gbChairperson";
            this.gbChairperson.Size = new System.Drawing.Size(484, 48);
            this.gbChairperson.TabIndex = 12;
            this.gbChairperson.TabStop = false;
            this.gbChairperson.Text = "Chairperson";
            // 
            // txtChairStipend
            // 
            this.txtChairStipend.Location = new System.Drawing.Point(117, 22);
            this.txtChairStipend.Name = "txtChairStipend";
            this.txtChairStipend.Size = new System.Drawing.Size(100, 20);
            this.txtChairStipend.TabIndex = 24;
            // 
            // lblChairStipend
            // 
            this.lblChairStipend.AutoSize = true;
            this.lblChairStipend.Location = new System.Drawing.Point(9, 25);
            this.lblChairStipend.Name = "lblChairStipend";
            this.lblChairStipend.Size = new System.Drawing.Size(102, 13);
            this.lblChairStipend.TabIndex = 25;
            this.lblChairStipend.Text = "Chairperson Stipend";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "label11";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(60, 23);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 24;
            this.lblDepartment.Text = "Department";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(36, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(69, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(184, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(234, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(129, 20);
            this.txtName.TabIndex = 4;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(378, 26);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 10;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // btnClearForm
            // 
            this.btnClearForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearForm.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnClearForm.Location = new System.Drawing.Point(700, 280);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(61, 51);
            this.btnClearForm.TabIndex = 31;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // grpBoxNewEntry
            // 
            this.grpBoxNewEntry.Controls.Add(this.btnCreateUndergrad);
            this.grpBoxNewEntry.Controls.Add(this.btnCreateGrad);
            this.grpBoxNewEntry.Controls.Add(this.btnCreateFaculty);
            this.grpBoxNewEntry.Controls.Add(this.btnCreateChair);
            this.grpBoxNewEntry.Location = new System.Drawing.Point(95, 91);
            this.grpBoxNewEntry.Name = "grpBoxNewEntry";
            this.grpBoxNewEntry.Size = new System.Drawing.Size(588, 57);
            this.grpBoxNewEntry.TabIndex = 29;
            this.grpBoxNewEntry.TabStop = false;
            this.grpBoxNewEntry.Text = "Create a New Entry:";
            // 
            // btnCreateUndergrad
            // 
            this.btnCreateUndergrad.Location = new System.Drawing.Point(6, 19);
            this.btnCreateUndergrad.Name = "btnCreateUndergrad";
            this.btnCreateUndergrad.Size = new System.Drawing.Size(172, 23);
            this.btnCreateUndergrad.TabIndex = 13;
            this.btnCreateUndergrad.Text = "Create Undergraduate Student";
            this.btnCreateUndergrad.UseVisualStyleBackColor = true;
            this.btnCreateUndergrad.Click += new System.EventHandler(this.btnCreateUndergrad_Click);
            // 
            // btnCreateGrad
            // 
            this.btnCreateGrad.Location = new System.Drawing.Point(197, 19);
            this.btnCreateGrad.Name = "btnCreateGrad";
            this.btnCreateGrad.Size = new System.Drawing.Size(140, 23);
            this.btnCreateGrad.TabIndex = 14;
            this.btnCreateGrad.Text = "Create Graduate Student";
            this.btnCreateGrad.UseVisualStyleBackColor = true;
            this.btnCreateGrad.Click += new System.EventHandler(this.btnCreateGrad_Click);
            // 
            // btnCreateFaculty
            // 
            this.btnCreateFaculty.Location = new System.Drawing.Point(343, 19);
            this.btnCreateFaculty.Name = "btnCreateFaculty";
            this.btnCreateFaculty.Size = new System.Drawing.Size(100, 23);
            this.btnCreateFaculty.TabIndex = 15;
            this.btnCreateFaculty.Text = "Create Faculty";
            this.btnCreateFaculty.UseVisualStyleBackColor = true;
            this.btnCreateFaculty.Click += new System.EventHandler(this.btnCreateFaculty_Click);
            // 
            // btnCreateChair
            // 
            this.btnCreateChair.Location = new System.Drawing.Point(449, 19);
            this.btnCreateChair.Name = "btnCreateChair";
            this.btnCreateChair.Size = new System.Drawing.Size(108, 23);
            this.btnCreateChair.TabIndex = 16;
            this.btnCreateChair.Text = "Create Chairperson";
            this.btnCreateChair.UseVisualStyleBackColor = true;
            this.btnCreateChair.Click += new System.EventHandler(this.btnCreateChair_Click);
            // 
            // lblEnterDirections
            // 
            this.lblEnterDirections.AutoSize = true;
            this.lblEnterDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterDirections.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEnterDirections.Location = new System.Drawing.Point(4, 158);
            this.lblEnterDirections.Name = "lblEnterDirections";
            this.lblEnterDirections.Size = new System.Drawing.Size(770, 16);
            this.lblEnterDirections.TabIndex = 28;
            this.lblEnterDirections.Text = "To Find/SEARCH, Edit/UPDATE or DELETE enter person\'s ID and Select appropriate co" +
    "ntrol at bottom of form.";
            // 
            // lblPressBtnDirections
            // 
            this.lblPressBtnDirections.AutoSize = true;
            this.lblPressBtnDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressBtnDirections.Location = new System.Drawing.Point(34, 61);
            this.lblPressBtnDirections.Name = "lblPressBtnDirections";
            this.lblPressBtnDirections.Size = new System.Drawing.Size(710, 13);
            this.lblPressBtnDirections.TabIndex = 27;
            this.lblPressBtnDirections.Text = "To CREATE a new undergraduate or graduate student, faculty, or chairperson, alway" +
    "s press the button below before typing.";
            // 
            // lblWelcomeMsg
            // 
            this.lblWelcomeMsg.AutoSize = true;
            this.lblWelcomeMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMsg.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWelcomeMsg.Location = new System.Drawing.Point(150, 25);
            this.lblWelcomeMsg.Name = "lblWelcomeMsg";
            this.lblWelcomeMsg.Size = new System.Drawing.Size(478, 24);
            this.lblWelcomeMsg.TabIndex = 26;
            this.lblWelcomeMsg.Text = "Data Entry and Display for Temple Owl Community";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 707);
            this.Controls.Add(this.lblWelcomeMsg);
            this.Controls.Add(this.gbDataProcessing);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbOwlMember);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.grpBoxNewEntry);
            this.Controls.Add(this.lblEnterDirections);
            this.Controls.Add(this.lblPressBtnDirections);
            this.Name = "frmMainForm";
            this.Text = "Owl Community Data Entry (Database)";
            this.gbDataProcessing.ResumeLayout(false);
            this.gbDataProcessing.PerformLayout();
            this.gbOwlMember.ResumeLayout(false);
            this.gbOwlMember.PerformLayout();
            this.gbStudent.ResumeLayout(false);
            this.gbStudent.PerformLayout();
            this.gbGrad.ResumeLayout(false);
            this.gbGrad.PerformLayout();
            this.gbUndergrad.ResumeLayout(false);
            this.gbUndergrad.PerformLayout();
            this.gbFaculty.ResumeLayout(false);
            this.gbFaculty.PerformLayout();
            this.gbChairperson.ResumeLayout(false);
            this.gbChairperson.PerformLayout();
            this.grpBoxNewEntry.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox gbDataProcessing;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnFind;
        public System.Windows.Forms.Button btnCreate;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.GroupBox gbOwlMember;
        public System.Windows.Forms.DateTimePicker dtBday;
        public System.Windows.Forms.GroupBox gbStudent;
        public System.Windows.Forms.Label lblGPA;
        public System.Windows.Forms.TextBox txtMajor;
        public System.Windows.Forms.GroupBox gbGrad;
        public System.Windows.Forms.ComboBox menuDegree;
        public System.Windows.Forms.Label lblDegreeProgram;
        public System.Windows.Forms.Label lblStipend;
        public System.Windows.Forms.TextBox txtGradStipend;
        public System.Windows.Forms.GroupBox gbUndergrad;
        public System.Windows.Forms.ComboBox menuYear;
        public System.Windows.Forms.TextBox txtCredits;
        public System.Windows.Forms.TextBox txtTuition;
        public System.Windows.Forms.Label lblCredits;
        public System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.Label lblTuition;
        public System.Windows.Forms.Label lblMajor;
        public System.Windows.Forms.TextBox txtGPA;
        public System.Windows.Forms.GroupBox gbFaculty;
        public System.Windows.Forms.ComboBox menuRank;
        public System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblRank;
        public System.Windows.Forms.GroupBox gbChairperson;
        public System.Windows.Forms.TextBox txtChairStipend;
        public System.Windows.Forms.Label lblChairStipend;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lblDepartment;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label lblBirthDate;
        public System.Windows.Forms.Button btnClearForm;
        public System.Windows.Forms.GroupBox grpBoxNewEntry;
        public System.Windows.Forms.Button btnCreateUndergrad;
        public System.Windows.Forms.Button btnCreateGrad;
        public System.Windows.Forms.Button btnCreateFaculty;
        public System.Windows.Forms.Button btnCreateChair;
        public System.Windows.Forms.Label lblEnterDirections;
        public System.Windows.Forms.Label lblPressBtnDirections;
        public System.Windows.Forms.Label lblWelcomeMsg;
        public System.Windows.Forms.Label lblSearchDirections;
        public System.Windows.Forms.Button btnProcessEdit;
        public System.Windows.Forms.TextBox txtEnterID;
    }
}

