using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace _2018_05_17.EFCode
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Model1 c = new Model1();
            c.Configuration.ProxyCreationEnabled = false;
            List<Product> ps = c.Products.ToList<Product>();
            if (!IsPostBack)
            {
                GridView1.DataSource = ps;
                GridView1.DataBind();
            }
            if (Request.QueryString["json"] is null)
            {
                Product v = ps[0];
                Response.Clear();
                Response.ContentType = "application/json;charset=utf-8";
                Response.Write(JsonConvert.SerializeObject(ps));
                Response.End();
            }
        }
    }
}