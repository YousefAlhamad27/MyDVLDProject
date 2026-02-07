using DVDLDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinessLayer
{
    public class clsTakeTest
    {


        static public int addNewTest(int testAppointID,bool result,string notes,int createdByUserID)
        {
            int testID = -1;


            return clsTestsDataAccess.takeTest( testID,testAppointID,result,notes,createdByUserID);
        }
    }
}
