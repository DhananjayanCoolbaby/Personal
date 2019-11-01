

namespace CWR.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CWR.BusinessService;
    using Ninject;
    using Ninject.Modules;
    using Ninject.Syntax;
 

    public class DependencyMapper
    {

        public void LoadDependency(IBindingRoot ninjectKernel)
        {
            ////Bind business contract to corresponding business service
            ninjectKernel.Bind<IEmpProfilesService>().To<EmpProfilesService>();
            ninjectKernel.Bind<IEmpTimeSheetService>().To<EmpTimeSheetService>();
            ninjectKernel.Bind<IAdminService>().To<AdminService>();
            ninjectKernel.Bind<IEmpRegisterService>().To<EmpRegisterService>();
            ninjectKernel.Bind<IVendorService>().To<VendorService>();
            ninjectKernel.Bind<IReportingService>().To<ReportingService>();

        }
    }
}
