using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_upload_Image
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, DataListCommandEventArgs e)
        {
            if (e.CommandName == "call")
            {
                DataListItem item = (DataListItem)(((Button)(e.CommandSource)).NamingContainer);
                string text = ((Label)item.FindControl("TextBox1")).Text;




                DeleteImage.WebService1 S1 = new DeleteImage.WebService1();
                S1.Credentials = System.Net.CredentialCache.DefaultCredentials;

                String a;

                a = S1.deleteTable(text);

                if (a.Equals("Success insert"))
                {

                    Response.Write("Upload Successful");

                }
                else
                    Response.Write("Upload not Successful");

          
            
            
            
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}