namespace AVALibrary.CompanyDb
{
    partial class FormCpyDetail
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelCompanyDetail = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRightcol = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelListBoxControls = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.listBoxContactPersonNames = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelLeftCol = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.CpyName = new System.Windows.Forms.Label();
            this.Street = new System.Windows.Forms.Label();
            this.textBoxCompname = new System.Windows.Forms.TextBox();
            this.countrySelectorFirm = new AVALibrary.Selectors.CountrySelector();
            this.textBoxroad = new System.Windows.Forms.TextBox();
            this.buttondelServices = new System.Windows.Forms.Button();
            this.comboBoxServicesOffered = new System.Windows.Forms.ComboBox();
            this.listBoxServicesOffered = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdditionalInfo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxinfo = new System.Windows.Forms.TextBox();
            this.textBoxpostcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonok = new System.Windows.Forms.Button();
            this.buttonCancelcpy = new System.Windows.Forms.Button();
            this.contextMenuStrip.SuspendLayout();
            this.tableLayoutPanelCompanyDetail.SuspendLayout();
            this.tableLayoutPanelRightcol.SuspendLayout();
            this.tableLayoutPanelListBoxControls.SuspendLayout();
            this.tableLayoutPanelLeftCol.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(108, 48);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // tableLayoutPanelCompanyDetail
            // 
            this.tableLayoutPanelCompanyDetail.ColumnCount = 3;
            this.tableLayoutPanelCompanyDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.13636F));
            this.tableLayoutPanelCompanyDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.86364F));
            this.tableLayoutPanelCompanyDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanelCompanyDetail.Controls.Add(this.tableLayoutPanelRightcol, 1, 0);
            this.tableLayoutPanelCompanyDetail.Controls.Add(this.tableLayoutPanelLeftCol, 0, 0);
            this.tableLayoutPanelCompanyDetail.Controls.Add(this.buttonok, 1, 1);
            this.tableLayoutPanelCompanyDetail.Controls.Add(this.buttonCancelcpy, 2, 1);
            this.tableLayoutPanelCompanyDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCompanyDetail.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelCompanyDetail.Name = "tableLayoutPanelCompanyDetail";
            this.tableLayoutPanelCompanyDetail.RowCount = 2;
            this.tableLayoutPanelCompanyDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.08108F));
            this.tableLayoutPanelCompanyDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.918919F));
            this.tableLayoutPanelCompanyDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCompanyDetail.Size = new System.Drawing.Size(612, 370);
            this.tableLayoutPanelCompanyDetail.TabIndex = 47;
            // 
            // tableLayoutPanelRightcol
            // 
            this.tableLayoutPanelRightcol.ColumnCount = 2;
            this.tableLayoutPanelCompanyDetail.SetColumnSpan(this.tableLayoutPanelRightcol, 2);
            this.tableLayoutPanelRightcol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.33333F));
            this.tableLayoutPanelRightcol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.66666F));
            this.tableLayoutPanelRightcol.Controls.Add(this.tableLayoutPanelListBoxControls, 0, 0);
            this.tableLayoutPanelRightcol.Controls.Add(this.listBoxContactPersonNames, 1, 0);
            this.tableLayoutPanelRightcol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRightcol.Location = new System.Drawing.Point(288, 3);
            this.tableLayoutPanelRightcol.Name = "tableLayoutPanelRightcol";
            this.tableLayoutPanelRightcol.RowCount = 1;
            this.tableLayoutPanelRightcol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRightcol.Size = new System.Drawing.Size(321, 330);
            this.tableLayoutPanelRightcol.TabIndex = 49;
            // 
            // tableLayoutPanelListBoxControls
            // 
            this.tableLayoutPanelListBoxControls.ColumnCount = 1;
            this.tableLayoutPanelListBoxControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelListBoxControls.Controls.Add(this.buttonDelete, 0, 3);
            this.tableLayoutPanelListBoxControls.Controls.Add(this.buttonEdit, 0, 2);
            this.tableLayoutPanelListBoxControls.Controls.Add(this.buttonAdd, 0, 1);
            this.tableLayoutPanelListBoxControls.Controls.Add(this.buttonView, 0, 0);
            this.tableLayoutPanelListBoxControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelListBoxControls.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelListBoxControls.Name = "tableLayoutPanelListBoxControls";
            this.tableLayoutPanelListBoxControls.RowCount = 5;
            this.tableLayoutPanelListBoxControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelListBoxControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelListBoxControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelListBoxControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelListBoxControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelListBoxControls.Size = new System.Drawing.Size(88, 324);
            this.tableLayoutPanelListBoxControls.TabIndex = 49;
            this.tableLayoutPanelListBoxControls.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelListBoxControls_Paint);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(3, 105);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 46;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(3, 71);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 44;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAdd.Location = new System.Drawing.Point(3, 37);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 45;
            this.buttonAdd.Text = "Add New";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(3, 3);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(75, 23);
            this.buttonView.TabIndex = 43;
            this.buttonView.Text = " View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // listBoxContactPersonNames
            // 
            this.listBoxContactPersonNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxContactPersonNames.FormattingEnabled = true;
            this.listBoxContactPersonNames.Location = new System.Drawing.Point(97, 3);
            this.listBoxContactPersonNames.Name = "listBoxContactPersonNames";
            this.listBoxContactPersonNames.Size = new System.Drawing.Size(221, 324);
            this.listBoxContactPersonNames.TabIndex = 42;
            // 
            // tableLayoutPanelLeftCol
            // 
            this.tableLayoutPanelLeftCol.ColumnCount = 3;
            this.tableLayoutPanelLeftCol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.57143F));
            this.tableLayoutPanelLeftCol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
            this.tableLayoutPanelLeftCol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanelLeftCol.Controls.Add(this.textBoxCity, 1, 3);
            this.tableLayoutPanelLeftCol.Controls.Add(this.CpyName, 0, 0);
            this.tableLayoutPanelLeftCol.Controls.Add(this.Street, 0, 1);
            this.tableLayoutPanelLeftCol.Controls.Add(this.textBoxCompname, 1, 0);
            this.tableLayoutPanelLeftCol.Controls.Add(this.countrySelectorFirm, 1, 2);
            this.tableLayoutPanelLeftCol.Controls.Add(this.textBoxroad, 1, 1);
            this.tableLayoutPanelLeftCol.Controls.Add(this.buttondelServices, 1, 7);
            this.tableLayoutPanelLeftCol.Controls.Add(this.comboBoxServicesOffered, 1, 6);
            this.tableLayoutPanelLeftCol.Controls.Add(this.listBoxServicesOffered, 2, 6);
            this.tableLayoutPanelLeftCol.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanelLeftCol.Controls.Add(this.AdditionalInfo, 0, 5);
            this.tableLayoutPanelLeftCol.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanelLeftCol.Controls.Add(this.textBoxinfo, 1, 5);
            this.tableLayoutPanelLeftCol.Controls.Add(this.textBoxpostcode, 1, 4);
            this.tableLayoutPanelLeftCol.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanelLeftCol.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanelLeftCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeftCol.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLeftCol.Name = "tableLayoutPanelLeftCol";
            this.tableLayoutPanelLeftCol.RowCount = 8;
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelLeftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelLeftCol.Size = new System.Drawing.Size(279, 330);
            this.tableLayoutPanelLeftCol.TabIndex = 48;
            // 
            // textBoxCity
            // 
            this.tableLayoutPanelLeftCol.SetColumnSpan(this.textBoxCity, 2);
            this.textBoxCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCity.Location = new System.Drawing.Point(52, 102);
            this.textBoxCity.MaxLength = 50;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(224, 20);
            this.textBoxCity.TabIndex = 49;
            // 
            // CpyName
            // 
            this.CpyName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CpyName.AutoSize = true;
            this.CpyName.Location = new System.Drawing.Point(3, 0);
            this.CpyName.Name = "CpyName";
            this.CpyName.Size = new System.Drawing.Size(43, 27);
            this.CpyName.TabIndex = 6;
            this.CpyName.Text = "Fimenname";
            // 
            // Street
            // 
            this.Street.AutoSize = true;
            this.Street.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Street.Location = new System.Drawing.Point(3, 27);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(43, 45);
            this.Street.TabIndex = 5;
            this.Street.Text = "Address";
            // 
            // textBoxCompname
            // 
            this.tableLayoutPanelLeftCol.SetColumnSpan(this.textBoxCompname, 2);
            this.textBoxCompname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCompname.Location = new System.Drawing.Point(52, 3);
            this.textBoxCompname.MaxLength = 50;
            this.textBoxCompname.Name = "textBoxCompname";
            this.textBoxCompname.Size = new System.Drawing.Size(224, 20);
            this.textBoxCompname.TabIndex = 3;
            // 
            // countrySelectorFirm
            // 
            this.tableLayoutPanelLeftCol.SetColumnSpan(this.countrySelectorFirm, 2);
            this.countrySelectorFirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countrySelectorFirm.Location = new System.Drawing.Point(49, 72);
            this.countrySelectorFirm.Margin = new System.Windows.Forms.Padding(0);
            this.countrySelectorFirm.Name = "countrySelectorFirm";
            this.countrySelectorFirm.ReadOnly = false;
            this.countrySelectorFirm.Size = new System.Drawing.Size(230, 27);
            this.countrySelectorFirm.TabIndex = 41;
            // 
            // textBoxroad
            // 
            this.tableLayoutPanelLeftCol.SetColumnSpan(this.textBoxroad, 2);
            this.textBoxroad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxroad.Location = new System.Drawing.Point(52, 30);
            this.textBoxroad.MaxLength = 150;
            this.textBoxroad.Multiline = true;
            this.textBoxroad.Name = "textBoxroad";
            this.textBoxroad.Size = new System.Drawing.Size(224, 39);
            this.textBoxroad.TabIndex = 16;
            // 
            // buttondelServices
            // 
            this.buttondelServices.Location = new System.Drawing.Point(52, 235);
            this.buttondelServices.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.buttondelServices.Name = "buttondelServices";
            this.buttondelServices.Size = new System.Drawing.Size(37, 23);
            this.buttondelServices.TabIndex = 47;
            this.buttondelServices.Text = "Delete";
            this.buttondelServices.UseVisualStyleBackColor = true;
            this.buttondelServices.Click += new System.EventHandler(this.buttondelServices_Click);
            // 
            // comboBoxServicesOffered
            // 
            this.comboBoxServicesOffered.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxServicesOffered.FormattingEnabled = true;
            this.comboBoxServicesOffered.Location = new System.Drawing.Point(52, 201);
            this.comboBoxServicesOffered.Name = "comboBoxServicesOffered";
            this.comboBoxServicesOffered.Size = new System.Drawing.Size(37, 21);
            this.comboBoxServicesOffered.TabIndex = 43;
            this.comboBoxServicesOffered.SelectedIndexChanged += new System.EventHandler(this.comboBoxServicesOffered_SelectedIndexChanged);
            // 
            // listBoxServicesOffered
            // 
            this.listBoxServicesOffered.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.listBoxServicesOffered.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxServicesOffered.FormattingEnabled = true;
            this.listBoxServicesOffered.Location = new System.Drawing.Point(95, 201);
            this.listBoxServicesOffered.Name = "listBoxServicesOffered";
            this.tableLayoutPanelLeftCol.SetRowSpan(this.listBoxServicesOffered, 2);
            this.listBoxServicesOffered.Size = new System.Drawing.Size(181, 126);
            this.listBoxServicesOffered.TabIndex = 44;
            this.listBoxServicesOffered.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxServicesOffered_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 27);
            this.label1.TabIndex = 42;
            this.label1.Text = "Services offered";
            // 
            // AdditionalInfo
            // 
            this.AdditionalInfo.AutoSize = true;
            this.AdditionalInfo.Location = new System.Drawing.Point(3, 153);
            this.AdditionalInfo.Name = "AdditionalInfo";
            this.AdditionalInfo.Size = new System.Drawing.Size(42, 26);
            this.AdditionalInfo.TabIndex = 13;
            this.AdditionalInfo.Text = "Additional Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Zipcode";
            // 
            // textBoxinfo
            // 
            this.tableLayoutPanelLeftCol.SetColumnSpan(this.textBoxinfo, 2);
            this.textBoxinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxinfo.Location = new System.Drawing.Point(52, 156);
            this.textBoxinfo.MaxLength = 250;
            this.textBoxinfo.Multiline = true;
            this.textBoxinfo.Name = "textBoxinfo";
            this.textBoxinfo.Size = new System.Drawing.Size(224, 39);
            this.textBoxinfo.TabIndex = 15;
            this.textBoxinfo.Text = "Optional";
            // 
            // textBoxpostcode
            // 
            this.tableLayoutPanelLeftCol.SetColumnSpan(this.textBoxpostcode, 2);
            this.textBoxpostcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxpostcode.Location = new System.Drawing.Point(52, 129);
            this.textBoxpostcode.MaxLength = 50;
            this.textBoxpostcode.Name = "textBoxpostcode";
            this.textBoxpostcode.Size = new System.Drawing.Size(224, 20);
            this.textBoxpostcode.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "City";
            // 
            // buttonok
            // 
            this.buttonok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonok.Location = new System.Drawing.Point(305, 339);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(92, 23);
            this.buttonok.TabIndex = 1;
            this.buttonok.Text = "Ok";
            this.buttonok.UseVisualStyleBackColor = true;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click_1);
            // 
            // buttonCancelcpy
            // 
            this.buttonCancelcpy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelcpy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancelcpy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelcpy.Location = new System.Drawing.Point(517, 339);
            this.buttonCancelcpy.Name = "buttonCancelcpy";
            this.buttonCancelcpy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCancelcpy.Size = new System.Drawing.Size(92, 23);
            this.buttonCancelcpy.TabIndex = 0;
            this.buttonCancelcpy.Text = "Cancel";
            this.buttonCancelcpy.UseVisualStyleBackColor = true;
            this.buttonCancelcpy.Click += new System.EventHandler(this.buttonCancelcpy_Click);
            // 
            // FormCpyDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 370);
            this.Controls.Add(this.tableLayoutPanelCompanyDetail);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(628, 409);
            this.Name = "FormCpyDetail";
            this.Text = "         ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCompanyDetail_FormClosing);
            this.Load += new System.EventHandler(this.FormCompanyDetail_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.tableLayoutPanelCompanyDetail.ResumeLayout(false);
            this.tableLayoutPanelRightcol.ResumeLayout(false);
            this.tableLayoutPanelListBoxControls.ResumeLayout(false);
            this.tableLayoutPanelLeftCol.ResumeLayout(false);
            this.tableLayoutPanelLeftCol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private AVACore.UiControls.AvaErrorProvider avaErrorProvider1;
        private System.Windows.Forms.TextBox textBoxCompname;
        private System.Windows.Forms.Label CpyName;
        private System.Windows.Forms.Label Street;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxroad;
        private System.Windows.Forms.TextBox textBoxinfo;
        private System.Windows.Forms.Label AdditionalInfo;
        private System.Windows.Forms.TextBox textBoxpostcode;
        private AVALibrary.Selectors.CountrySelector countrySelectorFirma;
        private System.Windows.Forms.Button buttonCancelcpy;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCompanyDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRightcol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeftCol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelListBoxControls;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBoxServicesOffered;
        public System.Windows.Forms.Button buttonok;
        public System.Windows.Forms.ListBox listBoxServicesOffered;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button buttondelServices;
        private System.Windows.Forms.TextBox textBoxCity;
        private Selectors.CountrySelector countrySelectorFirm;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox listBoxContactPersonNames;
    }
}