
namespace School_Management.Manager.Score
{
    partial class Add_Score
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Score));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.StudentGridControl = new DevExpress.XtraGrid.GridControl();
            this.add_StudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Student = new School_Management.DataSet_Student();
            this.GridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfirstname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collastname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabPage = new DevExpress.XtraTab.XtraTabPage();
            this.Des_tb = new DevExpress.XtraEditors.TextEdit();
            this.Score_tb = new DevExpress.XtraEditors.TextEdit();
            this.Id_tb = new DevExpress.XtraEditors.TextEdit();
            this.Add_bt = new DevExpress.XtraEditors.SimpleButton();
            this.ComboBox_Course = new System.Windows.Forms.ComboBox();
            this.Des_course = new DevExpress.XtraEditors.LabelControl();
            this.Score_lb = new DevExpress.XtraEditors.LabelControl();
            this.Course_list = new DevExpress.XtraEditors.LabelControl();
            this.Id_list = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.add_StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manager_StudentDataSet = new School_Management.Manager_StudentDataSet();
            this.add_StudentTableAdapter = new School_Management.Manager_StudentDataSetTableAdapters.Add_StudentTableAdapter();
            this.tableAdapterManager = new School_Management.Manager_StudentDataSetTableAdapters.TableAdapterManager();
            this.add_StudentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.add_StudentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.scoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreTableAdapter = new School_Management.DataSet_StudentTableAdapters.ScoreTableAdapter();
            this.tableAdapterManager1 = new School_Management.DataSet_StudentTableAdapters.TableAdapterManager();
            this.add_StudentTableAdapter1 = new School_Management.DataSet_StudentTableAdapters.Add_StudentTableAdapter();
            this.Avg_bt = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_StudentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Des_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Score_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Id_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_StudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_StudentBindingNavigator)).BeginInit();
            this.add_StudentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.StudentGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(880, 456);
            this.splitContainerControl1.SplitterPosition = 446;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // StudentGridControl
            // 
            this.StudentGridControl.DataSource = this.add_StudentBindingSource1;
            this.StudentGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentGridControl.Location = new System.Drawing.Point(0, 0);
            this.StudentGridControl.MainView = this.GridView;
            this.StudentGridControl.Name = "StudentGridControl";
            this.StudentGridControl.Size = new System.Drawing.Size(446, 456);
            this.StudentGridControl.TabIndex = 0;
            this.StudentGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView});
            // 
            // add_StudentBindingSource1
            // 
            this.add_StudentBindingSource1.DataMember = "Add_Student";
            this.add_StudentBindingSource1.DataSource = this.dataSet_Student;
            // 
            // dataSet_Student
            // 
            this.dataSet_Student.DataSetName = "DataSet_Student";
            this.dataSet_Student.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GridView
            // 
            this.GridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colfirstname,
            this.collastname});
            this.GridView.GridControl = this.StudentGridControl;
            this.GridView.Name = "GridView";
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colfirstname
            // 
            this.colfirstname.Caption = "First name";
            this.colfirstname.FieldName = "firstname";
            this.colfirstname.Name = "colfirstname";
            this.colfirstname.Visible = true;
            this.colfirstname.VisibleIndex = 1;
            // 
            // collastname
            // 
            this.collastname.Caption = "Last name";
            this.collastname.FieldName = "lastname";
            this.collastname.Name = "collastname";
            this.collastname.Visible = true;
            this.collastname.VisibleIndex = 2;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TabPage;
            this.xtraTabControl1.Size = new System.Drawing.Size(429, 456);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPage,
            this.xtraTabPage2});
            // 
            // TabPage
            // 
            this.TabPage.Controls.Add(this.Avg_bt);
            this.TabPage.Controls.Add(this.Des_tb);
            this.TabPage.Controls.Add(this.Score_tb);
            this.TabPage.Controls.Add(this.Id_tb);
            this.TabPage.Controls.Add(this.Add_bt);
            this.TabPage.Controls.Add(this.ComboBox_Course);
            this.TabPage.Controls.Add(this.Des_course);
            this.TabPage.Controls.Add(this.Score_lb);
            this.TabPage.Controls.Add(this.Course_list);
            this.TabPage.Controls.Add(this.Id_list);
            this.TabPage.Name = "TabPage";
            this.TabPage.Size = new System.Drawing.Size(423, 428);
            this.TabPage.Text = "xtraTabPage1";
            // 
            // Des_tb
            // 
            this.Des_tb.Location = new System.Drawing.Point(176, 256);
            this.Des_tb.Name = "Des_tb";
            this.Des_tb.Size = new System.Drawing.Size(219, 20);
            this.Des_tb.TabIndex = 8;
            // 
            // Score_tb
            // 
            this.Score_tb.Location = new System.Drawing.Point(176, 183);
            this.Score_tb.Name = "Score_tb";
            this.Score_tb.Size = new System.Drawing.Size(219, 20);
            this.Score_tb.TabIndex = 7;
            // 
            // Id_tb
            // 
            this.Id_tb.Location = new System.Drawing.Point(176, 60);
            this.Id_tb.Name = "Id_tb";
            this.Id_tb.Size = new System.Drawing.Size(219, 20);
            this.Id_tb.TabIndex = 6;
            // 
            // Add_bt
            // 
            this.Add_bt.Location = new System.Drawing.Point(39, 324);
            this.Add_bt.Name = "Add_bt";
            this.Add_bt.Size = new System.Drawing.Size(132, 36);
            this.Add_bt.TabIndex = 5;
            this.Add_bt.Text = "Add Score";
            this.Add_bt.Click += new System.EventHandler(this.Add_bt_Click);
            // 
            // ComboBox_Course
            // 
            this.ComboBox_Course.FormattingEnabled = true;
            this.ComboBox_Course.Location = new System.Drawing.Point(176, 115);
            this.ComboBox_Course.Name = "ComboBox_Course";
            this.ComboBox_Course.Size = new System.Drawing.Size(219, 21);
            this.ComboBox_Course.TabIndex = 4;
            // 
            // Des_course
            // 
            this.Des_course.Location = new System.Drawing.Point(39, 259);
            this.Des_course.Name = "Des_course";
            this.Des_course.Size = new System.Drawing.Size(53, 13);
            this.Des_course.TabIndex = 3;
            this.Des_course.Text = "Description";
            // 
            // Score_lb
            // 
            this.Score_lb.Location = new System.Drawing.Point(39, 186);
            this.Score_lb.Name = "Score_lb";
            this.Score_lb.Size = new System.Drawing.Size(27, 13);
            this.Score_lb.TabIndex = 2;
            this.Score_lb.Text = "Score";
            // 
            // Course_list
            // 
            this.Course_list.Location = new System.Drawing.Point(39, 123);
            this.Course_list.Name = "Course_list";
            this.Course_list.Size = new System.Drawing.Size(34, 13);
            this.Course_list.TabIndex = 1;
            this.Course_list.Text = "Course";
            // 
            // Id_list
            // 
            this.Id_list.Location = new System.Drawing.Point(39, 60);
            this.Id_list.Name = "Id_list";
            this.Id_list.Size = new System.Drawing.Size(52, 13);
            this.Id_list.TabIndex = 0;
            this.Id_list.Text = "ID Student";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(423, 428);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // add_StudentBindingSource
            // 
            this.add_StudentBindingSource.DataMember = "Add_Student";
            this.add_StudentBindingSource.DataSource = this.manager_StudentDataSet;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.Add_StudentTableAdapter = this.add_StudentTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CourseTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.NameTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = School_Management.Manager_StudentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // add_StudentBindingNavigator
            // 
            this.add_StudentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.add_StudentBindingNavigator.BindingSource = this.add_StudentBindingSource;
            this.add_StudentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.add_StudentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.add_StudentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.add_StudentBindingNavigatorSaveItem});
            this.add_StudentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.add_StudentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.add_StudentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.add_StudentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.add_StudentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.add_StudentBindingNavigator.Name = "add_StudentBindingNavigator";
            this.add_StudentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.add_StudentBindingNavigator.Size = new System.Drawing.Size(880, 25);
            this.add_StudentBindingNavigator.TabIndex = 1;
            this.add_StudentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // add_StudentBindingNavigatorSaveItem
            // 
            this.add_StudentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.add_StudentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("add_StudentBindingNavigatorSaveItem.Image")));
            this.add_StudentBindingNavigatorSaveItem.Name = "add_StudentBindingNavigatorSaveItem";
            this.add_StudentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.add_StudentBindingNavigatorSaveItem.Text = "Save Data";
            this.add_StudentBindingNavigatorSaveItem.Click += new System.EventHandler(this.add_StudentBindingNavigatorSaveItem_Click);
            // 
            // scoreBindingSource
            // 
            this.scoreBindingSource.DataMember = "Score";
            this.scoreBindingSource.DataSource = this.dataSet_Student;
            // 
            // scoreTableAdapter
            // 
            this.scoreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.Add_StudentTableAdapter = this.add_StudentTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ContactTableAdapter = null;
            this.tableAdapterManager1.CourseTableAdapter = null;
            this.tableAdapterManager1.LoginTableAdapter = null;
            this.tableAdapterManager1.NameTableAdapter = null;
            this.tableAdapterManager1.New_UserTableAdapter = null;
            this.tableAdapterManager1.ScoreTableAdapter = this.scoreTableAdapter;
            this.tableAdapterManager1.UpdateOrder = School_Management.DataSet_StudentTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // add_StudentTableAdapter1
            // 
            this.add_StudentTableAdapter1.ClearBeforeFill = true;
            // 
            // Avg_bt
            // 
            this.Avg_bt.Location = new System.Drawing.Point(276, 324);
            this.Avg_bt.Name = "Avg_bt";
            this.Avg_bt.Size = new System.Drawing.Size(119, 35);
            this.Avg_bt.TabIndex = 9;
            this.Avg_bt.Text = "Average";
            this.Avg_bt.Click += new System.EventHandler(this.Avg_bt_Click);
            // 
            // Add_Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 456);
            this.Controls.Add(this.add_StudentBindingNavigator);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Add_Score";
            this.Text = "Add Course";
            this.Load += new System.EventHandler(this.Add_Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_StudentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.TabPage.ResumeLayout(false);
            this.TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Des_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Score_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Id_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_StudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_StudentBindingNavigator)).EndInit();
            this.add_StudentBindingNavigator.ResumeLayout(false);
            this.add_StudentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private Manager_StudentDataSet manager_StudentDataSet;
        private System.Windows.Forms.BindingSource add_StudentBindingSource;
        private Manager_StudentDataSetTableAdapters.Add_StudentTableAdapter add_StudentTableAdapter;
        private Manager_StudentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator add_StudentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton add_StudentBindingNavigatorSaveItem;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabPage;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.LabelControl Des_course;
        private DevExpress.XtraEditors.LabelControl Score_lb;
        private DevExpress.XtraEditors.LabelControl Course_list;
        private DevExpress.XtraEditors.LabelControl Id_list;
        private System.Windows.Forms.ComboBox ComboBox_Course;
        private DataSet_Student dataSet_Student;
        private System.Windows.Forms.BindingSource scoreBindingSource;
        private DataSet_StudentTableAdapters.ScoreTableAdapter scoreTableAdapter;
        private DataSet_StudentTableAdapters.TableAdapterManager tableAdapterManager1;
        private DataSet_StudentTableAdapters.Add_StudentTableAdapter add_StudentTableAdapter1;
        private System.Windows.Forms.BindingSource add_StudentBindingSource1;
        private DevExpress.XtraGrid.GridControl StudentGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView;
        private DevExpress.XtraEditors.SimpleButton Add_bt;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colfirstname;
        private DevExpress.XtraGrid.Columns.GridColumn collastname;
        private DevExpress.XtraEditors.TextEdit Des_tb;
        private DevExpress.XtraEditors.TextEdit Score_tb;
        private DevExpress.XtraEditors.TextEdit Id_tb;
        private DevExpress.XtraEditors.SimpleButton Avg_bt;
    }
}