
namespace School_Management.Manager.Student
{
    partial class List
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
            this.manager_StudentDataSet = new School_Management.Manager_StudentDataSet();
            this.add_StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_StudentTableAdapter = new School_Management.Manager_StudentDataSetTableAdapters.Add_StudentTableAdapter();
            this.tableAdapterManager = new School_Management.Manager_StudentDataSetTableAdapters.TableAdapterManager();
            this.StudentGridControl = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_StudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // manager_StudentDataSet
            // 
            this.manager_StudentDataSet.DataSetName = "Manager_StudentDataSet";
            this.manager_StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // add_StudentBindingSource
            // 
            this.add_StudentBindingSource.DataMember = "Add_Student";
            this.add_StudentBindingSource.DataSource = this.manager_StudentDataSet;
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
            // StudentGridControl
            // 
            this.StudentGridControl.DataSource = this.add_StudentBindingSource;
            this.StudentGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentGridControl.Location = new System.Drawing.Point(0, 0);
            this.StudentGridControl.MainView = this.cardView1;
            this.StudentGridControl.Name = "StudentGridControl";
            this.StudentGridControl.Size = new System.Drawing.Size(851, 522);
            this.StudentGridControl.TabIndex = 0;
            this.StudentGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.GridControl = this.StudentGridControl;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 522);
            this.Controls.Add(this.StudentGridControl);
            this.Name = "List";
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_StudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Manager_StudentDataSet manager_StudentDataSet;
        private System.Windows.Forms.BindingSource add_StudentBindingSource;
        private Manager_StudentDataSetTableAdapters.Add_StudentTableAdapter add_StudentTableAdapter;
        private Manager_StudentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl StudentGridControl;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
    }
}