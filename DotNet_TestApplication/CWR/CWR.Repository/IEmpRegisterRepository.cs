using CWR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CWR.Repository
{
    public interface IEmpRegisterRepository
    {
        /// <summary>
        /// The GetDateandDays  method
        /// </summary>
        /// <returns>return list</returns>        
        IList<CWRRegisterDetails> GetAllCWRRegisterDetails();

        List<Dictionary<string, object>> Getvalue();

        /// <summary>
        /// The GetMonthDate  method
        /// </summary>
        /// <returns>return list</returns>        
        IList<CWRRegisterDetails> GetMonthDate();


        /// <summary>
        /// The rejactedCWRIDData  method
        /// </summary>
        /// <returns>return list</returns>        
        int rejactedCWRIDData(string CWRID, DateTime Month);
    }
}
