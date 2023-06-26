using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StockManagment
{
    public partial class Stocks : Form
    {
        public Stocks()
        {
            InitializeComponent();
            ShowProduct();
        }

        private void ShowProduct()
        {
            Con.Open();
            string Query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-UOSFM8O\WERTY;Initial Catalog=StockManagment;User ID=sa;Password=93658086");

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {   }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (PrNameTb.Text == "" || QtyTb.Text == "" || SpriceTb.Text == "" || BpriceTb.Text == "" || SupCb.SelectedIndex == -1 || CatCb.SelectedIndex == -1)
            {
                bunifuSnackbar1.Show(this, "Mising Datta");
            }
            else 
            {
                int Gain = Convert.ToInt32(SpriceTb.Text) - Convert.ToInt32(BpriceTb.Text);
                try
                { 
                 Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ProductTbl (ProductoName, ProductoCategoria, ProductoCantidad, ProductoPrecio, ProductoCompra, ProductoDia, Supplier, Gain) VALUES (@PN, @PCat, @Pqty, @BPr, @SPr, @PDate, @Sup, @G)", Con);

                    cmd.Parameters.AddWithValue("@PN", PrNameTb.Text);
                    cmd.Parameters.AddWithValue("@PCat", CatCb.SelectedIndex.ToString());
                    cmd.Parameters.AddWithValue("@Pqty", QtyTb.Text);
                    cmd.Parameters.AddWithValue("@BPr", BpriceTb.Text);
                    cmd.Parameters.AddWithValue("@SPr", SpriceTb.Text);
                    cmd.Parameters.AddWithValue("@PDate", PrDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Sup", SupCb.SelectedIndex);
                    cmd.Parameters.AddWithValue("@G", Gain);
                    cmd.ExecuteNonQuery();
                    bunifuSnackbar1.Show(this, "Product Salvado");

                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;

        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrNameTb.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatCb.Text = ProductDGV.SelectedRows[0].Cells[2].Value.ToString();
            QtyTb.Text = ProductDGV.SelectedRows[0].Cells[3].Value.ToString();
            BpriceTb.Text = ProductDGV.SelectedRows[0].Cells[4].Value.ToString();
            SpriceTb.Text = ProductDGV.SelectedRows[0].Cells[5].Value.ToString();
            PrDate.Text = ProductDGV.SelectedRows[0].Cells[6].Value.ToString();
            SupCb.Text = ProductDGV.SelectedRows[0].Cells[7].Value.ToString();

            if (PrNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (PrNameTb.Text == "" || QtyTb.Text == "" || SpriceTb.Text == "" || BpriceTb.Text == "" || SupCb.SelectedIndex == -1 || CatCb.SelectedIndex == -1)
            {
                bunifuSnackbar1.Show(this, "Missing Data");
            }
            else
            {
                int Gain = Convert.ToInt32(SpriceTb.Text) - Convert.ToInt32(BpriceTb.Text);
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ProductTbl SET ProductoName=@PN, ProductoCategoria=@PCat, ProductoCantidad=@Pqty, ProductoPrecio=@BPr, ProductoCompra=@SPr, ProductoDia=@PDate, Supplier=@Sup, Gain=@G WHERE PrCode=@PrKey", Con);
                    cmd.Parameters.AddWithValue("@PN", PrNameTb.Text);
                    cmd.Parameters.AddWithValue("@PCat", CatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Pqty", QtyTb.Text);
                    cmd.Parameters.AddWithValue("@BPr", BpriceTb.Text);
                    cmd.Parameters.AddWithValue("@SPr", SpriceTb.Text);
                    cmd.Parameters.AddWithValue("@PDate", PrDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Sup", SupCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@G", Gain);
                    cmd.Parameters.AddWithValue("@PrKey", Key);
                    cmd.ExecuteNonQuery();
                    bunifuSnackbar1.Show(this, "Product Edited");

                    Con.Close();
                    ShowProduct();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeletBtn_Click(object sender, EventArgs e)
        {
            {
                if (Key != null)
                {
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM ProductTbl WHERE PrCode = @PrKey", Con);
                        cmd.Parameters.AddWithValue("@PrKey", Key);
                        cmd.ExecuteNonQuery();
                        bunifuSnackbar1.Show(this, "Product Deleted");

                        Con.Close();
                        ShowProduct();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }
        }
    }
}
