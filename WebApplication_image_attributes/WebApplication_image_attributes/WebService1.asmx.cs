using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication_image_attributes
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }




        [WebMethod]
        public string insertTable(string userId, string ImgName, string ItmName, string note, string location)
        {
            //Declare Connection by passing the connection string from the web config file
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);

            //Open the connection
            conn.Open();

            //Declare the sql command
            SqlCommand cmd = new SqlCommand("Insert into ImageTable(UserId,ImageName,ItemName,Notes,Location)values('" + userId + "','" + ImgName + "','" + ItmName + "','" + note + "','" + location + "')", conn);

            //Execute the insert query
            cmd.ExecuteNonQuery();  
            cmd.Dispose();
            //close the connection
            conn.Close();

            return "Success insert";

        }

        [WebMethod]
        public string deleteTable(string name)
        {
            //Declare Connection by passing the connection string from the web config file
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);

            //Open the connection
            conn.Open();

            //Declare the sql command
            SqlCommand cmd = new SqlCommand("Delete From ImageTable Where ImageName= '" + name + "'", conn);

            //Execute the insert query
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            //close the connection
            conn.Close();

            return "Bought";
        }




    }
}
