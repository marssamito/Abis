namespace AVALibrary.CompanyDb
{
    partial class FormGewerk
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRightCol = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxServicesRequired = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelLeftCol = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxService = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelRightCol.SuspendLayout();
            this.tableLayoutPanelLeftCol.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(517, 334);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(92, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelRightCol, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelLeftCol, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonSave, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonCancel, 2, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(612, 370);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelRightCol
            // 
            this.tableLayoutPanelRightCol.ColumnCount = 1;
            this.tableLayoutPanelMain.SetColumnSpan(this.tableLayoutPanelRightCol, 2);
            this.tableLayoutPanelRightCol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRightCol.Controls.Add(this.listBoxServicesRequired, 0, 0);
            this.tableLayoutPanelRightCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRightCol.Location = new System.Drawing.Point(250, 0);
            this.tableLayoutPanelRightCol.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelRightCol.Name = "tableLayoutPanelRightCol";
            this.tableLayoutPanelRightCol.RowCount = 1;
            this.tableLayoutPanelRightCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRightCol.Size = new System.Drawing.Size(362, 331);
            this.tableLayoutPanelRightCol.TabIndex = 1;
            // 
            // listBoxServicesRequired
            // 
            this.listBoxServicesRequired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxServicesRequired.FormattingEnabled = true;
            this.listBoxServicesRequired.Location = new System.Drawing.Point(3, 3);
            this.listBoxServicesRequired.Name = "listBoxServicesRequired";
            this.listBoxServicesRequired.Size = new System.Drawing.Size(356, 325);
            this.listBoxServicesRequired.TabIndex = 0;
            // 
            // tableLayoutPanelLeftCol
            // 
            this.tableLayoutPanelLeftCol.ColumnCount = 1;
            this.tableLayoutPanelLeftCol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeftCol.Controls.Add(this.buttonAdd, 0, 1);
            this.tableLayoutPanelLeftCol.Controls.Add(this.buttonDelete, 0, 3);
            this.tableLayoutPanelLeftCol.Controls.Add(this.buttonEdit, 0, 2);
            this.tableLayoutPanelLeftCol.Controls.Add(this.textBoxService, 0, 0);
            this.tableLayoutPanelLeftCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeftCol.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLeftCol.MaximumSize = new System.Drawing.Size(244, 0);
            this.tableLayoutPanelLeftCol.Name = "tableLayoutPanelLeftCol";
            this.tableLayoutPanelLeftCol.RowCount = 6;
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelLeftCol.Size = new System.Drawing.Size(244, 325);
            this.tableLayoutPanelLeftCol.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Location = new System.Drawing.Point(3, 43);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(238, 24);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.Location = new System.Drawing.Point(3, 103);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(238, 24);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Loschen";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEdit.Location = new System.Drawing.Point(3, 73);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(238, 24);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Bearbeitung";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxService
            // 
            this.textBoxService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxService.Location = new System.Drawing.Point(3, 10);
            this.textBoxService.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBoxService.MaxLength = 200;
            this.textBoxService.Multiline = true;
            this.textBoxService.Name = "textBoxService";
            this.textBoxService.Size = new System.Drawing.Size(238, 27);
            this.textBoxService.TabIndex = 0;
            this.textBoxService.Text = "Type the subject here";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(374, 334);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Ok";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormGewerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(612, 370);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(628, 409);
            this.Name = "FormGewerk";
            this.Text = "FormGewerk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGewerk_FormClosing);
            this.Load += new System.EventHandler(this.FormGewerk_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelRightCol.ResumeLayout(false);
            this.tableLayoutPanelLeftCol.ResumeLayout(false);
            this.tableLayoutPanelLeftCol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRightCol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeftCol;
        private System.Windows.Forms.TextBox textBoxService;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonEdit;
        public System.Windows.Forms.ListBox listBoxServicesRequired;
        private System.Windows.Forms.Button buttonCancel;
    }
}