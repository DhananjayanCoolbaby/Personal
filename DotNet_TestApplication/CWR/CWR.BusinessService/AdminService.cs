namespace CWR.BusinessService
{

    using CWR.Entity;
    using CWR.Repository;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AdminService : IAdminService
    {
        private IAdminRepository AdminRepository = null;
        /// <summary>
        /// Initializes a new instance of the <see cref="CartDetailsService" /> class.
        /// </summary>
        /// <param name="cartDetailsRepository">The cartDetailsRepository parameter</param>        
        public AdminService(IAdminRepository oAdminRepository)
        {
            this.AdminRepository = oAdminRepository;
        }

        /// <summary>
        /// The GetState method
        /// </summary>
        /// <returns>return list</returns>        
        public IList<State> GetState()
        {
            ////return object
            return this.AdminRepository.GetState();
        }

        /// <summary>
        /// The GetState method
        /// </summary>
        /// <returns>return list</returns>        
        public IList<Position> GetPosition()
        {
            ////return object
            return this.AdminRepository.GetPosition();
        }

        /// <summary>
        /// The GetState method
        /// </summary>
        /// <returns>return list</returns>        
        public int SaveCWRData(string Username, string Password, string koneEmail, string Reporting, string Vendor,
        string Position, string FName, string LName, string DOB, string FatherName, string MobileNo, string Gender, string Address, string CityorTown, string State,
            string Remarks, string PersonalEmail, string EmergencycontactNo, string Employeeid, string JoiningDate, string Reportingdate, string EmployeerEmailAddress)
        {
            ////return object
            return this.AdminRepository.SaveCWRData(Username, Password, koneEmail, Reporting, Vendor,
         Position, FName, LName, DOB, FatherName, MobileNo, Gender, Address, CityorTown, State,
             Remarks, PersonalEmail, EmergencycontactNo, Employeeid, JoiningDate, Reportingdate, EmployeerEmailAddress);
        }

        /// <summary>
        /// The GetState method
        /// </summary>
        /// <returns>return list</returns>        
        public IList<CWRSavedData> GetSavedCWRDetailes()
        {
            ////return object
            return this.AdminRepository.GetSavedCWRDetailes();
        }



        /// <summary>
        /// The GetState method
        /// </summary>
        /// <returns>return list</returns>        
        public IList<CWRSavedDataDetails> FetchDataBasedOnUserName(string UserName)
        {
            ////return object
            return this.AdminRepository.FetchDataBasedOnUserName(UserName);
        }


        /// <summary>
        /// The CheckUsernamesAvailability  method
        /// </summary>
        /// <returns>return boolen</returns>        
        public bool CheckUsernamesAvailability(string UserName)
        {

            ////return object
            return this.AdminRepository.CheckUsernamesAvailability(UserName);
        }


        /// <summary>
        /// The GetState method
        /// </summary>
        /// <returns>return list</returns>        
        public IList<Reporting> GetReportingDetiles()
        {
            ////return object
            return this.AdminRepository.GetReportingDetiles();
        }

        /// <summary>
        /// The GetState method
        /// </summary>
        /// <returns>return list</returns>        
        public IList<Vendor> GetVendorDetiles()
        {
            ////return object
            return this.AdminRepository.GetVendorDetiles();
        }
    }
}
