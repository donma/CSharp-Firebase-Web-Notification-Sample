using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharp_Web_Notification_Sample
{
    public partial class ServerPushData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPushAllUsers_Click(object sender, EventArgs e)
        {

            string serverKey = "AAAAf8RzuZY:APA91bEzYy3t1nJBDJlH5YxDhqLuI3yBpFn46fbBzmSo9tSi-A4R7yeiilBBGOOVJnWRMqOkuRQWMeHkTLJJbnoimAvO3oeRShA8LN6l-x1UWPoV_vZW2_M-VD9Azb7x6R-xBxFIZMYH";

            var files = System.IO.Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "user_token");

            var wc = new System.Net.WebClient();
            wc.Headers.Add("Authorization", "key="+ serverKey);
            wc.Headers.Add("Content-Type", "application/json");
            wc.Encoding = System.Text.Encoding.UTF8;

            if (files != null)
            {

                foreach (var file in files)
                {

                    var token = System.IO.File.ReadAllText(file);
                    Response.Write("TOKEN:" + token.ToString() + "<br>");


                    var d = new PushRequestInfo();
                    d.registration_ids = new List<string>();
                    d.registration_ids.Add(token);

                    d.priority = "normal";
                    d.data = new Data();
                    d.data.body = "Donma TEST";
                    d.data.title = "HI,許當麻";

                    var res = wc.UploadString("https://fcm.googleapis.com/fcm/send", Newtonsoft.Json.JsonConvert.SerializeObject(d));
                    Response.Write(res + "<br><br>");
                }
            }
        }
    }
}