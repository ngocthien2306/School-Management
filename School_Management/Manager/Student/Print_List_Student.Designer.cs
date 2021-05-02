
namespace School_Management.Manager.Student
{
    partial class Print_List_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print_List_Student));
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.DataSource_Student = new System.Windows.Forms.DataGridView();
            this.addStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manager_StudentDataSet = new School_Management.Manager_StudentDataSet();
            this.add_StudentTableAdapter = new School_Management.Manager_StudentDataSetTableAdapters.Add_StudentTableAdapter();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.barEditItem4 = new DevExpress.XtraBars.BarEditItem();
            this.Print_bt = new DevExpress.XtraEditors.SimpleButton();
            this.Check_Range = new DevExpress.XtraEditors.SimpleButton();
            this.Check_female = new DevExpress.XtraEditors.CheckEdit();
            this.Check_male = new DevExpress.XtraEditors.CheckEdit();
            this.Check_all = new DevExpress.XtraEditors.CheckEdit();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.TabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.Print_Excel = new DevExpress.XtraEditors.SimpleButton();
            this.Print_pdf = new DevExpress.XtraEditors.SimpleButton();
            this.TabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.And_lb = new DevExpress.XtraEditors.LabelControl();
            this.Day2 = new DevExpress.XtraEditors.DateEdit();
            this.Day1 = new DevExpress.XtraEditors.DateEdit();
            this.Between_lb = new DevExpress.XtraEditors.LabelControl();
            this.Range_Day = new DevExpress.XtraEditors.LabelControl();
            this.No_Check = new DevExpress.XtraEditors.CheckEdit();
            this.Yes_Check = new DevExpress.XtraEditors.CheckEdit();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSource_Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_female.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_male.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_all.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Day2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.No_Check.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yes_Check.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // DataSource_Student
            // 
            this.DataSource_Student.AutoGenerateColumns = false;
            this.DataSource_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSource_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.DataSource_Student.DataSource = this.addStudentBindingSource;
            this.DataSource_Student.Location = new System.Drawing.Point(1, 105);
            this.DataSource_Student.Name = "DataSource_Student";
            this.DataSource_Student.Size = new System.Drawing.Size(846, 429);
            this.DataSource_Student.TabIndex = 0;
            // 
            // addStudentBindingSource
            // 
            this.addStudentBindingSource.DataMember = "Add_Student";
            this.addStudentBindingSource.DataSource = this.manager_StudentDataSet;
            // 
            // manager_StudentDataSet
            // 
            this.manager_StudentDataSet.DataSetName = "Manager_StudentDataSet";
            this.manager_StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // add_StudentTableAdapter
            // 
            this.add_StudentTableAdapter.ClearBeforeFill = true;
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "barEditItem2";
            this.barEditItem3.Edit = this.repositoryItemCheckEdit1;
            this.barEditItem3.Id = 3;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // barEditItem4
            // 
            this.barEditItem4.Caption = "barEditItem2";
            this.barEditItem4.Edit = this.repositoryItemCheckEdit1;
            this.barEditItem4.Id = 3;
            this.barEditItem4.Name = "barEditItem4";
            // 
            // Print_bt
            // 
            this.Print_bt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Print_bt.ImageOptions.Image")));
            this.Print_bt.Location = new System.Drawing.Point(43, 3);
            this.Print_bt.Name = "Print_bt";
            this.Print_bt.Size = new System.Drawing.Size(46, 52);
            this.Print_bt.TabIndex = 5;
            this.Print_bt.Click += new System.EventHandler(this.Print_bt_Click);
            // 
            // Check_Range
            // 
            this.Check_Range.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Check_Range.ImageOptions.Image")));
            this.Check_Range.Location = new System.Drawing.Point(702, 10);
            this.Check_Range.Name = "Check_Range";
            this.Check_Range.Size = new System.Drawing.Size(75, 48);
            this.Check_Range.TabIndex = 4;
            this.Check_Range.Text = "Filter";
            this.Check_Range.Click += new System.EventHandler(this.Check_Range_Click);
            // 
            // Check_female
            // 
            this.Check_female.Location = new System.Drawing.Point(163, 24);
            this.Check_female.Name = "Check_female";
            this.Check_female.Properties.Caption = "Female";
            this.Check_female.Size = new System.Drawing.Size(75, 19);
            this.Check_female.TabIndex = 2;
            this.Check_female.CheckedChanged += new System.EventHandler(this.Check_female_CheckedChanged);
            // 
            // Check_male
            // 
            this.Check_male.Location = new System.Drawing.Point(82, 24);
            this.Check_male.Name = "Check_male";
            this.Check_male.Properties.Caption = "Male";
            this.Check_male.Size = new System.Drawing.Size(75, 19);
            this.Check_male.TabIndex = 1;
            this.Check_male.CheckedChanged += new System.EventHandler(this.Check_male_CheckedChanged);
            // 
            // Check_all
            // 
            this.Check_all.Location = new System.Drawing.Point(15, 24);
            this.Check_all.Name = "Check_all";
            this.Check_all.Properties.Caption = "All";
            this.Check_all.Size = new System.Drawing.Size(61, 19);
            this.Check_all.TabIndex = 0;
            this.Check_all.CheckedChanged += new System.EventHandler(this.Check_all_CheckedChanged);
            // 
            // TabControl1
            // 
            this.TabControl1.Location = new System.Drawing.Point(1, 2);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedTabPage = this.TabPage2;
            this.TabControl1.Size = new System.Drawing.Size(846, 97);
            this.TabControl1.TabIndex = 1;
            this.TabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPage1,
            this.TabPage2});
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.Print_Excel);
            this.TabPage2.Controls.Add(this.Print_pdf);
            this.TabPage2.Controls.Add(this.Print_bt);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(840, 69);
            this.TabPage2.Text = "Printer";
            // 
            // Print_Excel
            // 
            this.Print_Excel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Print_Excel.ImageOptions.Image")));
            this.Print_Excel.Location = new System.Drawing.Point(268, 3);
            this.Print_Excel.Name = "Print_Excel";
            this.Print_Excel.Size = new System.Drawing.Size(43, 52);
            this.Print_Excel.TabIndex = 7;
            // 
            // Print_pdf
            // 
            this.Print_pdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Print_pdf.ImageOptions.Image")));
            this.Print_pdf.Location = new System.Drawing.Point(158, 3);
            this.Print_pdf.Name = "Print_pdf";
            this.Print_pdf.Size = new System.Drawing.Size(45, 52);
            this.Print_pdf.TabIndex = 6;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.And_lb);
            this.TabPage1.Controls.Add(this.Check_Range);
            this.TabPage1.Controls.Add(this.Day2);
            this.TabPage1.Controls.Add(this.Day1);
            this.TabPage1.Controls.Add(this.Between_lb);
            this.TabPage1.Controls.Add(this.Range_Day);
            this.TabPage1.Controls.Add(this.No_Check);
            this.TabPage1.Controls.Add(this.Yes_Check);
            this.TabPage1.Controls.Add(this.Check_all);
            this.TabPage1.Controls.Add(this.Check_male);
            this.TabPage1.Controls.Add(this.Check_female);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(840, 69);
            this.TabPage1.Text = "Filter";
            // 
            // And_lb
            // 
            this.And_lb.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.And_lb.Appearance.Options.UseFont = true;
            this.And_lb.Location = new System.Drawing.Point(486, 45);
            this.And_lb.Name = "And_lb";
            this.And_lb.Size = new System.Drawing.Size(24, 16);
            this.And_lb.TabIndex = 14;
            this.And_lb.Text = "AND";
            // 
            // Day2
            // 
            this.Day2.EditValue = null;
            this.Day2.Location = new System.Drawing.Point(516, 44);
            this.Day2.Name = "Day2";
            this.Day2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Day2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Day2.Properties.MaxValue = new System.DateTime(2020, 12, 31, 23, 59, 0, 0);
            this.Day2.Properties.MinValue = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Day2.Size = new System.Drawing.Size(112, 20);
            this.Day2.TabIndex = 13;
            // 
            // Day1
            // 
            this.Day1.EditValue = null;
            this.Day1.Location = new System.Drawing.Point(366, 44);
            this.Day1.Name = "Day1";
            this.Day1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Day1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Day1.Properties.MaxValue = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.Day1.Properties.MinValue = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Day1.Size = new System.Drawing.Size(114, 20);
            this.Day1.TabIndex = 12;
            this.Day1.EditValueChanged += new System.EventHandler(this.Day1_EditValueChanged);
            // 
            // Between_lb
            // 
            this.Between_lb.Location = new System.Drawing.Point(269, 47);
            this.Between_lb.Name = "Between_lb";
            this.Between_lb.Size = new System.Drawing.Size(91, 13);
            this.Between_lb.TabIndex = 11;
            this.Between_lb.Text = "Birthday between  ";
            // 
            // Range_Day
            // 
            this.Range_Day.Location = new System.Drawing.Point(269, 8);
            this.Range_Day.Name = "Range_Day";
            this.Range_Day.Size = new System.Drawing.Size(74, 13);
            this.Range_Day.TabIndex = 10;
            this.Range_Day.Text = "Use Range Day";
            // 
            // No_Check
            // 
            this.No_Check.Location = new System.Drawing.Point(516, 5);
            this.No_Check.Name = "No_Check";
            this.No_Check.Properties.Caption = "No";
            this.No_Check.Size = new System.Drawing.Size(75, 19);
            this.No_Check.TabIndex = 9;
            // 
            // Yes_Check
            // 
            this.Yes_Check.Location = new System.Drawing.Point(366, 5);
            this.Yes_Check.Name = "Yes_Check";
            this.Yes_Check.Properties.Caption = "Yes";
            this.Yes_Check.Size = new System.Drawing.Size(75, 19);
            this.Yes_Check.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // Print_List_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 533);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.DataSource_Student);
            this.Name = "Print_List_Student";
            this.Text = "Printer";
            this.Load += new System.EventHandler(this.Print_List_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSource_Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_female.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_male.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_all.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Day2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.No_Check.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yes_Check.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataSource_Student;
        private Manager_StudentDataSet manager_StudentDataSet;
        private System.Windows.Forms.BindingSource addStudentBindingSource;
        private Manager_StudentDataSetTableAdapters.Add_StudentTableAdapter add_StudentTableAdapter;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraBars.BarEditItem barEditItem4;
        private DevExpress.XtraEditors.CheckEdit Check_female;
        private DevExpress.XtraEditors.CheckEdit Check_male;
        private DevExpress.XtraEditors.CheckEdit Check_all;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton Check_Range;
        private DevExpress.XtraEditors.SimpleButton Print_bt;
        private System.Drawing.Printing.PrintDocument printDocument;
        private DevExpress.XtraTab.XtraTabControl TabControl1;
        private DevExpress.XtraTab.XtraTabPage TabPage2;
        private DevExpress.XtraEditors.SimpleButton Print_Excel;
        private DevExpress.XtraEditors.SimpleButton Print_pdf;
        private DevExpress.XtraTab.XtraTabPage TabPage1;
        private DevExpress.XtraEditors.LabelControl And_lb;
        private DevExpress.XtraEditors.DateEdit Day2;
        private DevExpress.XtraEditors.DateEdit Day1;
        private DevExpress.XtraEditors.LabelControl Between_lb;
        private DevExpress.XtraEditors.LabelControl Range_Day;
        private DevExpress.XtraEditors.CheckEdit No_Check;
        private DevExpress.XtraEditors.CheckEdit Yes_Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
    }
}