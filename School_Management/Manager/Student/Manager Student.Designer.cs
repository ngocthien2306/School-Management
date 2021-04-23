
namespace School_Management.Manager.Student
{
    partial class Manager_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Student));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.M010201 = new DevExpress.XtraBars.BarButtonItem();
            this.M010202 = new DevExpress.XtraBars.BarButtonItem();
            this.m010101 = new DevExpress.XtraBars.BarButtonItem();
            this.M010102 = new DevExpress.XtraBars.BarButtonItem();
            this.M010103 = new DevExpress.XtraBars.BarButtonItem();
            this.M010203 = new DevExpress.XtraBars.BarButtonItem();
            this.M010401 = new DevExpress.XtraBars.BarButtonItem();
            this.M010402 = new DevExpress.XtraBars.BarButtonItem();
            this.M010403 = new DevExpress.XtraBars.BarButtonItem();
            this.M010404 = new DevExpress.XtraBars.BarButtonItem();
            this.M010501 = new DevExpress.XtraBars.BarButtonItem();
            this.M01050101 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.M01 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.M0101 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.M0102 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.M0103 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.m0105 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.M010601 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.M02 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.M03 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.DataGrid_Student = new DevExpress.XtraGrid.GridControl();
            this.add_StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manager_StudentDataSet = new School_Management.Manager_StudentDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfirstname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collastname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.add_StudentTableAdapter = new School_Management.Manager_StudentDataSetTableAdapters.Add_StudentTableAdapter();
            this.tableAdapterManager = new School_Management.Manager_StudentDataSetTableAdapters.TableAdapterManager();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_StudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.M010201,
            this.M010202,
            this.m010101,
            this.M010102,
            this.M010103,
            this.M010203,
            this.M010401,
            this.M010402,
            this.M010403,
            this.M010404,
            this.M010501,
            this.M01050101,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 19;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.M01,
            this.M02,
            this.M03});
            this.ribbon.Size = new System.Drawing.Size(959, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // M010201
            // 
            this.M010201.Caption = "Manager Student";
            this.M010201.Id = 1;
            this.M010201.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("M010201.ImageOptions.SvgImage")));
            this.M010201.Name = "M010201";
            this.M010201.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.M010201_ItemClick);
            // 
            // M010202
            // 
            this.M010202.Caption = "List of Student";
            this.M010202.Id = 2;
            this.M010202.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("M010202.ImageOptions.SvgImage")));
            this.M010202.Name = "M010202";
            this.M010202.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.M010202_ItemClick);
            // 
            // m010101
            // 
            this.m010101.Caption = "Log Out";
            this.m010101.Id = 3;
            this.m010101.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("m010101.ImageOptions.Image")));
            this.m010101.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("m010101.ImageOptions.LargeImage")));
            this.m010101.Name = "m010101";
            // 
            // M010102
            // 
            this.M010102.Caption = "Lock System";
            this.M010102.Id = 4;
            this.M010102.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("M010102.ImageOptions.Image")));
            this.M010102.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("M010102.ImageOptions.LargeImage")));
            this.M010102.Name = "M010102";
            // 
            // M010103
            // 
            this.M010103.Caption = "Exit";
            this.M010103.Id = 5;
            this.M010103.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("M010103.ImageOptions.Image")));
            this.M010103.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("M010103.ImageOptions.LargeImage")));
            this.M010103.Name = "M010103";
            this.M010103.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.M010103_ItemClick);
            // 
            // M010203
            // 
            this.M010203.Caption = "Print";
            this.M010203.Id = 6;
            this.M010203.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("M010203.ImageOptions.SvgImage")));
            this.M010203.Name = "M010203";
            this.M010203.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.M010203_ItemClick);
            // 
            // M010401
            // 
            this.M010401.Caption = "Add new Student";
            this.M010401.Id = 7;
            this.M010401.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("M010401.ImageOptions.SvgImage")));
            this.M010401.Name = "M010401";
            this.M010401.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.M010401_ItemClick);
            // 
            // M010402
            // 
            this.M010402.Caption = "Delele Student";
            this.M010402.Id = 8;
            this.M010402.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("M010402.ImageOptions.SvgImage")));
            this.M010402.Name = "M010402";
            // 
            // M010403
            // 
            this.M010403.Caption = "Edit ";
            this.M010403.Id = 9;
            this.M010403.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("M010403.ImageOptions.SvgImage")));
            this.M010403.Name = "M010403";
            this.M010403.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.M010403_ItemClick);
            // 
            // M010404
            // 
            this.M010404.Caption = "Find ";
            this.M010404.Id = 10;
            this.M010404.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("M010404.ImageOptions.SvgImage")));
            this.M010404.Name = "M010404";
            this.M010404.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.M010404_ItemClick);
            // 
            // M010501
            // 
            this.M010501.Caption = "Student";
            this.M010501.Id = 11;
            this.M010501.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("M010501.ImageOptions.SvgImage")));
            this.M010501.Name = "M010501";
            this.M010501.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.M010501_ItemClick);
            // 
            // M01050101
            // 
            this.M01050101.Caption = "skinRibbonGalleryBarItem1";
            this.M01050101.Id = 12;
            this.M01050101.Name = "M01050101";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 14;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // M01
            // 
            this.M01.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.M0101,
            this.M0102,
            this.M0103,
            this.m0105,
            this.M010601});
            this.M01.Name = "M01";
            this.M01.Text = "Student";
            // 
            // M0101
            // 
            this.M0101.ItemLinks.Add(this.m010101);
            this.M0101.ItemLinks.Add(this.M010102);
            this.M0101.ItemLinks.Add(this.M010103);
            this.M0101.Name = "M0101";
            this.M0101.Text = "Systems";
            // 
            // M0102
            // 
            this.M0102.ItemLinks.Add(this.M010201);
            this.M0102.ItemLinks.Add(this.M010202);
            this.M0102.ItemLinks.Add(this.M010203);
            this.M0102.Name = "M0102";
            this.M0102.Text = "General Manager";
            // 
            // M0103
            // 
            this.M0103.ItemLinks.Add(this.M010401);
            this.M0103.ItemLinks.Add(this.M010402);
            this.M0103.ItemLinks.Add(this.M010403);
            this.M0103.ItemLinks.Add(this.M010404);
            this.M0103.Name = "M0103";
            this.M0103.Text = "Function";
            // 
            // m0105
            // 
            this.m0105.ItemLinks.Add(this.M010501);
            this.m0105.Name = "m0105";
            this.m0105.Text = "Statics";
            // 
            // M010601
            // 
            this.M010601.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("M010601.ImageOptions.Image")));
            this.M010601.ItemLinks.Add(this.M01050101);
            this.M010601.Name = "M010601";
            this.M010601.Text = "Interface";
            // 
            // M02
            // 
            this.M02.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.M02.Name = "M02";
            this.M02.Text = "Course";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // M03
            // 
            this.M03.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.M03.Name = "M03";
            this.M03.Text = "Score";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 544);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(959, 31);
            // 
            // DataGrid_Student
            // 
            this.DataGrid_Student.DataSource = this.add_StudentBindingSource;
            this.DataGrid_Student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid_Student.Location = new System.Drawing.Point(0, 143);
            this.DataGrid_Student.MainView = this.gridView1;
            this.DataGrid_Student.MenuManager = this.ribbon;
            this.DataGrid_Student.Name = "DataGrid_Student";
            this.DataGrid_Student.Size = new System.Drawing.Size(959, 401);
            this.DataGrid_Student.TabIndex = 2;
            this.DataGrid_Student.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.DataGrid_Student.Click += new System.EventHandler(this.DataGrid_Student_Click);
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colfirstname,
            this.collastname,
            this.colbirthday,
            this.colgender,
            this.coladdress,
            this.colphone,
            this.colpicture});
            this.gridView1.GridControl = this.DataGrid_Student;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colfirstname
            // 
            this.colfirstname.FieldName = "firstname";
            this.colfirstname.Name = "colfirstname";
            this.colfirstname.Visible = true;
            this.colfirstname.VisibleIndex = 1;
            // 
            // collastname
            // 
            this.collastname.FieldName = "lastname";
            this.collastname.Name = "collastname";
            this.collastname.Visible = true;
            this.collastname.VisibleIndex = 2;
            // 
            // colbirthday
            // 
            this.colbirthday.FieldName = "birthday";
            this.colbirthday.Name = "colbirthday";
            this.colbirthday.Visible = true;
            this.colbirthday.VisibleIndex = 3;
            // 
            // colgender
            // 
            this.colgender.FieldName = "gender";
            this.colgender.Name = "colgender";
            this.colgender.Visible = true;
            this.colgender.VisibleIndex = 4;
            // 
            // coladdress
            // 
            this.coladdress.FieldName = "address";
            this.coladdress.Name = "coladdress";
            this.coladdress.Visible = true;
            this.coladdress.VisibleIndex = 5;
            // 
            // colphone
            // 
            this.colphone.FieldName = "phone";
            this.colphone.Name = "colphone";
            this.colphone.Visible = true;
            this.colphone.VisibleIndex = 6;
            // 
            // colpicture
            // 
            this.colpicture.FieldName = "picture";
            this.colpicture.Name = "colpicture";
            this.colpicture.Visible = true;
            this.colpicture.VisibleIndex = 7;
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
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Manager Course";
            this.barButtonItem2.Id = 16;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 17;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 18;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // Manager_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 575);
            this.Controls.Add(this.DataGrid_Student);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Manager_Student";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Manager Student ";
            this.Load += new System.EventHandler(this.Manager_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_StudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage M01;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup M0101;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem M010201;
        private DevExpress.XtraBars.BarButtonItem M010202;
        private DevExpress.XtraBars.BarButtonItem m010101;
        private DevExpress.XtraBars.BarButtonItem M010102;
        private DevExpress.XtraBars.BarButtonItem M010103;
        private DevExpress.XtraBars.BarButtonItem M010203;
        private DevExpress.XtraBars.BarButtonItem M010401;
        private DevExpress.XtraBars.BarButtonItem M010402;
        private DevExpress.XtraBars.BarButtonItem M010403;
        private DevExpress.XtraBars.BarButtonItem M010404;
        private DevExpress.XtraBars.BarButtonItem M010501;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem M01050101;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup M0102;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup M0103;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup m0105;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup M010601;
        private DevExpress.XtraBars.Ribbon.RibbonPage M02;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage M03;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Manager_StudentDataSet manager_StudentDataSet;
        private System.Windows.Forms.BindingSource add_StudentBindingSource;
        private Manager_StudentDataSetTableAdapters.Add_StudentTableAdapter add_StudentTableAdapter;
        private Manager_StudentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colfirstname;
        private DevExpress.XtraGrid.Columns.GridColumn collastname;
        private DevExpress.XtraGrid.Columns.GridColumn colbirthday;
        private DevExpress.XtraGrid.Columns.GridColumn colgender;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress;
        private DevExpress.XtraGrid.Columns.GridColumn colphone;
        private DevExpress.XtraGrid.Columns.GridColumn colpicture;
        public DevExpress.XtraGrid.GridControl DataGrid_Student;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
    }
}