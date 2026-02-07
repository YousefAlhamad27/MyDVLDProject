using DVDLDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinessLayer
{
    public class clsAppointment
    {

        


        static public DataTable getAppointmentsTable(int locAppID)
        {
            return clsAppointmentsDataAccess.getAppointmentsTable(locAppID);
        }

        static public int addNewAppointment(int typeID,int locAppId,DateTime date,decimal PaidFees,int userID,bool isLocked)
        {
            return clsAppointmentsDataAccess.addAppointment(typeID,  locAppId,  date,  PaidFees,  userID,  isLocked);
        }
        static public bool isApplicantEligibleForAnotherAppointment(int locAppID)
        {
            return clsAppointmentsDataAccess.doesApplicantHaveAnOpenAppointment(locAppID);
        }
        static public bool lockAppointment(int appointmentID)
        {
            return clsAppointmentsDataAccess.lockAppointment(appointmentID);
        }
        static public bool getTestInfo(int appointmentID,int testTypeID,ref int locAppID, ref string drivingClassName,
            ref string applicantFullName, ref int trialCount, ref DateTime date, ref decimal Fees)
        {
            return clsAppointmentsDataAccess.getTakeTestInfo(appointmentID,testTypeID,ref locAppID,ref drivingClassName,ref applicantFullName,ref trialCount,ref date,ref Fees);
        }
        static public int getTestTypeAppointmentsCount(int locAppID, int testTypeID)
        {
            return clsAppointmentsDataAccess.testTypeAppointmentsCount(locAppID,testTypeID);
        }
        static public int getLocAppID(int testAppointmentID)
        {
            return clsAppointmentsDataAccess.getLocalAppID(testAppointmentID);
        }
        static public bool updateAppointment(int testAppointmentID,DateTime date)
        {
            return clsAppointmentsDataAccess.updateAppointment(testAppointmentID,date);
        }
    }
}
