using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AdmissionForm1
{
    public partial class MainPage : Form
    {
        string str = "Data Source=YOURSERVERNAME;Initial Catalog = ClassReg; Integrated Security = True";

        SqlConnection con;
        SqlCommand cmd;
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coursedetail cd = new coursedetail();
            cd.MdiParent = this;
            cd.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Courseupdate cu = new Courseupdate();
            cu.MdiParent = this;
            cu.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coursedelete cd1 = new coursedelete();
            cd1.MdiParent = this;
            cd1.Show();
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmissionForm af1 = new AdmissionForm();
            af1.MdiParent = this;
            af1.Show();
        }

        private void studentFeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentFeeDetails sfd = new StudentFeeDetails();
            sfd.MdiParent = this;
            sfd.Show();
        }

        private void viewStudentFeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewFeeData vfd = new ViewFeeData();
            vfd.MdiParent = this;
            vfd.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            menuStrip1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("addadmindetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("login successfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            menuStrip1.Visible = true;
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            courseview cv = new courseview();
            cv.MdiParent = this;
            cv.Show();
        }
    }
}
