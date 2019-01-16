namespace AVALibrary.CompanyDb
{
    partial class FormContactPersonDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContactPersonDetails));
            this.buttonok = new System.Windows.Forms.Button();
            this.tableLayoutPanelLeftCol = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSkypeName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxAdditionalInfo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanelContactPersonDetails = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRightCol = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelProfilecontrols = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxProfilepath = new System.Windows.Forms.TextBox();
            this.buttonRemoveProfile = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUploadProfile = new System.Windows.Forms.Button();
            this.avaErrorProvider = new AVACore.UiControls.AvaErrorProvider();
            this.tableLayoutPanelLeftCol.SuspendLayout();
            this.tableLayoutPanelContactPersonDetails.SuspendLayout();
            this.tableLayoutPanelRightCol.SuspendLayout();
            this.tableLayoutPanelProfilecontrols.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonok
            // 
            this.buttonok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonok.Location = new System.Drawing.Point(333, 336);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(92, 23);
            this.buttonok.TabIndex = 44;
            this.buttonok.Text = "Ok";
            this.buttonok.UseVisualStyleBackColor = true;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // tableLayoutPanelLeftCol
            // 
            this.tableLayoutPanelLeftCol.AutoSize = true;
            this.tableLayoutPanelLeftCol.ColumnCount = 2;
            this.tableLayoutPanelContactPersonDetails.SetColumnSpan(this.tableLayoutPanelLeftCol, 3);
            this.tableLayoutPanelLeftCol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeftCol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 282F));
            this.tableLayoutPanelLeftCol.Controls.Add(this.textBoxSkypeName, 1, 7);
            this.tableLayoutPanelLeftCol.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanelLeftCol.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanelLeftCol.Controls.Add(this.textBoxEmail, 1, 6);
            this.tableLayoutPanelLeftCol.Controls.Add(this.dateTimePickerBirthday, 1, 5);
            this.tableLayoutPanelLeftCol.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanelLeftCol.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanelLeftCol.Controls.Add(this.textBoxPosition, 1, 0);
            this.tableLayoutPanelLeftCol.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanelLeftCol.Controls.Add(this.textBoxPhoneNumber, 1, 4);
            this.tableLayoutPanelLeftCol.Controls.Add(this.textBoxFirstName, 1, 1);
            this.tableLayoutPanelLeftCol.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanelLeftCol.Controls.Add(this.textBoxAdress, 1, 3);
            this.tableLayoutPanelLeftCol.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanelLeftCol.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanelLeftCol.Controls.Add(this.textBoxSurname, 1, 2);
            this.tableLayoutPanelLeftCol.Controls.Add(this.textBoxAdditionalInfo, 1, 8);
            this.tableLayoutPanelLeftCol.Controls.Add(this.label10, 0, 8);
            this.tableLayoutPanelLeftCol.Controls.Add(this.buttonImport, 0, 9);
            this.tableLayoutPanelLeftCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeftCol.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelLeftCol.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLeftCol.Name = "tableLayoutPanelLeftCol";
            this.tableLayoutPanelLeftCol.RowCount = 10;
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanelLeftCol.Size = new System.Drawing.Size(422, 327);
            this.tableLayoutPanelLeftCol.TabIndex = 48;
            // 
            // textBoxSkypeName
            // 
            this.textBoxSkypeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSkypeName.Location = new System.Drawing.Point(143, 210);
            this.textBoxSkypeName.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.textBoxSkypeName.MaxLength = 30;
            this.textBoxSkypeName.Name = "textBoxSkypeName";
            this.textBoxSkypeName.Size = new System.Drawing.Size(264, 20);
            this.textBoxSkypeName.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Skype Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEmail.Location = new System.Drawing.Point(143, 183);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.textBoxEmail.MaxLength = 50;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(264, 20);
            this.textBoxEmail.TabIndex = 34;
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(143, 156);
            this.dateTimePickerBirthday.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(264, 20);
            this.dateTimePickerBirthday.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Position";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPosition.Location = new System.Drawing.Point(143, 3);
            this.textBoxPosition.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.textBoxPosition.MaxLength = 100;
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(264, 20);
            this.textBoxPosition.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "First Name";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(143, 129);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.textBoxPhoneNumber.MaxLength = 20;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(264, 20);
            this.textBoxPhoneNumber.TabIndex = 40;
            this.textBoxPhoneNumber.Text = "43xxxxxxxxxxx";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFirstName.Location = new System.Drawing.Point(143, 30);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.textBoxFirstName.MaxLength = 50;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(264, 20);
            this.textBoxFirstName.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Phone Number";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAdress.Location = new System.Drawing.Point(143, 84);
            this.textBoxAdress.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.textBoxAdress.MaxLength = 200;
            this.textBoxAdress.Multiline = true;
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(264, 39);
            this.textBoxAdress.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date of Birth";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSurname.Location = new System.Drawing.Point(143, 57);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.textBoxSurname.MaxLength = 50;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(264, 20);
            this.textBoxSurname.TabIndex = 36;
            // 
            // textBoxAdditionalInfo
            // 
            this.textBoxAdditionalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAdditionalInfo.Location = new System.Drawing.Point(143, 237);
            this.textBoxAdditionalInfo.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.textBoxAdditionalInfo.MaxLength = 300;
            this.textBoxAdditionalInfo.Multiline = true;
            this.textBoxAdditionalInfo.Name = "textBoxAdditionalInfo";
            this.textBoxAdditionalInfo.Size = new System.Drawing.Size(264, 39);
            this.textBoxAdditionalInfo.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Additional Info";
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(3, 282);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 23);
            this.buttonImport.TabIndex = 49;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(517, 336);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(92, 23);
            this.buttonCancel.TabIndex = 45;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tableLayoutPanelContactPersonDetails
            // 
            this.tableLayoutPanelContactPersonDetails.ColumnCount = 4;
            this.tableLayoutPanelContactPersonDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5114F));
            this.tableLayoutPanelContactPersonDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.4886F));
            this.tableLayoutPanelContactPersonDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanelContactPersonDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanelContactPersonDetails.Controls.Add(this.tableLayoutPanelLeftCol, 0, 0);
            this.tableLayoutPanelContactPersonDetails.Controls.Add(this.tableLayoutPanelRightCol, 3, 0);
            this.tableLayoutPanelContactPersonDetails.Controls.Add(this.buttonok, 2, 1);
            this.tableLayoutPanelContactPersonDetails.Controls.Add(this.buttonCancel, 3, 1);
            this.tableLayoutPanelContactPersonDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContactPersonDetails.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelContactPersonDetails.Name = "tableLayoutPanelContactPersonDetails";
            this.tableLayoutPanelContactPersonDetails.RowCount = 2;
            this.tableLayoutPanelContactPersonDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContactPersonDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanelContactPersonDetails.Size = new System.Drawing.Size(612, 370);
            this.tableLayoutPanelContactPersonDetails.TabIndex = 47;
            // 
            // tableLayoutPanelRightCol
            // 
            this.tableLayoutPanelRightCol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelRightCol.AutoSize = true;
            this.tableLayoutPanelRightCol.ColumnCount = 1;
            this.tableLayoutPanelRightCol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRightCol.Controls.Add(this.tableLayoutPanelProfilecontrols, 0, 1);
            this.tableLayoutPanelRightCol.Controls.Add(this.pictureBoxProfile, 0, 0);
            this.tableLayoutPanelRightCol.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanelRightCol.Controls.Add(this.buttonUploadProfile, 0, 2);
            this.tableLayoutPanelRightCol.Location = new System.Drawing.Point(431, 3);
            this.tableLayoutPanelRightCol.Name = "tableLayoutPanelRightCol";
            this.tableLayoutPanelRightCol.RowCount = 4;
            this.tableLayoutPanelRightCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.76057F));
            this.tableLayoutPanelRightCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.23944F));
            this.tableLayoutPanelRightCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanelRightCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanelRightCol.Size = new System.Drawing.Size(178, 327);
            this.tableLayoutPanelRightCol.TabIndex = 49;
            // 
            // tableLayoutPanelProfilecontrols
            // 
            this.tableLayoutPanelProfilecontrols.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelProfilecontrols.ColumnCount = 2;
            this.tableLayoutPanelProfilecontrols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelProfilecontrols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanelProfilecontrols.Controls.Add(this.textBoxProfilepath, 1, 0);
            this.tableLayoutPanelProfilecontrols.Controls.Add(this.buttonRemoveProfile, 0, 0);
            this.tableLayoutPanelProfilecontrols.Location = new System.Drawing.Point(3, 179);
            this.tableLayoutPanelProfilecontrols.Name = "tableLayoutPanelProfilecontrols";
            this.tableLayoutPanelProfilecontrols.RowCount = 1;
            this.tableLayoutPanelProfilecontrols.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelProfilecontrols.Size = new System.Drawing.Size(172, 47);
            this.tableLayoutPanelProfilecontrols.TabIndex = 48;
            // 
            // textBoxProfilepath
            // 
            this.textBoxProfilepath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProfilepath.Location = new System.Drawing.Point(78, 2);
            this.textBoxProfilepath.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProfilepath.Name = "textBoxProfilepath";
            this.textBoxProfilepath.ReadOnly = true;
            this.textBoxProfilepath.Size = new System.Drawing.Size(92, 20);
            this.textBoxProfilepath.TabIndex = 93;
            this.textBoxProfilepath.TabStop = false;
            // 
            // buttonRemoveProfile
            // 
            this.buttonRemoveProfile.Location = new System.Drawing.Point(2, 2);
            this.buttonRemoveProfile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveProfile.Name = "buttonRemoveProfile";
            this.buttonRemoveProfile.Size = new System.Drawing.Size(71, 19);
            this.buttonRemoveProfile.TabIndex = 99;
            this.buttonRemoveProfile.Text = "Remove";
            this.buttonRemoveProfile.UseVisualStyleBackColor = true;
            this.buttonRemoveProfile.Click += new System.EventHandler(this.buttonRemoveProfile_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxProfile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfile.Image")));
            this.pictureBoxProfile.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfile.InitialImage")));
            this.pictureBoxProfile.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(172, 170);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 46;
            this.label1.Text = "For Best Results Use a Square Image";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonUploadProfile
            // 
            this.buttonUploadProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUploadProfile.Location = new System.Drawing.Point(3, 232);
            this.buttonUploadProfile.Name = "buttonUploadProfile";
            this.buttonUploadProfile.Size = new System.Drawing.Size(172, 30);
            this.buttonUploadProfile.TabIndex = 45;
            this.buttonUploadProfile.Text = "Select File";
            this.buttonUploadProfile.UseVisualStyleBackColor = true;
            this.buttonUploadProfile.Click += new System.EventHandler(this.buttonUploadProfile_Click);
            // 
            // avaErrorProvider
            // 
            this.avaErrorProvider.ContainerControl = this;
            // 
            // FormContactPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(612, 370);
            this.Controls.Add(this.tableLayoutPanelContactPersonDetails);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(628, 409);
            this.Name = "FormContactPersonDetails";
            this.Text = "ContactPersonDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormContactPersonDetails_FormClosing);
            this.Load += new System.EventHandler(this.FormContactPersonDetails_Load);
            this.tableLayoutPanelLeftCol.ResumeLayout(false);
            this.tableLayoutPanelLeftCol.PerformLayout();
            this.tableLayoutPanelContactPersonDetails.ResumeLayout(false);
            this.tableLayoutPanelContactPersonDetails.PerformLayout();
            this.tableLayoutPanelRightCol.ResumeLayout(false);
            this.tableLayoutPanelRightCol.PerformLayout();
            this.tableLayoutPanelProfilecontrols.ResumeLayout(false);
            this.tableLayoutPanelProfilecontrols.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeftCol;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxSkypeName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContactPersonDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRightCol;
        private System.Windows.Forms.Button buttonUploadProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProfilepath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProfilecontrols;
        private System.Windows.Forms.Button buttonRemoveProfile;
        private AVACore.UiControls.AvaErrorProvider avaErrorProvider;
        public System.Windows.Forms.PictureBox pictureBoxProfile;
        public System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.TextBox textBoxAdditionalInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonImport;
    }
}