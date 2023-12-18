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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace AdmissionForm1
{

    public partial class StudentFeeDetails : Form
    {
        string str = "Data Source=WALIDKADRI;Initial Catalog = iiht; Integrated Security = True";
        SqlConnection con;
        SqlCommand cmd;
        string action = null;
        

        public StudentFeeDetails()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                action = "new";
                panel1.Visible = true;
                panel2.Visible = false;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                cmd = new SqlCommand("select min(balance) from studentfeesdetails where studentname = @studentname", con);
                cmd.Parameters.AddWithValue("@studentname", textBox1.Text);
               SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    textBox7.Text = dr[0].ToString();
                }
                dr.Close();
               
                action = "old";           
                panel2.Visible = true;
                panel1.Visible = false;
            }

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentFeeDetails_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("addcourse", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@firstname", textBox1.Text);
            SqlDataReader sqr = cmd.ExecuteReader();
            if (sqr.Read())
            {
                textBox2.Text = sqr["coursename"].ToString();
                textBox3.Text = sqr["coursefee"].ToString();
            }
            else
            {
                textBox2.Text = "";
                textBox3.Text = "";
            }
            sqr.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (action == "new")
                {
                    cmd = new SqlCommand("insertfeedetails", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("studentname", textBox1.Text);
                    cmd.Parameters.AddWithValue("coursename", textBox2.Text);
                    cmd.Parameters.AddWithValue("totalfee", Convert.ToDouble(textBox3.Text));
                    cmd.Parameters.AddWithValue("action", action);
                    cmd.Parameters.AddWithValue("registrationfee", Convert.ToDouble(textBox4.Text));
                    cmd.Parameters.AddWithValue("dor", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("installment", "");
                    cmd.Parameters.AddWithValue("amount", 0);
                    cmd.Parameters.AddWithValue("dateamount", "");
                    cmd.Parameters.AddWithValue("status", richTextBox1.Text);
                    cmd.Parameters.AddWithValue("balance", Convert.ToDouble(textBox7.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successfully");
                }
                else
                {
                    cmd = new SqlCommand("insertfeedetails", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("studentname", textBox1.Text);
                    cmd.Parameters.AddWithValue("coursename", textBox2.Text);
                    cmd.Parameters.AddWithValue("totalfee", Convert.ToDouble(textBox3.Text));
                    cmd.Parameters.AddWithValue("action", action);
                    cmd.Parameters.AddWithValue("registrationfee", 0);
                    cmd.Parameters.AddWithValue("dor","");
                    cmd.Parameters.AddWithValue("installment", comboBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("amount", Convert.ToDouble(textBox5.Text));
                    cmd.Parameters.AddWithValue("dateamount", dateTimePicker2.Text);
                    cmd.Parameters.AddWithValue("status", richTextBox1.Text);
                    cmd.Parameters.AddWithValue("balance", Convert.ToDouble(textBox7.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successfully");
                }

            }

            catch (Exception e2)
            {
                MessageBox.Show("" + e2);

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if (radioButton1.Checked == true)
            {
                
                a = Convert.ToDouble(textBox3.Text);
                b = Convert.ToDouble(textBox4.Text);
                c = a - b;
                textBox7.Text = c.ToString();
            }
            else
            {
                a=Convert.ToDouble(textBox7.Text);
                b = Convert.ToDouble(textBox5.Text);
                c = a - b;
                textBox7.Text = c.ToString();
            }
            

        }
    }
}

