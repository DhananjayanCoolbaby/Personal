
namespace CWR.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CWR.Repository;
    using CWR.DataService;
    using Ninject;
    using Ninject.Modules;
    using Ninject.Syntax;

    public class DependencyMapperForDataAccess
    {

        /// <summary>
        /// Load Data Access dependency
        /// </summary>
        /// <param name="ninjectKernel">The inject Kernel parameter</param>
        public void LoadDependency(IBindingRoot ninjectKernel)
        {
            ////Bind business contract to corresponding business service
            ninjectKernel.Bind<IEmpProfilesRepository>().To<EmpProfilesDataService>();
            ninjectKernel.Bind<IEmpTimeSheetRepository>().To<EmpTimeSheetDataService>();
            ninjectKernel.Bind<IAdminRepository>().To<AdminDataService>();
            ninjectKernel.Bind<IEmpRegisterRepository>().To<EmpRegisterDataService>();
            ninjectKernel.Bind<IVendorRepository>().To<VendorDataService>();
            ninjectKernel.Bind<IReportingRepository>().To<ReportingDataService>();

        }
    }
}
