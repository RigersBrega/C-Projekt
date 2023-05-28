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
    public partial class ChooseProducts : Form
    {
        SqlConnection conn = DbConnection.getConnection();
        DataSet originalExistingProd = new DataSet();
        DataSet existingProd = new DataSet();
        DataTable products = new DataTable();
        ManagePorosi prevForm;

        public ChooseProducts(DataSet existingProd, ManagePorosi prevForm)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.existingProd = existingProd.Copy();
            this.originalExistingProd = existingProd;
            products = getProducts().Tables[0];
            try
            {
                toInsertDG.DataSource = products;
            } catch (Exception ignored) { }
        }

        private DataSet getProducts()
        {
            conn.Open();
            DataSet ds = new DataSet();
            String command = "Select * from [produkt]";
            using (SqlCommand sqlCommand = new SqlCommand(command, conn))
            {
                //get products without the ones the `porosi` already has
                //sqlCommand.Parameters.AddWithValue("@idList", getIdsFromDataset(existingProd));
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                    dataAdapter.Fill(ds);
            }
            conn.Close();
            return ds;
        }

        private List<int> getIdsFromDataset(DataSet ds)
        {
            List<int> idList = new List<int>();

            if (ds.Tables.Count > 0)
            {
                DataTable dataTable = ds.Tables[0];

                foreach (DataRow row in dataTable.Rows)
                {
                    int id = Convert.ToInt32(row["id"]);
                    idList.Add(id);
                }
            }
            return idList;
        }

        private List<int> getIdsFromDataGrid(DataGridView dg)
        {
            List<int> columnData = new List<int>();

            int columnIndex = 0; // Specify the index of the desired column

            foreach (DataGridViewRow row in dg.Rows)
            {
                if (row.Cells[columnIndex].Value is int cellValue)
                {
                    columnData.Add(cellValue);
                }
            }
            return columnData;
        }

        private void toInsertDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            // Get the selected rows from the source DataGridView
            DataGridViewSelectedRowCollection selectedRows = toInsertDG.SelectedRows;

            // Move the selected rows to the destination DataGridView
            foreach (DataGridViewRow row in selectedRows)
            {
                // Add the selected row to the destination DataGridView
                try
                {
                    insertedDG.Rows.Add(row.Cells.Cast<DataGridViewCell>().Select(c => c.Value).ToArray());
                }catch (Exception ex)
                {
                    addColumnsToDG();
                    insertedDG.Rows.Add(row.Cells.Cast<DataGridViewCell>().Select(c => c.Value).ToArray());
                }

                // Remove the selected row from the source DataGridView
                try
                {
                    toInsertDG.Rows.Remove(row);
                }catch (Exception ingored) {}
                
            }
        }

        private void addColumnsToDG()
        {
            
                // Clear existing columns in the destination DataGridView
                insertedDG.Columns.Clear();

                // Copy columns from the source DataGridView to the destination DataGridView
                foreach (DataGridViewColumn column in toInsertDG.Columns)
                {
                    // Clone the column to avoid sharing the same instance
                    DataGridViewColumn newColumn = (DataGridViewColumn)column.Clone();

                    // Add the cloned column to the destination DataGridView
                    insertedDG.Columns.Add(newColumn);
                }
           
        }

        private void remove_Click(object sender, EventArgs e)
        {
            // Get the selected rows from the source DataGridView
            DataGridViewSelectedRowCollection selectedRows = insertedDG.SelectedRows;

            // Move the selected rows to the destination DataGridView
            foreach (DataGridViewRow row in selectedRows)
            {
                // Add the selected row to the destination DataGridView
                try
                {
                    products.Rows.Add(((DataRowView)row.DataBoundItem));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // Remove the selected row from the source DataGridView
                try
                {
                    insertedDG.Rows.Remove(row);
                }
                catch (Exception ingored) { }

            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void insertProductsBtn_Click(object sender, EventArgs e)
        {
            List<int> oldIds = getIdsFromDataset(originalExistingProd);
            List<int> newIds = getIdsFromDataGrid(insertedDG);
            List<int> differenceOfIds = newIds.Where(x => !oldIds.Contains(x)).ToList();
            prevForm.productIdsForInsertion = differenceOfIds;
            prevForm.Show();
            this.Close();
        }
    }
}
