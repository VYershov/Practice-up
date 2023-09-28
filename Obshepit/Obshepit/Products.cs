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

namespace Obshepit
{
    public partial class Products : Form
    {
           // private static string connectString = "Data Source = ADCLG1;Initial Catalog = Yershov4196_Pr2;" + "Integrated Security = true;";
            private static string connectString = $@"Data Source = MY-PC\MSSQLSERVER1; Initial Catalog = Obshepit;" + "Integrated Security = true;";
            string sql = "Select * from Products";

            public Products()
            {
                InitializeComponent();
            }

            private void Products_Load(object sender, EventArgs e)
            {
                using (SqlConnection myConnection = new SqlConnection(connectString))
                {
                    myConnection.Open();
                    SqlCommand cmd = myConnection.CreateCommand();
                    cmd.CommandText = sql;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet data = new DataSet();
                    dataAdapter.Fill(data);
                    dataGridView1.DataSource = data.Tables[0];
                    myConnection.Close();
                }
            }

            private void ex_Click(object sender, EventArgs e)
            {
                Close();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                using (SqlConnection myConnection = new SqlConnection(connectString))
                {
                    myConnection.Open();
                    SqlCommand dob = new SqlCommand($"UPDATE Products SET name_product = '{textBox2.Text}', caloric_content = {int.Parse(textBox3.Text)}, weight =  {int.Parse(textBox4.Text)}, price_per_kg = {int.Parse(textBox5.Text)} WHERE id= {int.Parse(textBox1.Text)}");
                    dob.Connection = myConnection;
                    dob.ExecuteNonQuery();
                    myConnection.Close();
                }
                Products_Load(sender, e);
            }

        private void button3_Click(object sender, EventArgs e)
            {
                using (SqlConnection myConnection = new SqlConnection(connectString))
                {
                    myConnection.Open();
                    SqlCommand dob = new SqlCommand($"INSERT INTO Products values( '{textBox2.Text}', '{textBox3.Text}', {int.Parse(textBox4.Text)}, {int.Parse(textBox5.Text)})");
                    dob.Connection = myConnection;
                    dob.ExecuteNonQuery();
                    myConnection.Close();
                }
                Products_Load(sender, e);
            }

            private void button4_Click(object sender, EventArgs e)
            {
                string message = "Вы действительно хотите удалить выбранную запись?";

                if (MessageBox.Show(message, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                using (SqlConnection myConnection = new SqlConnection(connectString))
                {
                    myConnection.Open();
                    string cmd = "DELETE FROM Products WHERE id = @code";
                    SqlCommand cmd1 = new SqlCommand(cmd, myConnection);
                    SqlParameter pr1 = new SqlParameter("@code", textBox1.Text);
                    cmd1.Parameters.Add(pr1);
                    cmd1.ExecuteNonQuery();
                    myConnection.Close();
                }
                Products_Load(sender, e);
            }
    }
}

