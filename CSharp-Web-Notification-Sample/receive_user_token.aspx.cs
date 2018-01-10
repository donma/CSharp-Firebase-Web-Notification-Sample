using System;

namespace CSharp_Web_Notification_Sample
{
    public partial class receive_user_token : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request["user_token"]))
            {

                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "user_token");

                System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "user_token" + System.IO.Path.DirectorySeparatorChar + GetMD5String(Request["user_token"]), Request["user_token"]);

                Response.Write("SUCCESS");
            }
            else
            {
                Response.Write("ERROR");
            }
        }

        public string GetMD5String(string input)
        {
            var md5 = System.Security.Cryptography.MD5.Create();
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(input)).Length; i++)
            {
                sb.Append(md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(input))[i].ToString("X2"));
            }
            return sb.ToString();

        }

    }
}