using ChickenShop.Logic;
using ChickenShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChickenShop
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Category> GetCategories()
        {
            var _db = new ChickenShop.Models.BookContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        }

    }
}