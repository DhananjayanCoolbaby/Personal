
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

    public class EmpTimeSheetService : IEmpTimeSheetService
    {
        private IEmpTimeSheetRepository EmpTimeSheetRepository = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CartDetailsService" /> class.
        /// </summary>
        /// <param name="cartDetailsRepository">The cartDetailsRepository parameter</param>        
        public EmpTimeSheetService(IEmpTimeSheetRepository TimeSheetRepository)
        {
            this.EmpTimeSheetRepository = TimeSheetRepository;
        }

        /// <summary>
        /// The GetVendorsList method
        /// </summary>
        /// <returns>return list</returns>        
        public IList<TimeSheet> GetDateandDays(String UserName)
        {
            ////return object
            return this.EmpTimeSheetRepository.GetDateandDays(UserName);
        }

        /// <summary>
        /// The GetVendorsList method
        /// </summary>
        /// <returns>return list</returns>        
        public int SaveTimevalueDetails(string date, string ProjectHoursWorked, int TimesheetPeriodid, string AssociateID)
        {
            ////return object
            return this.EmpTimeSheetRepository.SaveTimevalueDetails(date, ProjectHoursWorked, TimesheetPeriodid, AssociateID);
        }

        /// <summary>
        /// The GetVendorsList method
        /// </summary>
        /// <returns>return list</returns>        
        public int SaveTimeSheetDetails(DataTable oDataTable, string AssociateID)
        {
            ////return object
            return this.EmpTimeSheetRepository.SaveTimeSheetDetails(oDataTable, AssociateID);
        }

        /// <summary>
        /// The GetVendorsList method
        /// </summary>
        /// <returns>return list</returns>        
        public IList<LegendDetails> FetchLegendDetails()
        {
            ////return object
            return this.EmpTimeSheetRepository.FetchLegendDetails();
        }


        /// <summary>
        /// The GetVendorsList method
        /// </summary>
        /// <returns>return list</returns>        
        public IList<TimeSheetSaveedData> GetSavedTimeSheetDetailes(string AssociateId)
        {
            ////return object
            return this.EmpTimeSheetRepository.GetSavedTimeSheetDetailes(AssociateId);
        }


        /// <summary>
        /// The GetVendorsList method
        /// </summary>
        /// <returns>return list</returns>        
        public IList<TimeSheet> FetchDataBasedOnRequestId(string AssociateId, string RequestId)
        {
            ////return object
            return this.EmpTimeSheetRepository.FetchDataBasedOnRequestId(AssociateId, RequestId);
        }


        /// <summary>
        /// The GetVendorsList method
        /// </summary>
        /// <returns>return list</returns>        
        public IList<TimeSheet> FetchDataBasedOnDate(string AssociateId, DateTime date)
        {
            ////return object
            return this.EmpTimeSheetRepository.FetchDataBasedOnDate(AssociateId, date);
        }
    }
}
