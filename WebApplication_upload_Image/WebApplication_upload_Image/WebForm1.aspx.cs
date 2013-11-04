using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_upload_Image
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FileUpload1.SaveAs(Server.MapPath("storage\\" + FileUpload1.FileName + ""));

            var fName = FileUpload1.FileName;
            var usrName = "Ashok";
            var itmName = TextBox1.Text;
            var location = TextBox2.Text;
            var notes = TextBox3.Text;


            UploadAttribute.WebService1 S1 = new UploadAttribute.WebService1();
            S1.Credentials = System.Net.CredentialCache.DefaultCredentials;

            String a;

            a = S1.insertTable(usrName, fName, itmName, notes, location);

            if (a.Equals("Success insert")) {

                Response.Write("Upload Successful");

            }
            else
                Response.Write("Upload not Successful");

        }
    }
}