
namespace School_Management.Manager.Contact
{
    partial class Add_Contacts
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dataSet_Student = new School_Management.DataSet_Student();
            this.dataSetStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForid = new DevExpress.XtraLayout.LayoutControlItem();
            this.firstnameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForfirstname = new DevExpress.XtraLayout.LayoutControlItem();
            this.lastnameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForlastname = new DevExpress.XtraLayout.LayoutControlItem();
            this.group_idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForgroup_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.phoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForphone = new DevExpress.XtraLayout.LayoutControlItem();
            this.addressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForaddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.picturePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.ItemForpicture = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactTableAdapter = new School_Management.DataSet_StudentTableAdapters.ContactTableAdapter();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfirstname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collastname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgroup_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpicture = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstnameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForfirstname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastnameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForlastname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForgroup_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForphone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForaddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.idTextEdit);
            this.dataLayoutControl1.Controls.Add(this.firstnameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.lastnameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.group_idTextEdit);
            this.dataLayoutControl1.Controls.Add(this.phoneTextEdit);
            this.dataLayoutControl1.Controls.Add(this.addressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.picturePictureEdit);
            this.dataLayoutControl1.DataSource = this.dataSetStudentBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(834, 270);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(834, 270);
            this.Root.TextVisible = false;
            // 
            // dataSet_Student
            // 
            this.dataSet_Student.DataSetName = "DataSet_Student";
            this.dataSet_Student.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetStudentBindingSource
            // 
            this.dataSetStudentBindingSource.DataSource = this.dataSet_Student;
            this.dataSetStudentBindingSource.Position = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForid,
            this.ItemForfirstname,
            this.ItemForlastname,
            this.ItemForgroup_id,
            this.ItemForphone,
            this.ItemForaddress,
            this.ItemForpicture});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(814, 250);
            // 
            // idTextEdit
            // 
            this.idTextEdit.Location = new System.Drawing.Point(61, 12);
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.idTextEdit.Properties.Mask.EditMask = "N0";
            this.idTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.idTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.idTextEdit.Size = new System.Drawing.Size(761, 20);
            this.idTextEdit.StyleController = this.dataLayoutControl1;
            this.idTextEdit.TabIndex = 4;
            // 
            // ItemForid
            // 
            this.ItemForid.Control = this.idTextEdit;
            this.ItemForid.Location = new System.Drawing.Point(0, 0);
            this.ItemForid.Name = "ItemForid";
            this.ItemForid.Size = new System.Drawing.Size(814, 24);
            this.ItemForid.Text = "id";
            this.ItemForid.TextSize = new System.Drawing.Size(45, 13);
            // 
            // firstnameTextEdit
            // 
            this.firstnameTextEdit.Location = new System.Drawing.Point(61, 36);
            this.firstnameTextEdit.Name = "firstnameTextEdit";
            this.firstnameTextEdit.Size = new System.Drawing.Size(761, 20);
            this.firstnameTextEdit.StyleController = this.dataLayoutControl1;
            this.firstnameTextEdit.TabIndex = 5;
            // 
            // ItemForfirstname
            // 
            this.ItemForfirstname.Control = this.firstnameTextEdit;
            this.ItemForfirstname.Location = new System.Drawing.Point(0, 24);
            this.ItemForfirstname.Name = "ItemForfirstname";
            this.ItemForfirstname.Size = new System.Drawing.Size(814, 24);
            this.ItemForfirstname.Text = "firstname";
            this.ItemForfirstname.TextSize = new System.Drawing.Size(45, 13);
            // 
            // lastnameTextEdit
            // 
            this.lastnameTextEdit.Location = new System.Drawing.Point(61, 60);
            this.lastnameTextEdit.Name = "lastnameTextEdit";
            this.lastnameTextEdit.Size = new System.Drawing.Size(761, 20);
            this.lastnameTextEdit.StyleController = this.dataLayoutControl1;
            this.lastnameTextEdit.TabIndex = 6;
            // 
            // ItemForlastname
            // 
            this.ItemForlastname.Control = this.lastnameTextEdit;
            this.ItemForlastname.Location = new System.Drawing.Point(0, 48);
            this.ItemForlastname.Name = "ItemForlastname";
            this.ItemForlastname.Size = new System.Drawing.Size(814, 24);
            this.ItemForlastname.Text = "lastname";
            this.ItemForlastname.TextSize = new System.Drawing.Size(45, 13);
            // 
            // group_idTextEdit
            // 
            this.group_idTextEdit.Location = new System.Drawing.Point(61, 84);
            this.group_idTextEdit.Name = "group_idTextEdit";
            this.group_idTextEdit.Size = new System.Drawing.Size(761, 20);
            this.group_idTextEdit.StyleController = this.dataLayoutControl1;
            this.group_idTextEdit.TabIndex = 7;
            // 
            // ItemForgroup_id
            // 
            this.ItemForgroup_id.Control = this.group_idTextEdit;
            this.ItemForgroup_id.Location = new System.Drawing.Point(0, 72);
            this.ItemForgroup_id.Name = "ItemForgroup_id";
            this.ItemForgroup_id.Size = new System.Drawing.Size(814, 24);
            this.ItemForgroup_id.Text = "group_id";
            this.ItemForgroup_id.TextSize = new System.Drawing.Size(45, 13);
            // 
            // phoneTextEdit
            // 
            this.phoneTextEdit.Location = new System.Drawing.Point(61, 108);
            this.phoneTextEdit.Name = "phoneTextEdit";
            this.phoneTextEdit.Size = new System.Drawing.Size(761, 20);
            this.phoneTextEdit.StyleController = this.dataLayoutControl1;
            this.phoneTextEdit.TabIndex = 8;
            // 
            // ItemForphone
            // 
            this.ItemForphone.Control = this.phoneTextEdit;
            this.ItemForphone.Location = new System.Drawing.Point(0, 96);
            this.ItemForphone.Name = "ItemForphone";
            this.ItemForphone.Size = new System.Drawing.Size(814, 24);
            this.ItemForphone.Text = "phone";
            this.ItemForphone.TextSize = new System.Drawing.Size(45, 13);
            // 
            // addressTextEdit
            // 
            this.addressTextEdit.Location = new System.Drawing.Point(61, 132);
            this.addressTextEdit.Name = "addressTextEdit";
            this.addressTextEdit.Size = new System.Drawing.Size(761, 20);
            this.addressTextEdit.StyleController = this.dataLayoutControl1;
            this.addressTextEdit.TabIndex = 9;
            // 
            // ItemForaddress
            // 
            this.ItemForaddress.Control = this.addressTextEdit;
            this.ItemForaddress.Location = new System.Drawing.Point(0, 120);
            this.ItemForaddress.Name = "ItemForaddress";
            this.ItemForaddress.Size = new System.Drawing.Size(814, 24);
            this.ItemForaddress.Text = "address";
            this.ItemForaddress.TextSize = new System.Drawing.Size(45, 13);
            // 
            // picturePictureEdit
            // 
            this.picturePictureEdit.Location = new System.Drawing.Point(61, 156);
            this.picturePictureEdit.Name = "picturePictureEdit";
            this.picturePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picturePictureEdit.Size = new System.Drawing.Size(761, 102);
            this.picturePictureEdit.StyleController = this.dataLayoutControl1;
            this.picturePictureEdit.TabIndex = 10;
            // 
            // ItemForpicture
            // 
            this.ItemForpicture.Control = this.picturePictureEdit;
            this.ItemForpicture.Location = new System.Drawing.Point(0, 144);
            this.ItemForpicture.Name = "ItemForpicture";
            this.ItemForpicture.Size = new System.Drawing.Size(814, 106);
            this.ItemForpicture.StartNewLine = true;
            this.ItemForpicture.Text = "picture";
            this.ItemForpicture.TextSize = new System.Drawing.Size(45, 13);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.contactBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 270);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(834, 233);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colfirstname,
            this.collastname,
            this.colgroup_id,
            this.colphone,
            this.coladdress,
            this.colpicture});
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataMember = "Contact";
            this.contactBindingSource.DataSource = this.dataSetStudentBindingSource;
            // 
            // contactTableAdapter
            // 
            this.contactTableAdapter.ClearBeforeFill = true;
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
            // colgroup_id
            // 
            this.colgroup_id.FieldName = "group_id";
            this.colgroup_id.Name = "colgroup_id";
            this.colgroup_id.Visible = true;
            this.colgroup_id.VisibleIndex = 3;
            // 
            // colphone
            // 
            this.colphone.FieldName = "phone";
            this.colphone.Name = "colphone";
            this.colphone.Visible = true;
            this.colphone.VisibleIndex = 4;
            // 
            // coladdress
            // 
            this.coladdress.FieldName = "address";
            this.coladdress.Name = "coladdress";
            this.coladdress.Visible = true;
            this.coladdress.VisibleIndex = 5;
            // 
            // colpicture
            // 
            this.colpicture.FieldName = "picture";
            this.colpicture.Name = "colpicture";
            this.colpicture.Visible = true;
            this.colpicture.VisibleIndex = 6;
            // 
            // Add_Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 503);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "Add_Contacts";
            this.Text = "Add New Contact";
            this.Load += new System.EventHandler(this.Add_Contacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstnameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForfirstname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastnameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForlastname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForgroup_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForphone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForaddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.BindingSource dataSetStudentBindingSource;
        private DataSet_Student dataSet_Student;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit idTextEdit;
        private DevExpress.XtraEditors.TextEdit firstnameTextEdit;
        private DevExpress.XtraEditors.TextEdit lastnameTextEdit;
        private DevExpress.XtraEditors.TextEdit group_idTextEdit;
        private DevExpress.XtraEditors.TextEdit phoneTextEdit;
        private DevExpress.XtraEditors.TextEdit addressTextEdit;
        private DevExpress.XtraEditors.PictureEdit picturePictureEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForid;
        private DevExpress.XtraLayout.LayoutControlItem ItemForfirstname;
        private DevExpress.XtraLayout.LayoutControlItem ItemForlastname;
        private DevExpress.XtraLayout.LayoutControlItem ItemForgroup_id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForphone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForaddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForpicture;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private DataSet_StudentTableAdapters.ContactTableAdapter contactTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colfirstname;
        private DevExpress.XtraGrid.Columns.GridColumn collastname;
        private DevExpress.XtraGrid.Columns.GridColumn colgroup_id;
        private DevExpress.XtraGrid.Columns.GridColumn colphone;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress;
        private DevExpress.XtraGrid.Columns.GridColumn colpicture;
    }
}