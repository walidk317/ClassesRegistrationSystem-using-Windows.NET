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
using System.Windows.Forms.Design; 

namespace AdmissionForm1
{
    public partial class FeesDetails : Form
    {
        string str = "Data Source=WALIDKADRI;Initial Catalog = iiht; Integrated Security = True";
        SqlConnection con;
        SqlCommand cmd;
        public FeesDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                cmd = new SqlCommand("insertfeesdetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("cid", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("fees", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("fees added succesfully");
                addcourseid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void FeesDetails_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            addcourseid();
        }
        private void addcourseid()
        {
            SqlCommand cmd = new SqlCommand("SELECT cid from coursetbl", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                comboBox1.Items.Add(reader["cid"].ToString());
            }
            reader.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT coursename from coursetbl", con);
            cmd.Parameters.AddWithValue("cid",comboBox1.SelectedItem.ToString());
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                textBox1.Text = r[0].ToString();
            }
            r.Close();
        }
    }
}
