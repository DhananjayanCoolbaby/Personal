using CWR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWR.Repository
{
    public interface IReportingRepository
    {
        /// The SaveCWRData  method
        /// </summary>
        /// <returns>return int</returns> 
        int SaveReporterData(string Reportername, string ReporterEmail, string ReporterContactNO, int ReporterID, string ReporterUsername, string ReporterPassword,string costcentername);

        /// <summary>
        /// The GetDateandDays  method
        /// </summary>
        /// <returns>return list</returns>        
        IList<ReporterDetails> GetSavedReporterDetailes();

        /// <summary>
        /// The GetDateandDays  method
        /// </summary>
        /// <returns>return list</returns>        
        IList<ReporterDetails> FetchDataBasedOnReporter(string ReporterID);

        /// The SaveCWRData  method
        /// </summary>
        /// <returns>return int</returns> 
        int GetReportingID();
    }
}
