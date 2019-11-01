using CWR.BusinessService;
using CWR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Data;

namespace CWR.Web.Controllers
{
    public class EmpRegisterController : Controller
    {

        private IEmpRegisterService EmpRegisterService = null;
        AssociateDetail associate = new AssociateDetail();
        public EmpRegisterController(IEmpRegisterService EmpRegisterService)
        {
            this.EmpRegisterService = EmpRegisterService;
        }
        //

        //
        // GET: /EmpRegister/

        public ActionResult Index(string username, string Userlevel)
        {

            return View();
        }

        /// <summary>
        /// The GetAllCWRRegisterDetails method
        /// </summary>
        /// <param name="vendorId">The vendorId parameter</param>
        /// <param name="groupId">The groupId parameter</param>
        /// <returns>return list</returns>        
        public JsonResult GetAllCWRRegisterDetails()
        {


            List<CWRRegisterDetails> oCWRRegisterDetails = new List<CWRRegisterDetails>();
            JsonResult dataResult = new JsonResult();
            dataResult.Data = this.EmpRegisterService.GetAllCWRRegisterDetails();
            return dataResult;



        }

        /// The GetMonthDate method
        /// </summary>
        /// <param name="vendorId">The vendorId parameter</param>
        /// <param name="groupId">The groupId parameter</param>
        /// <returns>return list</returns>        
        public JsonResult GetMonthDate()
        {
            List<CWRRegisterDetails> oCWRRegisterDetails = new List<CWRRegisterDetails>();
            JsonResult dataResult = new JsonResult();
            dataResult.Data = this.EmpRegisterService.GetMonthDate();
            return dataResult;

        }

        /// The GetDataBasedOnDate method
        /// </summary>
        /// <param name="vendorId">The vendorId parameter</param>
        /// <param name="groupId">The groupId parameter</param>
        /// <returns>return list</returns>        
        public JsonResult GetDataBasedOnDate(string SelectDate)
        {
            return GetMonthDate();

        }

        /// The GetDataBasedOnDate method
        /// </summary>
        /// <param name="vendorId">The vendorId parameter</param>
        /// <param name="groupId">The groupId parameter</param>
        /// <returns>return list</returns>        
        public JsonResult rejactedCWRID(string CWRID, string Month)
        {
            DateTime oDate = Convert.ToDateTime(Month);
            int x = this.EmpRegisterService.rejactedCWRIDData(CWRID, oDate);
            
            return null;
        }

        public List<Dictionary<string, object>> GetTableRows(DataTable dtData)
        {
            List<Dictionary<string, object>>
            lstRows = new List<Dictionary<string, object>>();
            Dictionary<string, object> dictRow = null;

            foreach (DataRow dr in dtData.Rows)
            {
                dictRow = new Dictionary<string, object>();
                foreach (DataColumn col in dtData.Columns)
                {
                    dictRow.Add(col.ColumnName, dr[col]);
                }
                lstRows.Add(dictRow);
            }
            return lstRows;
        }


    }
}