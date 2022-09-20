using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CafeProject.Models
{
    public class ItemDbHandler
    {
        private SqlConnection con;
        private void ConnectToDb()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["ItemStockConnectionString"].ToString();
            con = new SqlConnection(connectionstring);
        }

        // 1. Insert Item 
        public bool InsertItem(ItemList iList)
        {
            ConnectToDb();
            string query = "INSERT INTO Item VALUES('" + iList.ItemID + "','" + iList.ItemName + "','" + iList.Description+ "'," + iList.UnitPrice+ ",'" + iList.AddedDate+ "')";
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
        public List<ItemList> GetItemList()
        {
            ConnectToDb();
            List<ItemList> iList = new List<ItemList>();

            string query = "SELECT * FROM Item";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                iList.Add(new ItemList
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    ItemID = Convert.ToString(dr["Item ID"]),
                    ItemName = Convert.ToString(dr["Item Name"]),
                    Description = Convert.ToString(dr["Description"]),
                    UnitPrice = Convert.ToDecimal(dr["Unit Price"]),
                    AddedDate = Convert.ToDateTime(dr["Added Date"])
                });
            }
            return iList;
        }

        // 3. ********** Update Item Details **********
        public bool UpdateItem(ItemList iList)
        {
            ConnectToDb();
            string query = "UPDATE Item SET Item ID = '" + iList.ItemID + "', Item Name = '" + iList.ItemName + "', Description = '" + iList.Description + "', Unit Price = " + iList.UnitPrice + ", Added Date = '" + iList.AddedDate + "' WHERE ID = " + iList.ID;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        // 4. ********** Delete Item **********
        public bool DeleteItem(int id)
        {
            ConnectToDb();
            string query = "DELETE FROM Item WHERE ID = " + id;
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