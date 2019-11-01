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

    public class ReportingDataService : IReportingRepository
    {
        /// <summary>
        /// The Save Multi Point of contact Details method
        /// </summary>
        /// <param name="Username">The Username parameter</param>
        /// <param name="Name">The Name parameter</param>
        /// <param name="JoiningDate">The point of JoiningDate parameter</param>
        /// <returns>The integer type object</returns>
        public int SaveReporterData(string Reportername, string ReporterEmail, string ReporterContactNO, int ReporterID, string ReporterUsername, string ReporterPassword, string costcentername)
        {
            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            int result = 0;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_SaveReporterData");
                sqlConn.AddInParameter(databaseCommand, "@ReporterID", SqlDbType.VarChar, ReporterID);
                databaseCommand.CommandType = CommandType.StoredProcedure;
                sqlConn.AddInParameter(databaseCommand, "@Reportername", SqlDbType.VarChar, Reportername);
                sqlConn.AddInParameter(databaseCommand, "@ReporterContactNO", SqlDbType.VarChar, ReporterContactNO);
                sqlConn.AddInParameter(databaseCommand, "@ReporterEmail", SqlDbType.VarChar, ReporterEmail);
                sqlConn.AddInParameter(databaseCommand, "@ReporterUsername", SqlDbType.VarChar, ReporterUsername);
                sqlConn.AddInParameter(databaseCommand, "@ReporterPassword", SqlDbType.VarChar, ReporterPassword);
                sqlConn.AddInParameter(databaseCommand, "@costcentername", SqlDbType.VarChar, costcentername);
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
        public IList<ReporterDetails> GetSavedReporterDetailes()
        {

            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            List<ReporterDetails> olist = null;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_GetSavedReporterData");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                //Parameters

                using (IDataReader databaseReader = sqlConn.ExecuteReader(databaseCommand))
                {
                    olist = new List<ReporterDetails>();
                    while (databaseReader.Read())
                    {
                        ReporterDetails oSavedData = CreateObject.GetObject<ReporterDetails>();
                        oSavedData.Reportername = Convert.ToString(databaseReader["Reportername"]).ToUpper();
                        oSavedData.ReporterContactNO = Convert.ToString(databaseReader["ReporterContactNO"]);
                        oSavedData.ReporterID = Convert.ToString(databaseReader["ReporterID"]);
                        oSavedData.ReporterEmail = Convert.ToString(databaseReader["ReporterEmail"]);
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
        public IList<ReporterDetails> FetchDataBasedOnReporter(string ReporterID)
        {

            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            List<ReporterDetails> olist = null;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_FetchDataBasedOnReporterID");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                //Parameters
                sqlConn.AddInParameter(databaseCommand, "@ReporterID", SqlDbType.VarChar, ReporterID);
                using (IDataReader databaseReader = sqlConn.ExecuteReader(databaseCommand))
                {
                    olist = new List<ReporterDetails>();
                    while (databaseReader.Read())
                    {
                        ReporterDetails oSavedData = CreateObject.GetObject<ReporterDetails>();
                        oSavedData.Reportername = Convert.ToString(databaseReader["Reportername"]).ToUpper();
                        oSavedData.ReporterID = Convert.ToString(databaseReader["ReporterID"]).ToUpper();
                        oSavedData.ReporterContactNO = Convert.ToString(databaseReader["ReporterContactNO"]);
                        oSavedData.ReporterEmail = Convert.ToString(databaseReader["ReporterEmail"]);
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


        public int GetReportingID()
        {
            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_GetReportingID");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                ////Parameter   

                int ReportingID = (int)sqlConn.ExecuteScalar(databaseCommand);
                return ReportingID;
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
