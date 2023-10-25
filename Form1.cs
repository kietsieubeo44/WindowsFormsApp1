using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=LAPTOP_KIET;Initial Catalog=MyDatabase;Integrated Security=True;";


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreat_Click(object sender, EventArgs e)
        {
            //string newName = txtCreat.Text;

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    string insertQuery = "INSERT INTO Table1 (Name) VALUES (@Name)";

            //    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
            //    {
            //        cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 255));
            //        cmd.Parameters["@Name"].Value = newName;

                    
            //    }
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idToDelete;
            if (int.TryParse(txtDelete.Text, out idToDelete))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Table1 WHERE ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int));
                        cmd.Parameters["@ID"].Value = idToDelete;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một ID hợp lệ để xóa.");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT ID, Name FROM Table1";

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            listBox1.Items.Add($"{id}: {name}");
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idToUpdate;
            if (int.TryParse(txtUpdate.Text, out idToUpdate))
            {
                string newName = txtCreat.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Table1 SET Name = @Name WHERE ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 255));
                        cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int));

                        cmd.Parameters["@Name"].Value = newName;
                        cmd.Parameters["@ID"].Value = idToUpdate;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một ID hợp lệ để cập nhật.");
            }
        }



        private void txtDelete_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUpdate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCreat_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
