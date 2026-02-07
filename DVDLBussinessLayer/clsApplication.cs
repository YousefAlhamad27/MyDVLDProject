using DVDLDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinessLayer
{
    public class clsApplication
    {

        static public string getTypeNameByAppID(int appID)
        {
            return clsApplicationsDataAccess.getApplicationTypeNameByAppID(appID);
        }



    }
}
