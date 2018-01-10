using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharp_Web_Notification_Sample
{

    public class Data
    {

        public string title { get; set; }
        public string body { get; set; }
    }

    public class PushRequestInfo
    {
        public List<string> registration_ids { get; set; }
        public string priority { get; set; }
        public Data data { get; set; }
    }
}