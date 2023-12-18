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
using System.Data.Sql;

namespace AdmissionForm1
{
    public partial class Courseupdate : Form
    {
        string str = "Data Source=WALIDKADRI;Initial Catalog = iiht; Integrated Security = True";
        SqlConnection con;
        SqlCommand cmd;
        public Courseupdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("updatecoursedetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ecoursename", textBox1.Text);
                cmd.Parameters.AddWithValue("@id",comboBox1.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Course edit Successfully");
                
            }
            catch (Exception e1)
            {
                MessageBox.Show("" + e1);


            }
        }

        private void Courseupdate_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            cmd = new SqlCommand("viewcourseid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("searchcoursebyid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", comboBox1.SelectedItem.ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               textBox1.Text= dr[1].ToString();
            }
            dr.Close();

        }
    }
}
