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

namespace CentosCashFlow
{
    public partial class Transaction : Form
    {
        string connstring = "Data Source=THEVINH;Initial Catalog=DailyCashReceiptAndPaymentManagement_DB;Integrated Security=True";
        SqlConnection conn;
        
        public Transaction()
        {
            InitializeComponent();
            //conn = new SqlConnection(connstring);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Transaction_Load(object sender, EventArgs e)
        {
            //try 
            //{
            //    conn.Open();
            //    string query = "select Category_Name from Categories";
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    SqlDataReader rd = cmd.ExecuteReader();
            //    while(rd.Read())
            //    {
            //        cmb_category.Items.Add(rd["Category_Name"].ToString());
            //    }
            //    rd.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error Load!");
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //string category = cmb_category.SelectedItem.ToString();
            //string Transaction_Type = "";
            //if (rb_Income.Checked)
            //    Transaction_Type = "Thu";
            //else
            //    Transaction_Type = "Chi";
            ////char[] Transaction_Type_Char = Transaction_Type.ToCharArray();

            //decimal Amount = Convert.ToDecimal(txt_amount.Text);
            //DateTime transactionDate = monthCalendar1.SelectionRange.Start;
            //string note = rtxt_note.Text;            
            //try
            //{
            //    conn.Open();

            //    // Lấy ID của loại giao dịch từ bảng Categories
            //    string categoryIdQuery = "SELECT ID FROM Categories WHERE Category_Name = @category";
            //    SqlCommand categoryIdCommand = new SqlCommand(categoryIdQuery, conn);
            //    categoryIdCommand.Parameters.AddWithValue("@category", category);
            //    string categoryId = categoryIdCommand.ExecuteScalar().ToString();
                    
            //    // Thêm giao dịch vào bảng Transactions
            //    string query = "INSERT INTO Transactions (Category_ID, Transaction_Type, Amount, Transaction_Date, Transaction_Description) VALUES (@Category_ID, @Transaction_Type, @Amount, @Transaction_Date, @Transaction_Description)";
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    cmd.Parameters.AddWithValue("@Category_ID", categoryId);
            //    cmd.Parameters.AddWithValue("@Transaction_Type", Transaction_Type);
            //    cmd.Parameters.AddWithValue("@Amount", Amount);
            //    cmd.Parameters.AddWithValue("@Transaction_Date", transactionDate);
            //    cmd.Parameters.AddWithValue("@Transaction_Description", note);
            //    cmd.ExecuteNonQuery(); //Error
            //    MessageBox.Show("Giao dịch đã được lưu.");
            //}
            //catch (Exception ex) 
            //{
            //    //==> có thể do thiếu thuộc tính ID và User_ID của table Transactions
            //    MessageBox.Show("Save failed");
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }
    }
}
