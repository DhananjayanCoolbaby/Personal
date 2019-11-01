﻿using CWR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWR.Repository
{
    public interface IVendorRepository
    {
        /// The SaveCWRData  method
        /// </summary>
        /// <returns>return int</returns> 
        int SaveVendorData(string Vendorname, string VendorEmail, string VendorContactNO, int VendorID);

        /// <summary>
        /// The GetDateandDays  method
        /// </summary>
        /// <returns>return list</returns>        
        IList<VendorDetails> GetSavedVendorDetailes();

        /// <summary>
        /// The GetDateandDays  method
        /// </summary>
        /// <returns>return list</returns>        
        IList<VendorDetails> FetchDataBasedOnVendorID(string vendorID);

        /// The SaveCWRData  method
        /// </summary>
        /// <returns>return int</returns> 
        int GetGetVendorID();
    }
}
