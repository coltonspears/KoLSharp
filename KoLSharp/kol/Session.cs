using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoLSharp.kol.request;

namespace KoLSharp.kol
{
    class Session
    {
        public bool isConnected { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPasswordHash { get; set; }
        public string ServerURL { get; set; }
        public string Password { get; set; }

        public void Login(string username, string password, int servernumber = 0)
        {
            /* Perform a KoL login given a username and password. A server number may also be specified
             * to ensure that the user logs in using that particular server. This can be helpful
             * if the user continues to be redirected to a server that is down. 
             */

            this.UserName = username;
            this.Password = password;

            
            HomepageRequest homepageRequest = new HomepageRequest(servernumber);
            var homepageResponse = homepageRequest.doRequest();

            //this.ServerURL = homepageResponse.serverURL;

            // Perform the login
            //loginRequest = LoginRequest();
            //loginRequest.doRequest();

            



        }
        public void Logout()
        {

        }
    }
}
