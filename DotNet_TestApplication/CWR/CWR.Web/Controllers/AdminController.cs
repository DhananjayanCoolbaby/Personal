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
    public class AdminController : BaseController
    {

        private IAdminService AdminService = null;
        AssociateDetail associate = new AssociateDetail();
        public AdminController(IAdminService AdminService)
        {
            this.AdminService = AdminService;
        }
        //
        // GET: /Admin/
        public ActionResult Index(string AssociateId, string UserRole)
        {


            if (HttpContext.Session["AssociateDetails"] == null)
            {
                if (string.IsNullOrEmpty(AssociateId))
                {
                    //UserContext userContext = UserContext.GetUserContext();
                    //associate.AssociateId = userContext.CurrentUser.UserId;
                    //associate.AssociateName = userContext.CurrentUser.FirstName;
                }
                else
                {
                    //if (ConfigurationManager.AppSettings["ProxyUser"] != "true")
                    //{
                    //    UserContext userContext = UserContext.GetUserContext();
                    //    associate.AssociateId = userContext.CurrentUser.UserId;
                    //    associate.AssociateName = userContext.CurrentUser.FirstName;
                    //}
                    //else
                    //{
                    //    associate.AssociateId = associateId;
                    //    associate.AssociateName = "Proxy" + " " + "User";
                    //}
                }

                HttpContext.Session["associateDetails"] = associate;
            }
            else
            {
                associate = (AssociateDetail)HttpContext.Session["associateDetails"];
            }
            this.ViewBag.AssociateId = associate.AssociateId.ToString();
            this.ViewBag.UserRole = associate.UserRole.ToString();
            return View();
        }

        /// <summary>
        /// The GetState method
        /// </summary>        
        /// <returns>return list</returns>        
        public JsonResult GetState()
        {

            IList<State> OTimeSheet = this.AdminService.GetState();
            JsonResult dataResult = new JsonResult();
            dataResult.Data = OTimeSheet;
            return dataResult;
        }

        /// <summary>
        /// The GetState method
        /// </summary>        
        /// <returns>return list</returns>        
        public JsonResult GetPosition()
        {

            IList<Position> oPosition = this.AdminService.GetPosition();
            JsonResult dataResult = new JsonResult();
            dataResult.Data = oPosition;
            return dataResult;
        }

        /// <summary>
        /// The GetState method
        /// </summary>        
        /// <returns>return list</returns>        
        public int SaveCWRData(string Username, string Password, string koneEmail, string Reporting, string Vendor,
        string Position, string FName, string LName, string DOB, string FatherName, string MobileNo, string Gender, string Address, string CityorTown, string State,
            string Remarks, string PersonalEmail, string EmergencycontactNo, string Employeeid, string JoiningDate, string Reportingdate, string EmployeerEmailAddress)
        {

            int OTimeSheet = this.AdminService.SaveCWRData(Username, Password, koneEmail, Reporting, Vendor,
         Position, FName, LName, DOB, FatherName, MobileNo, Gender, Address, CityorTown, State,
             Remarks, PersonalEmail, EmergencycontactNo, Employeeid, JoiningDate, Reportingdate, EmployeerEmailAddress);

            return OTimeSheet;
        }


        /// <summary>
        /// The GetSavedCWRDetailes method
        /// </summary>        
        /// <returns>return list</returns>        
        public JsonResult GetSavedCWRDetailes()
        {

            IList<CWRSavedData> oCWRSavedData = this.AdminService.GetSavedCWRDetailes();
            JsonResult dataResult = new JsonResult();
            dataResult.Data = oCWRSavedData;
            return dataResult;
        }

        /// <summary>
        /// The FetchDataBasedOnUserName method
        /// </summary>        
        /// <returns>return list</returns>        
        public JsonResult FetchDataBasedOnUserName(string username)
        {

            IList<CWRSavedDataDetails> oCWRSavedData = this.AdminService.FetchDataBasedOnUserName(username);
            JsonResult dataResult = new JsonResult();
            dataResult.Data = oCWRSavedData;
            return dataResult;
        }

        /// <summary>
        /// The CheckUsernamesAvailability method
        /// </summary>
        /// <param name="UserName">The UserName parameter</param>
        /// <returns>The boolean type object</returns>            
        public bool CheckUsernamesAvailability(string UserName)
        {
            bool isAvailable = this.AdminService.CheckUsernamesAvailability(UserName);
            ////return isavailable
            return isAvailable;
        }

        /// <summary>
        /// The GetReportingDetiles method
        /// </summary>        
        /// <returns>return list</returns>        
        public JsonResult GetReportingDetiles()
        {

            IList<Reporting> oReporting = this.AdminService.GetReportingDetiles();
            JsonResult dataResult = new JsonResult();
            dataResult.Data = oReporting;
            return dataResult;
        }

        /// <summary>
        /// The GetReportingDetiles method
        /// </summary>        
        /// <returns>return list</returns>        
        public JsonResult GetVendorDetiles()
        {

            IList<Vendor> oVendor = this.AdminService.GetVendorDetiles();
            JsonResult dataResult = new JsonResult();
            dataResult.Data = oVendor;
            return dataResult;
        }
    }
}