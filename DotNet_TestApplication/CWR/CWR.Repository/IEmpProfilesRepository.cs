using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CWR.Entity;
namespace CWR.Repository
{
    public interface IEmpProfilesRepository
    {
        /// <summary>
        /// The FetchCurrentVendorDetails method
        /// </summary>
        /// <param name="vendorId">The vendorId parameter</param>
        /// <returns>return list</returns>        
        IList<Credential> CheckUserName(string Username, string password);
    }
}
