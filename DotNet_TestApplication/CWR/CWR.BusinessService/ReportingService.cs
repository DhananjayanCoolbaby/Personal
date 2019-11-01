﻿namespace CWR.BusinessService
{
    using CWR.Entity;
    using CWR.Repository;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class ReportingService : IReportingService
    {
        private IReportingRepository ReportingRepository = null;
        /// <summary>
        /// Initializes a new instance of the <see cref="CartDetailsService" /> class.
        /// </summary>
        /// <param name="cartDetailsRepository">The cartDetailsRepository parameter</param>        
        public ReportingService(IReportingRepository oReportingRepository)
        {
            this.ReportingRepository = oReportingRepository;
        }

         /// <summary>
         /// The GetState method
         /// </summary>
         /// <returns>return list</returns>        
        public int SaveReporterData(string Reportername, string ReporterEmail, string ReporterContactNO, int ReporterID, string ReporterUsername, string ReporterPassword, string costcentername)
        {
             ////return object
            return this.ReportingRepository.SaveReporterData(Reportername, ReporterEmail, ReporterContactNO, ReporterID, ReporterUsername, ReporterPassword, costcentername);
         }

         /// <summary>
         /// The GetState method
         /// </summary>
         /// <returns>return list</returns>        
        public IList<ReporterDetails> GetSavedReporterDetailes()
         {
             ////return object
             return this.ReportingRepository.GetSavedReporterDetailes();
         }


         /// <summary>
         /// The GetState method
         /// </summary>
         /// <returns>return list</returns>        
        public IList<ReporterDetails> FetchDataBasedOnReporter(string ReportingID)
         {
             ////return object
             return this.ReportingRepository.FetchDataBasedOnReporter(ReportingID);
         }

         /// The SaveCWRData  method
         /// </summary>
         /// <returns>return int</returns> 
        public int GetReportingID()
         {
             ////return object
             return this.ReportingRepository.GetReportingID();
         }
    }
}
