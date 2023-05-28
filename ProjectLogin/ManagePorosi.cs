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

namespace ProjectLogin
{
    public partial class ManagePorosi : Form
    {
        SqlConnection conn = DbConnection.getConnection();
        public List<int> productIdsForInsertion = new List<int>();
        MainPage prevForm;

        public ManagePorosi(MainPage prevForm)
        {   
            this.prevForm = prevForm;
            InitializeComponent();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            populateGrid();
        }

        private void populateGrid()
        {
            conn.Open();
            var query = "select id, client_name as Client, date as Data from [porosi]";
            var sda = new SqlDataAdapter(query, conn);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGrid.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserData_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void insertBtnOnClick(object sender, EventArgs e)
        {
            var query = "insert into [porosi] (client_name, date) OUTPUT inserted.* values (@clientName, @dateTime)";
            int insertedId;
            try
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@clientName", clientName.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@dateTime", dateTimePicker.Value);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            insertedId = reader.GetInt32(reader.GetOrdinal("id"));
                        }
                        else
                        {
                            MessageBox.Show("Error inserting!");
                            conn.Close();
                            return;
                        }
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return;
            }

            if(productIdsForInsertion.Count > 0)
            {
                var insertPrd = "insert into [porosi_produkt] (porosi_id, produkt_id) values (@porosiId, @produktId)";
                try
                {
                    foreach (var productId in productIdsForInsertion)
                    {
                        using (SqlCommand sqlCommand = new SqlCommand(insertPrd, conn))
                        {
                            sqlCommand.Parameters.AddWithValue("@porosiId", insertedId);
                            sqlCommand.Parameters.AddWithValue("@produktId", productId);
                            sqlCommand.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            productIdsForInsertion.Clear();
            conn.Close();
            populateGrid();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void chooseProductsBtn_Click(object sender, EventArgs e)
        {
            var chooseForm = new ChooseProducts(new DataSet(), this);
            chooseForm.ShowDialog();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }
    }
}
