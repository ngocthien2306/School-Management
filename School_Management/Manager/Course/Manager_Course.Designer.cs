
namespace School_Management.Manager.Course
{
    partial class Manager_Course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Course));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.CourseGridControl = new DevExpress.XtraGrid.GridControl();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manager_StudentDataSet = new School_Management.Manager_StudentDataSet();
            this.CardView = new DevExpress.XtraGrid.Views.Card.CardView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.XtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.WindowsUIButtonPanel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.Period = new System.Windows.Forms.NumericUpDown();
            this.Rich_Description = new System.Windows.Forms.RichTextBox();
            this.Name_Course = new DevExpress.XtraEditors.TextEdit();
            this.ID_Course = new DevExpress.XtraEditors.TextEdit();
            this.Desc_lb = new DevExpress.XtraEditors.LabelControl();
            this.Period_lb = new DevExpress.XtraEditors.LabelControl();
            this.Name_lb = new DevExpress.XtraEditors.LabelControl();
            this.ID_lb = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.courseTableAdapter = new School_Management.Manager_StudentDataSetTableAdapters.CourseTableAdapter();
            this.tableAdapterManager = new School_Management.Manager_StudentDataSetTableAdapters.TableAdapterManager();
            this.NavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.NavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.NavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.NavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.XtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Period)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name_Course.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_Course.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).BeginInit();
            this.BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.CourseGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(933, 453);
            this.splitContainerControl1.SplitterPosition = 429;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // CourseGridControl
            // 
            this.CourseGridControl.DataSource = this.courseBindingSource;
            this.CourseGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseGridControl.Location = new System.Drawing.Point(0, 0);
            this.CourseGridControl.MainView = this.CardView;
            this.CourseGridControl.Name = "CourseGridControl";
            this.CourseGridControl.Size = new System.Drawing.Size(429, 453);
            this.CourseGridControl.TabIndex = 0;
            this.CourseGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CardView});
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.manager_StudentDataSet;
            // 
            // manager_StudentDataSet
            // 
            this.manager_StudentDataSet.DataSetName = "Manager_StudentDataSet";
            this.manager_StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CardView
            // 
            this.CardView.GridControl = this.CourseGridControl;
            this.CardView.Name = "CardView";
            this.CardView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.XtraTabPage;
            this.xtraTabControl1.Size = new System.Drawing.Size(499, 453);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.XtraTabPage,
            this.xtraTabPage2});
            // 
            // XtraTabPage
            // 
            this.XtraTabPage.Controls.Add(this.WindowsUIButtonPanel);
            this.XtraTabPage.Controls.Add(this.Period);
            this.XtraTabPage.Controls.Add(this.Rich_Description);
            this.XtraTabPage.Controls.Add(this.Name_Course);
            this.XtraTabPage.Controls.Add(this.ID_Course);
            this.XtraTabPage.Controls.Add(this.Desc_lb);
            this.XtraTabPage.Controls.Add(this.Period_lb);
            this.XtraTabPage.Controls.Add(this.Name_lb);
            this.XtraTabPage.Controls.Add(this.ID_lb);
            this.XtraTabPage.Name = "XtraTabPage";
            this.XtraTabPage.Size = new System.Drawing.Size(493, 425);
            this.XtraTabPage.Text = "Information";
            // 
            // WindowsUIButtonPanel
            // 
            this.WindowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WindowsUIButtonPanel.Location = new System.Drawing.Point(0, 357);
            this.WindowsUIButtonPanel.Name = "WindowsUIButtonPanel";
            this.WindowsUIButtonPanel.Size = new System.Drawing.Size(493, 68);
            this.WindowsUIButtonPanel.TabIndex = 9;
            this.WindowsUIButtonPanel.Text = "WindowsUIButtonPanel";
            this.WindowsUIButtonPanel.UseWaitCursor = true;
            this.WindowsUIButtonPanel.WrapButtons = true;
            this.WindowsUIButtonPanel.ButtonChecked += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.WindowsUIButtonPanel_ButtonChecked);
            this.WindowsUIButtonPanel.Click += new System.EventHandler(this.WindowsUIButtonPanel_Click);
            // 
            // Period
            // 
            this.Period.Location = new System.Drawing.Point(143, 135);
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(120, 21);
            this.Period.TabIndex = 8;
            // 
            // Rich_Description
            // 
            this.Rich_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rich_Description.Location = new System.Drawing.Point(143, 191);
            this.Rich_Description.Name = "Rich_Description";
            this.Rich_Description.Size = new System.Drawing.Size(306, 103);
            this.Rich_Description.TabIndex = 7;
            this.Rich_Description.Text = "";
            // 
            // Name_Course
            // 
            this.Name_Course.Location = new System.Drawing.Point(143, 82);
            this.Name_Course.Name = "Name_Course";
            this.Name_Course.Size = new System.Drawing.Size(306, 20);
            this.Name_Course.TabIndex = 5;
            // 
            // ID_Course
            // 
            this.ID_Course.Location = new System.Drawing.Point(143, 34);
            this.ID_Course.Name = "ID_Course";
            this.ID_Course.Size = new System.Drawing.Size(306, 20);
            this.ID_Course.TabIndex = 4;
            // 
            // Desc_lb
            // 
            this.Desc_lb.Location = new System.Drawing.Point(40, 197);
            this.Desc_lb.Name = "Desc_lb";
            this.Desc_lb.Size = new System.Drawing.Size(53, 13);
            this.Desc_lb.TabIndex = 3;
            this.Desc_lb.Text = "Description";
            // 
            // Period_lb
            // 
            this.Period_lb.Location = new System.Drawing.Point(40, 137);
            this.Period_lb.Name = "Period_lb";
            this.Period_lb.Size = new System.Drawing.Size(30, 13);
            this.Period_lb.TabIndex = 2;
            this.Period_lb.Text = "Period";
            // 
            // Name_lb
            // 
            this.Name_lb.Location = new System.Drawing.Point(40, 88);
            this.Name_lb.Name = "Name_lb";
            this.Name_lb.Size = new System.Drawing.Size(77, 13);
            this.Name_lb.TabIndex = 1;
            this.Name_lb.Text = "Name of Course";
            // 
            // ID_lb
            // 
            this.ID_lb.Location = new System.Drawing.Point(40, 37);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.Size = new System.Drawing.Size(48, 13);
            this.ID_lb.TabIndex = 0;
            this.ID_lb.Text = "ID Course";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(451, 425);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Add_StudentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CourseTableAdapter = this.courseTableAdapter;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.NameTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = School_Management.Manager_StudentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // NavigatorMoveFirstItem
            // 
            this.NavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("NavigatorMoveFirstItem.Image")));
            this.NavigatorMoveFirstItem.Name = "NavigatorMoveFirstItem";
            this.NavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.NavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.NavigatorMoveFirstItem.Text = "Move first";
            // 
            // NavigatorMovePreviousItem
            // 
            this.NavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("NavigatorMovePreviousItem.Image")));
            this.NavigatorMovePreviousItem.Name = "NavigatorMovePreviousItem";
            this.NavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.NavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.NavigatorMovePreviousItem.Text = "Move previous";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // NavigatorMoveNextItem
            // 
            this.NavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("NavigatorMoveNextItem.Image")));
            this.NavigatorMoveNextItem.Name = "NavigatorMoveNextItem";
            this.NavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.NavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.NavigatorMoveNextItem.Text = "Move next";
            // 
            // NavigatorMoveLastItem
            // 
            this.NavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("NavigatorMoveLastItem.Image")));
            this.NavigatorMoveLastItem.Name = "NavigatorMoveLastItem";
            this.NavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.NavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.NavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // NavigatorAddNewItem
            // 
            this.NavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("NavigatorAddNewItem.Image")));
            this.NavigatorAddNewItem.Name = "NavigatorAddNewItem";
            this.NavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.NavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.NavigatorAddNewItem.Text = "Add new";
            // 
            // NavigatorDeleteItem
            // 
            this.NavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("NavigatorDeleteItem.Image")));
            this.NavigatorDeleteItem.Name = "NavigatorDeleteItem";
            this.NavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.NavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.NavigatorDeleteItem.Text = "Delete";
            // 
            // BindingNavigatorSaveItem
            // 
            this.BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorSaveItem.Image")));
            this.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem";
            this.BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorSaveItem.Text = "Save Data";
            this.BindingNavigatorSaveItem.Click += new System.EventHandler(this.BindingNavigatorSaveItem_Click);
            // 
            // BindingNavigator
            // 
            this.BindingNavigator.AddNewItem = this.NavigatorAddNewItem;
            this.BindingNavigator.BindingSource = this.courseBindingSource;
            this.BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.BindingNavigator.DeleteItem = this.NavigatorDeleteItem;
            this.BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NavigatorMoveFirstItem,
            this.NavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.NavigatorMoveNextItem,
            this.NavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.NavigatorAddNewItem,
            this.NavigatorDeleteItem,
            this.BindingNavigatorSaveItem});
            this.BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.BindingNavigator.MoveFirstItem = this.NavigatorMoveFirstItem;
            this.BindingNavigator.MoveLastItem = this.NavigatorMoveLastItem;
            this.BindingNavigator.MoveNextItem = this.NavigatorMoveNextItem;
            this.BindingNavigator.MovePreviousItem = this.NavigatorMovePreviousItem;
            this.BindingNavigator.Name = "BindingNavigator";
            this.BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.BindingNavigator.Size = new System.Drawing.Size(933, 25);
            this.BindingNavigator.TabIndex = 1;
            // 
            // Manager_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 453);
            this.Controls.Add(this.BindingNavigator);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Manager_Course";
            this.Text = "Manager Course";
            this.Load += new System.EventHandler(this.Manager_Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourseGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.XtraTabPage.ResumeLayout(false);
            this.XtraTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Period)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name_Course.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_Course.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).EndInit();
            this.BindingNavigator.ResumeLayout(false);
            this.BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private Manager_StudentDataSet manager_StudentDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private Manager_StudentDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private Manager_StudentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl CourseGridControl;
        private DevExpress.XtraGrid.Views.Card.CardView CardView;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage XtraTabPage;
        private DevExpress.XtraEditors.TextEdit Name_Course;
        private DevExpress.XtraEditors.TextEdit ID_Course;
        private DevExpress.XtraEditors.LabelControl Desc_lb;
        private DevExpress.XtraEditors.LabelControl Period_lb;
        private DevExpress.XtraEditors.LabelControl Name_lb;
        private DevExpress.XtraEditors.LabelControl ID_lb;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.ToolStripButton NavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton NavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton NavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton NavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton NavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton NavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton BindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator BindingNavigator;
        private System.Windows.Forms.RichTextBox Rich_Description;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel WindowsUIButtonPanel;
        private System.Windows.Forms.NumericUpDown Period;
    }
}