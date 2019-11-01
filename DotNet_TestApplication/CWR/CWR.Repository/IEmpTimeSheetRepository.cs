using CWR.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWR.Repository
{
    public interface IEmpTimeSheetRepository
    {
        /// <summary>
        /// The GetVendorsList method
        /// </summary>
        /// <returns>return list</returns>        
        IList<TimeSheet> GetDateandDays(String UserName);

        /// <summary>
        /// The SaveTimevalueDetails  method
        /// </summary>
        /// <returns>return list</returns>        
        int SaveTimevalueDetails(string date, string ProjectHoursWorked, int TimesheetPeriodid, string AssociateID);

        /// <summary>
        /// The GetDateandDays  method
        /// </summary>
        /// <returns>return list</returns>        
        int SaveTimeSheetDetails(DataTable DtTimeSheet, string AssociateID);


        /// <summary>
        /// The GetDateandDays  method
        /// </summary>
        /// <returns>return list</returns>        
        IList<LegendDetails> FetchLegendDetails();


        /// <summary>
        /// The GetDateandDays  method
        /// </summary>
        /// <returns>return list</returns>        
        IList<TimeSheetSaveedData> GetSavedTimeSheetDetailes(string AssociateId);

        /// <summary>
        /// The GetDateandDays  method
        /// </summary>
        /// <returns>return list</returns>    
        IList<TimeSheet> FetchDataBasedOnRequestId(string AssociateId, string RequestId);


        /// <summary>
        /// The FetchDataBasedOnDate  method
        /// </summary>
        /// <returns>return list</returns>    
        IList<TimeSheet> FetchDataBasedOnDate(string AssociateId, DateTime Date);
    }
}
