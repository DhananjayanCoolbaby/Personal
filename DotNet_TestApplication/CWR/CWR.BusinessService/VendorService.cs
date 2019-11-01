namespace CWR.BusinessService
{
    using CWR.Entity;
    using CWR.Repository;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class VendorService:IVendorService
    {
        private IVendorRepository VendorRepository = null;
        /// <summary>
        /// Initializes a new instance of the <see cref="CartDetailsService" /> class.
        /// </summary>
        /// <param name="cartDetailsRepository">The cartDetailsRepository parameter</param>        
         public VendorService(IVendorRepository oVendorRepository)
        {
            this.VendorRepository = oVendorRepository;
        }

         /// <summary>
         /// The GetState method
         /// </summary>
         /// <returns>return list</returns>        
         public int SaveVendorData(string Vendorname, string VendorEmail, string VendorContactNO, int VendorID)
         {
             ////return object
             return this.VendorRepository.SaveVendorData(Vendorname, VendorEmail, VendorContactNO, VendorID);
         }

         /// <summary>
         /// The GetState method
         /// </summary>
         /// <returns>return list</returns>        
         public IList<VendorDetails> GetSavedVendorDetailes()
         {
             ////return object
             return this.VendorRepository.GetSavedVendorDetailes();
         }


         /// <summary>
         /// The GetState method
         /// </summary>
         /// <returns>return list</returns>        
         public IList<VendorDetails> FetchDataBasedOnVendorID(string VendorID)
         {
             ////return object
             return this.VendorRepository.FetchDataBasedOnVendorID(VendorID);
         }

         /// The SaveCWRData  method
         /// </summary>
         /// <returns>return int</returns> 
         public int GetGetVendorID()
         {
             ////return object
             return this.VendorRepository.GetGetVendorID();
         }

         public int DeleteVendorDetails(int vendorID)
         {
             return 0;
             ////return object
            // return this.VendorRepository.DeleteVendorDetails(vendorID);
         }
        
    }
}
