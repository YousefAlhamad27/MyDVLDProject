using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinessLayer
{
    public class clsSession
    {
        static public clsUser currentUser {  get; set; }

        static public bool isUserLoggedIn =>currentUser!= null;

        static public void login(clsUser user) {
        currentUser = user;
        }

        static public void logout() {
            currentUser = null;
        
        }
    }
}
