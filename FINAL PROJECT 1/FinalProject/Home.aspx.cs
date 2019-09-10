﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class Home : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["DbCon"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = " اهلا";
            Label2.Text = "! "+Session["username"].ToString() + name;

            function();

           
        }

        void function()
        {
            SqlCommand command4 = conn.CreateCommand();
            command4.CommandText = "select idLab from Users where username=@username";
            command4.Parameters.AddWithValue("username", Session["username"].ToString());
            conn.Open();
            command4.ExecuteNonQuery();
            SqlDataReader dr = command4.ExecuteReader();

            if(dr.Read())
            {
                int lab = int.Parse(dr["idLab"].ToString());

                ImageButton1.ImageUrl = "~/img/bellWhite2.png";
                int c = 0;
                SqlCommand command3 = conn.CreateCommand();
                command3.CommandText = "select * from Prescription p ,Users u, Labs l where ComNotification=1 and ComSecNotification=1 and LabNotification=0 and u.idLab=l.idLab and u.idLab=@idLab and p.idUser=u.idUser ";
                command3.Parameters.AddWithValue("idLab", lab);
                command3.ExecuteNonQuery();
                SqlDataReader dr3 = command3.ExecuteReader();
                try
                {
                    while (dr3.Read())
                    {
                        ImageButton1.ImageUrl = "~/img/bellYellow2.png";
                        c++;
                        counter.Text = c.ToString();
                    }
                    conn.Close();
                }
                catch (SqlException sqlexception)
                {
                    Response.Write("ERROR ::" + sqlexception.Message);
                }
                catch (Exception ex)
                {
                    Response.Write("ERROR ::" + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                string session = Session["username"].ToString();
            }
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Remove("prnb");
            Session.Remove("patient-ssn");
            Session.Remove("patient-fullname");
            Session.Remove("patient-dateofbirth");

            Session.Remove("doctor-fullname");
            Session.Remove("doctor-speciality");
            Session.Remove("doctor-phonenb");
            Response.Redirect("prNB.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Getssn.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("HomeNotification.aspx");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            function();
        }
    }
}