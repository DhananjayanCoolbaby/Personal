

namespace CWR.Web.Controllers
{
    using CWR.BusinessService;
    using CWR.Entity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        AssociateDetail associate = new AssociateDetail();
        private IEmpProfilesService empProfilesService = null;

        public HomeController(IEmpProfilesService procurementService)
        {
            this.empProfilesService = procurementService;
        }

        public ActionResult Index()
        {
           
            string UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
            string[] SplUserName = UserName.Split('\\');
            associate.AssociateId = SplUserName[1].ToString();
            //HttpContext.Session["associateDetails"] = associate;
            this.ViewBag.associateDetails = associate;
            return View();
        }

        public JsonResult CheckUserName(string Username, string password)
        {


            IList<Credential> oCredential = this.empProfilesService.CheckUserName(Username, password);
            JsonResult dataResult = new JsonResult();
            dataResult.Data = oCredential;
            associate.AssociateId = Username;
            if (oCredential.Count>0)
            {
                associate.UserRole = oCredential[0].Userlevel.ToString();
            }
           
            HttpContext.Session["associateDetails"] = associate;
            return dataResult;

        }
    }
}