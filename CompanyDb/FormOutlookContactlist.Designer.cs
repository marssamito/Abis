namespace AVALibrary.CompanyDb
{
    partial class FormOutlookContactlist
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLeftCol = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGoogle = new System.Windows.Forms.Button();
            this.buttonOutlook = new System.Windows.Forms.Button();
            this.tableLayoutPanelRightCol = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new AVACore.UiControls.DataGrid.AvaDataGridView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelLeftCol.SuspendLayout();
            this.tableLayoutPanelRightCol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelLeftCol, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelRightCol, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonCancel, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonOk, 1, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(474, 451);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelLeftCol
            // 
            this.tableLayoutPanelLeftCol.ColumnCount = 1;
            this.tableLayoutPanelLeftCol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLeftCol.Controls.Add(this.buttonGoogle, 0, 1);
            this.tableLayoutPanelLeftCol.Controls.Add(this.buttonOutlook, 0, 0);
            this.tableLayoutPanelLeftCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeftCol.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLeftCol.Name = "tableLayoutPanelLeftCol";
            this.tableLayoutPanelLeftCol.RowCount = 3;
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tableLayoutPanelLeftCol.Size = new System.Drawing.Size(112, 406);
            this.tableLayoutPanelLeftCol.TabIndex = 1;
            // 
            // buttonGoogle
            // 
            this.buttonGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGoogle.Location = new System.Drawing.Point(9, 41);
            this.buttonGoogle.Name = "buttonGoogle";
            this.buttonGoogle.Size = new System.Drawing.Size(100, 23);
            this.buttonGoogle.TabIndex = 6;
            this.buttonGoogle.Text = "GoogleContacts";
            this.buttonGoogle.UseVisualStyleBackColor = true;
            this.buttonGoogle.Click += new System.EventHandler(this.buttonGoogle_Click);
            // 
            // buttonOutlook
            // 
            this.buttonOutlook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOutlook.Location = new System.Drawing.Point(9, 3);
            this.buttonOutlook.Name = "buttonOutlook";
            this.buttonOutlook.Size = new System.Drawing.Size(100, 23);
            this.buttonOutlook.TabIndex = 5;
            this.buttonOutlook.Text = "OutlookContacts";
            this.buttonOutlook.UseVisualStyleBackColor = true;
            this.buttonOutlook.Click += new System.EventHandler(this.buttonOutlook_Click);
            // 
            // tableLayoutPanelRightCol
            // 
            this.tableLayoutPanelRightCol.ColumnCount = 1;
            this.tableLayoutPanelMain.SetColumnSpan(this.tableLayoutPanelRightCol, 2);
            this.tableLayoutPanelRightCol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRightCol.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanelRightCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRightCol.Location = new System.Drawing.Point(121, 3);
            this.tableLayoutPanelRightCol.Name = "tableLayoutPanelRightCol";
            this.tableLayoutPanelRightCol.RowCount = 1;
            this.tableLayoutPanelRightCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRightCol.Size = new System.Drawing.Size(350, 406);
            this.tableLayoutPanelRightCol.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectedIndex = "";
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new System.Drawing.Size(344, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(396, 415);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(279, 415);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormOutlookContactlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 451);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MaximumSize = new System.Drawing.Size(490, 490);
            this.MinimumSize = new System.Drawing.Size(490, 490);
            this.Name = "FormOutlookContactlist";
            this.Text = "FormOutlookContactlist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOutlookContactlist_FormClosing);
            this.Load += new System.EventHandler(this.FormOutlookContactlist_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelLeftCol.ResumeLayout(false);
            this.tableLayoutPanelRightCol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeftCol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRightCol;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonGoogle;
        private System.Windows.Forms.Button buttonOutlook;
        private AVACore.UiControls.DataGrid.AvaDataGridView dataGridView1;
    }
}