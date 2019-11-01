using CWR.BusinessService;
using CWR.Entity;
using Stationery.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CWR.Web.Controllers
{
    public class AddReportingController : BaseController
    {
        private IReportingService ReportingService = null;

        public AddReportingController(IReportingService ReportingService)
        {
            this.ReportingService = ReportingService;
        }
        //
        // GET: /AddReporting/
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// The GetSavedCWRDetailes method
        /// </summary>        
        /// <returns>return list</returns>        
        public int GetReportingID()
        {

            int VendorID = this.ReportingService.GetReportingID();

            return VendorID;
        }

        /// <summary>
        /// The GetState method
        /// </summary>        
        /// <returns>return list</returns>        
        public int SaveReporterData(string Reportername, string ReporterEmail, string ReporterContactNO, int ReporterID, string ReporterUsername, string ReporterPassword, string costcentername)
        {

            int OTimeSheet = this.ReportingService.SaveReporterData(Reportername, ReporterEmail, ReporterContactNO, ReporterID, ReporterUsername, ReporterPassword, costcentername);

            return OTimeSheet;
        }

        /// <summary>
        /// The GetSavedCWRDetailes method
        /// </summary>        
        /// <returns>return list</returns>        
        public JsonResult GetSavedReporterDetailes()
        {

            IList<ReporterDetails> ovendorData = this.ReportingService.GetSavedReporterDetailes();
            JsonResult dataResult = new JsonResult();
            dataResult.Data = ovendorData;
            return dataResult;
        }

        /// <summary>
        /// The GetSavedCWRDetailes method
        /// </summary>        
        /// <returns>return list</returns>        
        public JsonResult FetchDataBasedOnReporter(string ReporterID)
        {

            IList<ReporterDetails> ovendorData = this.ReportingService.FetchDataBasedOnReporter(ReporterID);
            JsonResult dataResult = new JsonResult();
            dataResult.Data = ovendorData;
            return dataResult;
        }


    }
}