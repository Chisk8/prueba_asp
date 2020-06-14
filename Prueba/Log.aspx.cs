using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba
{
    public partial class Log : System.Web.UI.Page
    {
        string nombre1 = "Chis";
        string pass1 = "12345";

        string nombre2 = "Usu";
        string pass2 = "123456";

        string estado1 = "Activo";
        string estado2 = "Inactivo";
        //Numero de intentos con variables de sesion 
        //tiempo de espera de una sesion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Timeout = 1;
                Session["estado"] = "Activo";
                Session["cont"] = 3;
                lbl_contador.Text = "";
                if (Session["admin"] != null)
                {
                    Response.Redirect("Admin.aspx");
                }
            }
            else
            {
                if (Session["admin"] != null)
                {
                    Response.Redirect("Admin.aspx");
                }
            }
        }

        protected void Ingreso_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_pass.Text == "")
            {
                lbl_contador.Text = "Usuario o Contasena vacios";
                //Ingreso.Enabled = false;
            }
            else
            {
                lbl_contador.Text = "";
                if (nombre1 == txt_name.Text && pass1 == txt_pass.Text && Session["estado"].ToString() == "Activo")
                {
                    Session["admin"] = txt_name.Text;
                    Session["cont"] = 3;
                    Response.Redirect("Admin.aspx");
                }
                else
                {
                    if (nombre1 == txt_name.Text && pass1 != txt_pass.Text && Session["estado"].ToString() == "Activo")
                    {
                        if (Convert.ToInt32(Session["cont"].ToString()) > 1)
                        {
                            Session["cont"] = Convert.ToInt32(Session["cont"].ToString()) - 1;
                            //string cont2= Session["cont"].ToString();
                            txt_pass.Text = "";
                            lbl_contador.Text = "Le quedan: " + Session["cont"] + " intentos ";
                        }
                        else
                        {
                            lbl_contador.Text = "Exceso de intentos, Usuario Inactivo";
                            txt_name.Text = "";
                            txt_pass.Text = "";
                            //Ingreso.Enabled = false;
                            Session["estado"] = "Inactivo";
                            Session["cont"] = 3;

                        }
                    }
                    else
                    {
                        if (Session["estado"].ToString() == "Inactivo" && nombre1 == txt_name.Text)
                        {
                            lbl_contador.Text = "Usuario Inactivo";
                            txt_pass.Text = "";
                        }
                        else
                        {
                            lbl_contador.Text = "Usuario no registrado";
                            txt_pass.Text = "";
                        }

                    }
                }
            }
        }
    }
}