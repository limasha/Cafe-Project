using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CafeProject.Models
{
    public class OrderDbHandler
    {
        private SqlConnection con;
        private void ConnectToDb()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["ItemStockConnectionString"].ToString();
            con = new SqlConnection(connectionstring);
        }

        // 1. Insert Item 
        public bool InsertOrder(OrderList iList)
        {
            ConnectToDb();
            string query = "INSERT INTO [Order] VALUES('" + iList.OrderId + "','" + iList.ItemName + "'," + iList.UnitPrice + "," + iList.Qty + "," + iList.Total + ")";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        // 2. Get All Item List 
        public List<OrderList> GetOrderList()
        {
            ConnectToDb();
            List<OrderList> iList = new List<OrderList>();

            string query = "SELECT * FROM [Order]";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                iList.Add(new OrderList
                {

                    OrderId = Convert.ToString(dr["OrderId"]),
                    ItemName = Convert.ToString(dr["Item Name"]),
                    UnitPrice = Convert.ToDecimal(dr["Unit Price"]),
                    Qty = Convert.ToInt32(dr["Qty"]),
                    Total = Convert.ToDecimal(dr["Total"]),

                });
            }
            return iList;
        }

        //// 3. Update Item Details
        //public bool UpdateItem(ItemList iList)
        //{
        //    ConnectToDb();
        //    string query = "UPDATE Item SET Item ID = '" + iList.ItemID + "', Item Name = '" + iList.ItemName + "', Description = '" + iList.Description + "', Unit Price = " + iList.UnitPrice + ", Added Date = '" + iList.AddedDate + "' WHERE ID = " + iList.ID;
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    con.Open();
        //    int i = cmd.ExecuteNonQuery();
        //    con.Close();

        //    if (i >= 1)
        //        return true;
        //    else
        //        return false;
        //}

        // 4.Delete Item 
        public bool DeleteItem(int id)
        {
            ConnectToDb();
            string query = "DELETE FROM Order WHERE OID = " + id;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }
    }
}