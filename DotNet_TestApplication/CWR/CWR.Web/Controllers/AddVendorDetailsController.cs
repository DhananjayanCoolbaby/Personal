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
    public class AddVendorDetailsController : BaseController
    {

        private IVendorService VendorService = null;

        public AddVendorDetailsController(IVendorService VendorService)
        {
            this.VendorService = VendorService;
        }
        //
        //
        // GET: /AddVendorDetails/
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// The GetState method
        /// </summary>        
        /// <returns>return list</returns>        
        public int SaveVendorData(string Vendorname, string VendorEmail, string VendorContactNO, int VendorID)
        {

            int OTimeSheet = this.VendorService.SaveVendorData(Vendorname, VendorEmail, VendorContactNO, VendorID);

            return OTimeSheet;
        }

        /// <summary>
        /// The GetSavedCWRDetailes method
        /// </summary>        
        /// <returns>return list</returns>        
        public JsonResult GetSavedVendorDetailes()
        {

            IList<VendorDetails> ovendorData = this.VendorService.GetSavedVendorDetailes();
            JsonResult dataResult = new JsonResult();
            dataResult.Data = ovendorData;
            return Json(dataResult, JsonRequestBehavior.AllowGet);  
          
        }

        /// <summary>
        /// The GetSavedCWRDetailes method
        /// </summary>        
        /// <returns>return list</returns>        
        public JsonResult FetchDataBasedOnVendorID(string VendorID)
        {

            IList<VendorDetails> ovendorData = this.VendorService.FetchDataBasedOnVendorID(VendorID);
            JsonResult dataResult = new JsonResult();
            dataResult.Data = ovendorData;
            return Json(dataResult, JsonRequestBehavior.AllowGet);  
        }


        /// <summary>
        /// The GetSavedCWRDetailes method
        /// </summary>        
        /// <returns>return list</returns>        
        public int GetGetVendorID()
        {

            int VendorID = this.VendorService.GetGetVendorID();

            return VendorID;
        }

        public int DeleteVendorDetails(int VendorID)
        {
             VendorID = this.VendorService.DeleteVendorDetails(VendorID);

            return VendorID;
 
        }
    }
}