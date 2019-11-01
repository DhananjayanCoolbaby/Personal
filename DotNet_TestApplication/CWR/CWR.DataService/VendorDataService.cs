using CWR.DataService.DBConnection;
using CWR.Entity;
using CWR.Repository;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWR.DataService
{

    public class VendorDataService : IVendorRepository
    {
        /// <summary>
        /// The Save Multi Point of contact Details method
        /// </summary>
        /// <param name="Username">The Username parameter</param>
        /// <param name="Name">The Name parameter</param>
        /// <param name="JoiningDate">The point of JoiningDate parameter</param>
        /// <returns>The integer type object</returns>
        public int SaveVendorData(string Vendorname, string VendorEmail, string VendorContactNO,int VendorID)
        {
            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            int result = 0;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_SaveVendorData");
                sqlConn.AddInParameter(databaseCommand, "@VendorID", SqlDbType.Int, VendorID);
                databaseCommand.CommandType = CommandType.StoredProcedure;
                sqlConn.AddInParameter(databaseCommand, "@Vendorname", SqlDbType.VarChar, Vendorname);
                sqlConn.AddInParameter(databaseCommand, "@VendorContactNO", SqlDbType.VarChar, VendorContactNO);
                sqlConn.AddInParameter(databaseCommand, "@VendorEmail", SqlDbType.VarChar, VendorEmail);
                result = sqlConn.ExecuteNonQuery(databaseCommand);
                return result;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConn = null;
                databaseCommand = null;
            }
        }

        /// <summary>
        /// The Get Vendors List method
        /// </summary>
        /// <returns>return list</returns>        
        public IList<VendorDetails> GetSavedVendorDetailes()
        {

            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            List<VendorDetails> olist = null;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_GetSavedVendorData");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                //Parameters

                using (IDataReader databaseReader = sqlConn.ExecuteReader(databaseCommand))
                {
                    olist = new List<VendorDetails>();
                    while (databaseReader.Read())
                    {
                        VendorDetails oSavedData = CreateObject.GetObject<VendorDetails>();
                        oSavedData.Vendorname = Convert.ToString(databaseReader["Vendorname"]).ToUpper();
                        oSavedData.VendorContactNO = Convert.ToString(databaseReader["VendorContactNO"]);
                        oSavedData.VendorID = Convert.ToInt32(databaseReader["VendorID"]);
                        oSavedData.VendorEmail = Convert.ToString(databaseReader["VendorEmail"]);
                        olist.Add(oSavedData);

                    }
                }

                return olist;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConn = null;
                databaseCommand = null;
            }
        }


        /// <summary>
        /// The Get Vendors List method
        /// </summary>
        /// <returns>return list</returns>        
        public IList<VendorDetails> FetchDataBasedOnVendorID(string VendorID)
        {

            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            List<VendorDetails> olist = null;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_FetchDataBasedOnVendorID");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                //Parameters
                sqlConn.AddInParameter(databaseCommand, "@VendorID", SqlDbType.VarChar, VendorID);
                using (IDataReader databaseReader = sqlConn.ExecuteReader(databaseCommand))
                {
                    olist = new List<VendorDetails>();
                    while (databaseReader.Read())
                    {
                        VendorDetails oSavedData = CreateObject.GetObject<VendorDetails>();
                        oSavedData.Vendorname = Convert.ToString(databaseReader["Vendorname"]).ToUpper();
                        oSavedData.VendorID = Convert.ToInt32(databaseReader["VendorID"]);
                        oSavedData.VendorContactNO = Convert.ToString(databaseReader["VendorContactNO"]);
                        oSavedData.VendorEmail = Convert.ToString(databaseReader["VendorEmail"]);
                        olist.Add(oSavedData);

                    }
                }

                return olist;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConn = null;
                databaseCommand = null;
            }
        }


        public int GetGetVendorID()
        {
            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_GetVendorID");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                ////Parameter   
               
                int VendorID = (int)sqlConn.ExecuteScalar(databaseCommand);
                return VendorID;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConn = null;
                databaseCommand = null;
            }
        }

        public int DeleteVendorDetails (int VendorID )
        {
            SqlDatabase sqlConn;
            DbCommand databaseCommand;

            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("need to write a SP for Delete");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                ////Parameter   

                int deletedID = (int)sqlConn.ExecuteScalar(databaseCommand);
                return deletedID;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConn = null;
                databaseCommand = null;
            }
        }
    }
}
