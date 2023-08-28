using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Practice_Task.Models;
using System.Data.SqlClient;

namespace Practice_Task.Controllers
{
    public class Item : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Item_List()
        {
            User obj = new User();
            BAL bal = new BAL();
            DataSet ds = new DataSet();
            ds = bal.ItemList();
            List<User> list = new List<User>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                User objuser1 = new User();
                objuser1.ItemCategoryID = Convert.ToInt32(ds.Tables[0].Rows[i]["ItemCategoryID"].ToString());
                objuser1.ItemName = ds.Tables[0].Rows[i]["ItemName"].ToString();
                objuser1.Categories = ds.Tables[0].Rows[i]["Categories"].ToString();
                objuser1.Date = ds.Tables[0].Rows[i]["EnteredDate"].ToString();
                list.Add(objuser1);

            }
            obj.ItemList = list;
            return View(obj);
        }
    }
}