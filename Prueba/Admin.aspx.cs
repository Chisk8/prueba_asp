using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Timeout = 1;
                if (Session["admin"] != null && Session["estado"].ToString() != "Inactivo")
                {
                    lbl_mensaje.Text += Session["admin"].ToString();
                }
                else
                {
                    Response.Redirect("Log.aspx");
                }
            }
        }

        protected void btn_session_Click(object sender, EventArgs e)
        {
            Session["admin"] = null;
            Response.Redirect("Log.aspx");
        }
    }
}