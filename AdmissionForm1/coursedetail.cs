using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdmissionForm1
{
    public partial class coursedetail : Form
    {
        string str = "Data Source=YOURSERVERNAME;Initial Catalog = ClassReg; Integrated Security = True";
        SqlConnection con;
        SqlCommand cmd;
        public coursedetail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("insertcoursedetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@coursename", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Course Added Successfully");
                display();
            }
            catch(Exception e1)
            {
                MessageBox.Show("" + e1);


            }
        }

        private void coursedetail_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            display();

        }
        public void display()
        {
            SqlDataAdapter da = new SqlDataAdapter("viewcoursedetails", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
