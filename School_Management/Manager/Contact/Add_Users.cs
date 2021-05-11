using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management.Manager.Contact
{
    public partial class Add_Contacts : DevExpress.XtraEditors.XtraForm
    {
        public Add_Contacts()
        {
            InitializeComponent();
        }

        private void Add_Contacts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Student.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.dataSet_Student.Contact);

        }
    }
}