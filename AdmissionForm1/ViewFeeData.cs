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
    public partial class ViewFeeData : Form
    {
        public ViewFeeData()
        {
            InitializeComponent();
        }

        private void ViewFeeData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iihtDataSet2.studentfeesdetails' table. You can move, or remove it, as needed.
            this.studentfeesdetailsTableAdapter.Fill(this.iihtDataSet2.studentfeesdetails);

        }
    }
}
