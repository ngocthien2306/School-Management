using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management.Manager.Student
{
    public partial class List : DevExpress.XtraEditors.XtraForm
    {
        public List()
        {
            InitializeComponent();
        }

        private void add_StudentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.add_StudentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.manager_StudentDataSet);

        }

        private void List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_StudentDataSet.Add_Student' table. You can move, or remove it, as needed.
            this.add_StudentTableAdapter.Fill(this.manager_StudentDataSet.Add_Student);

        }

        private void courseBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}