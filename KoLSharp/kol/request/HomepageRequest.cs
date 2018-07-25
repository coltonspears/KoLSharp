using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoLSharp.kol.request
{
    class HomepageRequest : GenericRequest
    {
        public string url { get; set; }
        public HomepageRequest(int serverNumber=0)
        {
            if(serverNumber > 0)
            {
                this.url = "http://www" + serverNumber + ".kingdomofloathing.com/main.php";
            }
            else
            {
                this.url = "http://www.kingdomofloathing.com/";
            }            
        }
    }
}
