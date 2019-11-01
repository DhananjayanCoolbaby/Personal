

namespace CWR.BusinessService
{
    using CWR.Entity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using CWR.Repository;

    public interface IEmpProfilesService
    {
        /// <summary>
        /// The Associate Id method
        /// </summary>
        /// <param name="vendorName">The Associate Id parameter</param>
        /// <returns>return list</returns>        
        IList<Credential> CheckUserName(string Username, string password);


    }
}
