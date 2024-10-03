using DAL;
using DTO;
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

namespace GUI
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void saveProdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string productID = prodIDTxtBx.Text;
                string productName = prodNameTxtBx.Text;
                int quantity = int.Parse(QttTxtBx.Text);
                float unitPrice = float.Parse(unitPriceTxtBx.Text);
                string origin = originTxtBx.Text;
                DateTime expiryDate = expDDatePicker.Value;

                SqlConnectionData sqlConnData = new SqlConnectionData();
                using (SqlConnection conn = sqlConnData.Connect())
                {
                    conn.Open();

                    string query = "INSERT INTO Products (ProductID, ProductName, Quantity, UnitPrice, Origin, ExpiryDate) " +
                                   "VALUES (@ProductID, @ProductName, @Quantity, @UnitPrice, @Origin, @ExpiryDate)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        cmd.Parameters.AddWithValue("@Origin", origin);
                        cmd.Parameters.AddWithValue("@ExpiryDate", expiryDate);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sản phẩm đã được lưu thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi lưu sản phẩm.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}
