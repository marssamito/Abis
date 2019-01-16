namespace AVALibrary.CompanyDb
{
    partial class FormCpyMain
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
            this.tableLayoutPanelControls = new System.Windows.Forms.TableLayoutPanel();
            this.buttoninsert = new System.Windows.Forms.Button();
            this.buttonedit = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonSubjects = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelControls
            // 
            this.tableLayoutPanelControls.ColumnCount = 2;
            this.tableLayoutPanelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelControls.Controls.Add(this.buttoninsert, 0, 0);
            this.tableLayoutPanelControls.Controls.Add(this.buttonedit, 0, 1);
            this.tableLayoutPanelControls.Controls.Add(this.buttondelete, 0, 2);
            this.tableLayoutPanelControls.Controls.Add(this.buttonSubjects, 0, 3);
            this.tableLayoutPanelControls.Controls.Add(this.listBox1, 1, 1);
            this.tableLayoutPanelControls.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelControls.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelControls.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelControls.Name = "tableLayoutPanelControls";
            this.tableLayoutPanelControls.RowCount = 5;
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelControls.Size = new System.Drawing.Size(612, 370);
            this.tableLayoutPanelControls.TabIndex = 8;
            // 
            // buttoninsert
            // 
            this.buttoninsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttoninsert.Location = new System.Drawing.Point(3, 3);
            this.buttoninsert.Name = "buttoninsert";
            this.buttoninsert.Size = new System.Drawing.Size(194, 24);
            this.buttoninsert.TabIndex = 0;
            this.buttoninsert.Text = "Neu Company";
            this.buttoninsert.UseVisualStyleBackColor = true;
            this.buttoninsert.Click += new System.EventHandler(this.buttoninsert_Click);
            // 
            // buttonedit
            // 
            this.buttonedit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonedit.Location = new System.Drawing.Point(3, 33);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(194, 24);
            this.buttonedit.TabIndex = 1;
            this.buttonedit.Text = "Bearbeitung";
            this.buttonedit.UseVisualStyleBackColor = true;
            this.buttonedit.Click += new System.EventHandler(this.buttonedit_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttondelete.Location = new System.Drawing.Point(3, 63);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(194, 24);
            this.buttondelete.TabIndex = 2;
            this.buttondelete.Text = "Loschen";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonSubjects
            // 
            this.buttonSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSubjects.Location = new System.Drawing.Point(3, 93);
            this.buttonSubjects.Name = "buttonSubjects";
            this.buttonSubjects.Size = new System.Drawing.Size(194, 24);
            this.buttonSubjects.TabIndex = 3;
            this.buttonSubjects.Text = "Gewerk";
            this.buttonSubjects.UseVisualStyleBackColor = true;
            this.buttonSubjects.Click += new System.EventHandler(this.buttonSubjects_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(203, 33);
            this.listBox1.Name = "listBox1";
            this.tableLayoutPanelControls.SetRowSpan(this.listBox1, 4);
            this.listBox1.Size = new System.Drawing.Size(406, 334);
            this.listBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select all"});
            this.comboBox1.Location = new System.Drawing.Point(203, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(406, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormCpyMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 370);
            this.Controls.Add(this.tableLayoutPanelControls);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(628, 409);
            this.Name = "FormCpyMain";
            this.Text = "FormCompanyDbMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCompanyDbMain_FormClosing);
            this.Load += new System.EventHandler(this.FormCompanyDbMain_Load);
            this.tableLayoutPanelControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelControls;
        private System.Windows.Forms.Button buttoninsert;
        private System.Windows.Forms.Button buttonedit;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonSubjects;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}