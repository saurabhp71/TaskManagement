using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Practice_Task.Models
{
    public class User
    {
        public int ItemID { get; set; }
        public DateTime EnteredDate { get; set; }
        public string Name { get; set; }
        public string ItemName { get; set; }
        public string Categories { get; set; }
        public string Date { get; set; }
        public string ImageURL { get; set; }
        public int MasterCategoryID { get; set; }
        public int SubCategoryID { get; set; }
        public int ItemCategoryID { get; set; }
        public List<User> ItemList { get; set; }

    }
}