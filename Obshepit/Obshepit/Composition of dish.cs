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
    public partial class Composition_of_dish : Form
    {
        
        //private static string connectString = "Data Source = ADCLG1;Initial Catalog = Yershov4196_Pr2;" + "Integrated Security = true;";
        private static string connectString = $@"Data Source = MY-PC\MSSQLSERVER1; Initial Catalog = Obshepit;" + "Integrated Security = true;";
        string sql = "Select * from Composition_of_dish";

        public Composition_of_dish()
        {
            InitializeComponent();
        }

        private void CompositionODish(object sender, EventArgs e)
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
                SqlCommand dob = new SqlCommand($"UPDATE Composition_of_dish SET id_product = '{int.Parse(textBox2.Text)}' WHERE id_recipe= {int.Parse(textBox1.Text)}");
                dob.Connection = myConnection;
                dob.ExecuteNonQuery();
                myConnection.Close();
            }
            CompositionODish(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection myConnection = new SqlConnection(connectString))
            {
                myConnection.Open();
                SqlCommand dob = new SqlCommand($"INSERT INTO Composition_of_dish values( {int.Parse(textBox2.Text)})");
                dob.Connection = myConnection;
                dob.ExecuteNonQuery();
                myConnection.Close();
            }
            CompositionODish(sender, e);
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
                string cmd = "DELETE FROM Composition_of_dish WHERE id = @code";
                SqlCommand cmd1 = new SqlCommand(cmd, myConnection);
                SqlParameter pr1 = new SqlParameter("@code", textBox1.Text);
                cmd1.Parameters.Add(pr1);
                cmd1.ExecuteNonQuery();
                myConnection.Close();
            }
            CompositionODish(sender, e);
        }
    }
}
