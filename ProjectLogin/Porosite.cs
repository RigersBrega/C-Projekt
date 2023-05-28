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
    public partial class Porosite : Form
    {
        private SqlConnection conn = DbConnection.getConnection();
        private MainPage prevForm;

        public Porosite(MainPage prevForm)
        {
            this.prevForm = prevForm;
            InitializeComponent();
            populatePorosi();
        }

        private void populatePorosi()
        {
            conn.Open();
            var query = "select id, client_name as Client, date as Data from [porosi]";
            var sda = new SqlDataAdapter(query, conn);
            var ds = new DataSet();
            sda.Fill(ds);
            porositeDG.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void porositeDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the id from the clicked row
                int id = Convert.ToInt32(porositeDG.Rows[e.RowIndex].Cells[0].Value);
                showProductsByPorosiId(id);
            }
        }

        private void showProductsByPorosiId(int id)
        {
            conn.Open();
            var query = "select p.Id as Id, p.name as Emri, p.price as Cmimi from [porosi_produkt] as pp" +
                " join [produkt] as p on pp.produkt_id = p.Id" +
                " where porosi_id = @porosiId";
            var sqlCommand = new SqlCommand(query, conn);
            sqlCommand.Parameters.AddWithValue("@porosiId", id);
            var sda = new SqlDataAdapter(sqlCommand);
            var ds = new DataSet();
            sda.Fill(ds);
            productsDG.DataSource = ds.Tables[0];

            //get Sum and display it
            DataTable table = ds.Tables[0]; // Get the DataTable from the DataSet
            double sum = 0;

            foreach (DataRow row in table.Rows)
            {
                double value = Convert.ToDouble(row["Cmimi"]); // Convert the value to int
                sum += value;
            }
            totalField.Text = sum.ToString();
            conn.Close();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void productsDG_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void Porosite_Load(object sender, EventArgs e)
        {

        }
    }
}
