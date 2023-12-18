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
    public partial class AdmissionForm : Form
        
    {
        string str = "Data Source=WALIDKADRI;Initial Catalog = iiht; Integrated Security = True";
        SqlConnection con;
        SqlCommand cmd;
        public AdmissionForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iihtDataSet1.admissiontbl' table. You can move, or remove it, as needed.
            this.admissiontblTableAdapter.Fill(this.iihtDataSet1.admissiontbl);
            // TODO: This line of code loads data into the 'iihtDataSet.coursetbl' table. You can move, or remove it, as needed.
            this.coursetblTableAdapter.Fill(this.iihtDataSet.coursetbl);
            con = new SqlConnection(str);
            con.Open();
            populateComboBox();
            
        }
        private void populateComboBox()
        {
            

            SqlCommand cmd = new SqlCommand("SELECT coursename FROM coursetbl", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["coursename"].ToString());
            }

            reader.Close();
        }

            private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("insertstudentdetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@firstname", textBox1.Text);
                cmd.Parameters.AddWithValue("@lastname", textBox2.Text);
                cmd.Parameters.AddWithValue("@dateofbirth", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@gender", textBox4.Text);
                cmd.Parameters.AddWithValue("@email", textBox5.Text);
                cmd.Parameters.AddWithValue("@phonenumber", textBox6.Text);
                cmd.Parameters.AddWithValue("@addrss", textBox7.Text);
               
                string selectedCourse = comboBox1.SelectedItem.ToString();
                cmd.Parameters.AddWithValue("@coursename", selectedCourse);

                cmd.Parameters.AddWithValue("@courseduration", textBox8.Text);
                cmd.Parameters.AddWithValue("@coursefee", Convert.ToInt32(textBox9.Text));
                cmd.Parameters.AddWithValue("@admissiondate", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@docname", textBox11.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Added Successfully");
                populateComboBox();
                display();
            }
            catch(Exception e1)
            {
                MessageBox.Show("" + e1);
            }
            dataGridView1.Visible = true;

        }
        public void display()
        {
            SqlDataAdapter da = new SqlDataAdapter("viewstudentdetails", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("updatestudentdetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@firstname", textBox1.Text);
                cmd.Parameters.AddWithValue("@lastname", textBox2.Text);
                cmd.Parameters.AddWithValue("@dateofbirth", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@gender", textBox4.Text);
                cmd.Parameters.AddWithValue("@email", textBox5.Text);
                cmd.Parameters.AddWithValue("@phonenumber", textBox6.Text);
                cmd.Parameters.AddWithValue("@addrss", textBox7.Text);
                // cmd.Parameters.AddWithValue("coursename", comboBox1.SelectedItem.ToString());
                string selectedCourse = comboBox1.SelectedItem.ToString();
                cmd.Parameters.AddWithValue("@coursename", selectedCourse);

                cmd.Parameters.AddWithValue("@courseduration", textBox8.Text);
                cmd.Parameters.AddWithValue("@coursefee", Convert.ToInt32(textBox9.Text));
                cmd.Parameters.AddWithValue("@admissiondate", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@docname", textBox11.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details updated Successfully");
                
            }
            catch (Exception e1)
            {
                MessageBox.Show("" + e1);
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("deletestudentdetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phonenumber", textBox6.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("data deleted successfully");
            }
            catch (Exception e1)
            {
                MessageBox.Show("" + e1);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            comboBox1.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
            textBox11.Text = string.Empty;

        }
    }
}
