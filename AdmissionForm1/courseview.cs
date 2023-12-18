using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissionForm1
{
    public partial class courseview : Form
    {
        public courseview()
        {
            InitializeComponent();
        }

        private void courseview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iihtDataSet3.coursetbl' table. You can move, or remove it, as needed.
            this.coursetblTableAdapter.Fill(this.iihtDataSet3.coursetbl);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
