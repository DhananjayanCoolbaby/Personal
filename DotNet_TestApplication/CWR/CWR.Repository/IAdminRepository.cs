using CWR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWR.Repository
{
    public interface IAdminRepository
    {
        /// <summary>
        /// The GetState method
        /// </summary>
        /// <returns>return list</returns>        
        IList<State> GetState();

        /// <summary>
        /// The GetPosition method
        /// </summary>
        /// <returns>return list</returns>        
        IList<Position> GetPosition();

        /// <summary>
        /// The SaveCWRData  method
        /// </summary>
        /// <returns>return int</returns> 
        int SaveCWRData(string Username, string Password, string koneEmail, string Reporting, string Vendor,
        string Position, string FName, string LName, string DOB, string FatherName, string MobileNo, string Gender, string Address, string CityorTown, string State,
            string Remarks, string PersonalEmail, string EmergencycontactNo, string Employeeid, string JoiningDate, string Reportingdate, string EmployeerEmailAddress);


        /// <summary>
        /// The GetSavedCWRDetailes  method
        /// </summary>
        /// <returns>return list</returns>        
        IList<CWRSavedData> GetSavedCWRDetailes();



        /// <summary>
        /// The FetchDataBasedOnUserName  method
        /// </summary>
        /// <returns>return list</returns>        
        IList<CWRSavedDataDetails> FetchDataBasedOnUserName(string UserName);



        /// <summary>
        /// The CheckUsernamesAvailability  method
        /// </summary>
        /// <returns>return boolen</returns>        
        bool CheckUsernamesAvailability(string UserName);


        /// <summary>
        /// The GetReportingDetiles  method
        /// </summary>
        /// <returns>return boolen</returns>        
        IList<Reporting> GetReportingDetiles();

        /// <summary>
        /// The GetReportingDetiles  method
        /// </summary>
        /// <returns>return boolen</returns>        
        IList<Vendor> GetVendorDetiles();
    }
}
