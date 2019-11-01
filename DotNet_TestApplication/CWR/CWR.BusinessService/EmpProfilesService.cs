
namespace CWR.BusinessService
{

    using CWR.Entity;
    using CWR.Repository;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EmpProfilesService : IEmpProfilesService
    {
        private IEmpProfilesRepository empProfilesRepository = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CartDetailsService" /> class.
        /// </summary>
        /// <param name="cartDetailsRepository">The cartDetailsRepository parameter</param>        
        public EmpProfilesService(IEmpProfilesRepository cartDetailsRepository)
        {
            this.empProfilesRepository = cartDetailsRepository;
        }

        /// <summary>
        /// get count
        /// </summary>
        /// <param name="associateId">associate Id</param>
        /// <returns>get the count</returns>
        public IList<Credential> CheckUserName(string Username, string password)
        {

            return this.empProfilesRepository.CheckUserName(Username, password);
            ////return countSP

        }
    }
}
