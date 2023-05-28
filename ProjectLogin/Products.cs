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
    public partial class Products : Form
    {
        SqlConnection conn = DbConnection.getConnection();
        MainPage prevForm;
        public Products(MainPage prevForm)
        {
            this.prevForm = prevForm;
            InitializeComponent();
            populateGrid();
        }

        private void populateGrid()
        {
            conn.Open();
            var query = "select id, name as Emri, price as Cmimi from [produkt]";
            var sda = new SqlDataAdapter(query, conn);
            var ds = new DataSet();
            sda.Fill(ds);
            DataGrid.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void goBack_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            var name = nameTB.Text;
            var priceStr = priceTB.Text;
            Double price;
            try
            {
                price = Convert.ToDouble(priceStr);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            var query = "insert into [produkt] (name, price) values (@name, @price)";
            var sqlCommand = new SqlCommand(query, conn);
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlCommand.Parameters.AddWithValue("@price", price);
            conn.Open();
            sqlCommand.ExecuteNonQuery();
            conn.Close();
            populateGrid();
        }
    }
}
