namespace CWR.BusinessService
{

    using CWR.Entity;
    using CWR.Repository;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EmpRegisterService : IEmpRegisterService
    {
        private IEmpRegisterRepository EmpRegisterRepository = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CartDetailsService" /> class.
        /// </summary>
        /// <param name="cartDetailsRepository">The cartDetailsRepository parameter</param>        
        public EmpRegisterService(IEmpRegisterRepository oEmpRegisterRepository)
        {
            this.EmpRegisterRepository = oEmpRegisterRepository;
        }
        /// <summary>
        /// The GetState method
        /// </summary>
        /// <returns>return list</returns>        
        public IList<CWRRegisterDetails> GetAllCWRRegisterDetails()
        {
            ////return object
            return this.EmpRegisterRepository.GetAllCWRRegisterDetails();
        }

        public List<Dictionary<string, object>> Getvalue()
        {
            return this.EmpRegisterRepository.Getvalue();
        }

        /// <summary>
        /// The GetState method
        /// </summary>
        /// <returns>return list</returns>        
        public IList<CWRRegisterDetails> GetMonthDate()
        {
            ////return object
            return this.EmpRegisterRepository.GetMonthDate();
        }


        /// <summary>
        /// The rejactedCWRIDData  method
        /// </summary>
        /// <returns>return list</returns>        
        public int rejactedCWRIDData(string CWRID, DateTime Month)
        {
            ////return object
            return this.EmpRegisterRepository.rejactedCWRIDData(CWRID, Month);
        }
    }
}
