using CWR.BusinessService;
using CWR.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using CTS.OneCognizant.Platform.CoreServices;
using System.Web.Mvc;
using System.Configuration;

namespace CWR.Web.Controllers
{
    public class TimeSheetController : Controller
    {
        AssociateDetail associate = new AssociateDetail();
        Credential oCredential = new Credential();
        private IEmpTimeSheetService EmpTimeSheetService = null;

        public TimeSheetController(IEmpTimeSheetService EmpTimeSheetService)
        {
            this.EmpTimeSheetService = EmpTimeSheetService;
        }
        //
        // GET: /TimeSheet/
        public ActionResult Index(string associateId, string Userlevel)
        {

            if (HttpContext.Session["AssociateDetails"] == null)
            {
                if (string.IsNullOrEmpty(associateId))
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
            this.ViewBag.associateDetails = associate;
            //this.ViewBag.AssociateDetails = associate.AssociateId;
            //this.ViewBag.Userlevel =associate.UserRole.ToString().Trim();
            IList<TimeSheet> OTimeSheet = this.EmpTimeSheetService.GetDateandDays(associate.AssociateId);
            if (associate.UserRole == "l1")
            {
                // return this.RedirectToAction("Index", "Admin");

                return RedirectToAction("Index", "Admin", new { associate.AssociateId, associate.UserRole });
            }
            else if (associate.UserRole == "l2")
            {
                return RedirectToAction("Index", "EmpRegister", new { associate.AssociateId, associate.UserRole });
            }
            else
            {
                return View(OTimeSheet);
            }

        }

        /// <summary>
        /// The FetchVendorItemDetails method
        /// </summary>
        /// <param name="vendorId">The vendorId parameter</param>
        /// <param name="groupId">The groupId parameter</param>
        /// <returns>return list</returns>        
        public JsonResult FetchDateDetails(string CWRID)
        {
            string AssociateId = CWRID.ToString();
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
            IList<TimeSheet> OTimeSheet = this.EmpTimeSheetService.GetDateandDays(associate.AssociateId);
            JsonResult dataResult = new JsonResult();
            dataResult.Data = OTimeSheet;
            return dataResult;
        }


        /// <summary>
        /// The FetchVendorItemDetails method
        /// </summary>
        /// <param name="vendorId">The vendorId parameter</param>
        /// <param name="groupId">The groupId parameter</param>
        /// <returns>return list</returns>        
        public int SavedaybydateTime(string date, string ProjectHoursWorked, int TimesheetPeriodid)
        {
            string AssociateID = string.Empty;
            if (HttpContext.Session["AssociateID"] == null)
            {
                string UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
                string[] SplUserName = UserName.Split('\\');
                Session["AssociateID"] = Convert.ToString(SplUserName[1]);
            }
            else
            {
                AssociateID = Session["AssociateID"].ToString();
            }
            return this.EmpTimeSheetService.SaveTimevalueDetails(date, ProjectHoursWorked, TimesheetPeriodid, AssociateID);
        }


        /// <summary>
        /// The Save Pont of Contact Details method
        /// </summary>
        /// <param name="pocarry">The point of contact parameter</param>
        /// <returns>The integer type object</returns>    
        public int SaveTimeSheetDetails(IList<TimeSheet> pocarry)
        {
            string AssociateID = string.Empty;
            if (HttpContext.Session["AssociateDetails"] == null)
            {
                if (string.IsNullOrEmpty(AssociateID))
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
            TimeSheet OtimSheet = new TimeSheet();
            DataTable DtTimeSheet = ToDataTable(OtimSheet);
            DtTimeSheet.Columns.Remove("Date");
            DtTimeSheet.Columns.Remove("Days");
            DtTimeSheet.Columns.Remove("ItemArray");
            int status = 0;
            if (pocarry != null)
            {
                for (int i = 0; i < pocarry.Count; i++)
                {
                    string timeval = pocarry[i].ProjectHoursWorked;
                    if (timeval == null)
                    {
                        timeval = "0";
                    }
                    DtTimeSheet.Rows.Add(timeval, pocarry[i].DateWorked, pocarry[i].TimesheetPeriodid, pocarry[i].Comments);

                }
            }

            status = this.EmpTimeSheetService.SaveTimeSheetDetails(DtTimeSheet, associate.AssociateId);
            return status;
        }

        private DataTable ToDataTable<T>(T entity) where T : class
        {
            var properties = typeof(T).GetProperties();
            var table = new DataTable();

            foreach (var property in properties)
            {
                table.Columns.Add(property.Name, property.PropertyType);
            }

            // table.Rows.Add(properties.Select(p => p.GetValue(entity, null)).ToArray());
            return table;
        }

        /// <summary>
        /// The FetchVendorItemDetails method
        /// </summary>
        /// <param name="vendorId">The vendorId parameter</param>
        /// <param name="groupId">The groupId parameter</param>
        /// <returns>return list</returns>        
        public JsonResult FetchLegendDetails()
        {

            IList<LegendDetails> oLegendDetails = this.EmpTimeSheetService.FetchLegendDetails();
            JsonResult dataResult = new JsonResult();
            dataResult.Data = oLegendDetails;
            ////return dataresult
            return dataResult;
        }

        /// <summary>
        /// The GetSavedTimeSheetDetailes methodk
        /// </summary>
        /// <returns>return list</returns>        
        public JsonResult GetSavedTimeSheetDetailes(string CWRID)
        {
            string AssociateId = CWRID.ToString();
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
            IList<TimeSheetSaveedData> OTimeSheet = this.EmpTimeSheetService.GetSavedTimeSheetDetailes(associate.AssociateId);
            JsonResult dataResult = new JsonResult();
            dataResult.Data = OTimeSheet;
            ////return dataresult
            return dataResult;
        }


        /// <summary>
        /// The FetchDataBasedOnRequestId method
        /// </summary>
        /// <param name="vendorId">The RequestId parameter</param>        
        /// <returns>return list</returns>    
        public JsonResult FetchDataBasedOnRequestId(string RequestId)
        {
            string AssociateId = String.Empty;
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
            IList<TimeSheet> OTimeSheet = this.EmpTimeSheetService.FetchDataBasedOnRequestId(associate.AssociateId, RequestId);
            JsonResult dataResult = new JsonResult();
            dataResult.Data = OTimeSheet;

            return dataResult;
        }

        /// <summary>
        /// The FetchDataBasedOnRequestId method
        /// </summary>
        /// <param name="vendorId">The RequestId parameter</param>        
        /// <returns>return list</returns>    
        public JsonResult FetchDataBasedOnDate(string Date)
        {
            DateTime Datime = Convert.ToDateTime(Date.ToString());

            string AssociateId = String.Empty;
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
            IList<TimeSheet> OTimeSheet = this.EmpTimeSheetService.FetchDataBasedOnDate(associate.AssociateId, Datime);
            JsonResult dataResult = new JsonResult();
            dataResult.Data = OTimeSheet;

            return dataResult;
        }
    }
}