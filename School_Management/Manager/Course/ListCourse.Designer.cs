
namespace School_Management.Manager.Course
{
    partial class ListCourse
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
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new School_Management.Manager_StudentDataSetTableAdapters.CourseTableAdapter();
            this.tableAdapterManager = new School_Management.Manager_StudentDataSetTableAdapters.TableAdapterManager();
            this.CourseGridControl = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // manager_StudentDataSet
            // 
            this.manager_StudentDataSet.DataSetName = "Manager_StudentDataSet";
            this.manager_StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.manager_StudentDataSet;
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
            // CourseGridControl
            // 
            this.CourseGridControl.DataSource = this.courseBindingSource;
            this.CourseGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseGridControl.Location = new System.Drawing.Point(0, 0);
            this.CourseGridControl.MainView = this.cardView1;
            this.CourseGridControl.Name = "CourseGridControl";
            this.CourseGridControl.Size = new System.Drawing.Size(656, 381);
            this.CourseGridControl.TabIndex = 0;
            this.CourseGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.GridControl = this.CourseGridControl;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // ListCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 381);
            this.Controls.Add(this.CourseGridControl);
            this.Name = "ListCourse";
            this.Text = "List Course";
            this.Load += new System.EventHandler(this.ListCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Manager_StudentDataSet manager_StudentDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private Manager_StudentDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private Manager_StudentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl CourseGridControl;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
    }
}