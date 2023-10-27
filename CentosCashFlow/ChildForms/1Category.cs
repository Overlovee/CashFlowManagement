using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace CentosCashFlow
{
    public partial class Category : Form
    {
        string connstring = "Data Source=THEVINH;Initial Catalog=DailyCashReceiptAndPaymentManagement_DB;Integrated Security=True";
        SqlConnection conn;
        public Category()
        {
            InitializeComponent();
            //try
            //{
            //    conn = new SqlConnection(connstring);
            //    conn.Open(); //open file
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Connection errors!");
            //    this.Close();
            //}
        }
        private void FormCategory_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    string query = "select * from Categories";
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    SqlDataReader rd = cmd.ExecuteReader();
            //    while (rd.Read())
            //    {
            //        ListViewItem item = new ListViewItem(rd["ID"].ToString());
            //        item.SubItems.Add(rd["Category_Name"].ToString());
            //        listView_category.Items.Add(item);
            //    }
            //    rd.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error Load!");
            //}
        }
        public void LoadDaTaToListView()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            listView_category.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select*From Categories", conn); //truy vấn
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string[] cd = { rd[0].ToString(), rd[1].ToString() };
                ListViewItem LV = new ListViewItem(cd);
                listView_category.Items.Add(LV);
            }
            rd.Close();
        }
        public void insertCategori(string Id, string category_name)
        {
            string sql_insert = "insert Categories values (@id, @category_name)";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql_insert;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@category_name", category_name);
            cmd.ExecuteNonQuery();
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            //if(conn.State == ConnectionState.Closed)
            //{               
            //    conn.Open();
            //}    
            //try 
            //{
            //    insertCategori(txt_Id.Text, txt_name.Text);
            //    MessageBox.Show("Insert success");
            //    LoadDaTaToListView();
            //} 
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Insert Failed");
            //}
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //if (conn.State == ConnectionState.Closed)
            //{
            //    conn.Open();
            //}
            //try
            //{
            //    updateCategori(txt_Id.Text, txt_name.Text);
            //    MessageBox.Show("Update success!");
            //    LoadDaTaToListView();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Update Failed!");
            //}
        }
        public void updateCategori(string Id, string category_name)
        {
            string sql_update = "update Categories set ID = @id, Category_Name = @category_name";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql_update;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@category_name", category_name);
            cmd.ExecuteNonQuery();
        }
        private void listView_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listView_category.SelectedItems) //Khi click vào cột ID sẽ sửa được data
                LoadCategori(i.SubItems[0].Text.ToString());
        }
        public void LoadCategori(string Id) //LoadCategori để update dữ liệu khi click vào ID
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from Categories where ID ='" + Id + "' ", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txt_Id.Text = rd[0].ToString();
                txt_Id.ReadOnly = true;
                txt_name.Text = rd[1].ToString();
            }
            else
                MessageBox.Show("No: " + Id);
            rd.Close();
        }
    }
}
