using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CWR.Repository;
using CWR.Entity;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using CWR.DataService.DBConnection;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
namespace CWR.DataService
{
    public class EmpProfilesDataService : IEmpProfilesRepository
    {
        /// <summary>
        /// The Get Vendors List method
        /// </summary>
        /// <returns>return list</returns>        
        public IList<Credential> CheckUserName(string Username, string password)
        {
            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            List<Credential> oCredential = null;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_Checkcredential");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                sqlConn.AddInParameter(
                  databaseCommand, "@Username", SqlDbType.VarChar, Username);
                sqlConn.AddInParameter(
                  databaseCommand, "@password", SqlDbType.VarChar, password);
                using (IDataReader databaseReader = sqlConn.ExecuteReader(databaseCommand))
                {
                    oCredential = new List<Credential>();
                    while (databaseReader.Read())
                    {
                        ///// creating object of UnbudgetedLoad class
                        Credential objCredential = CreateObject.GetObject<Credential>();
                        objCredential.Userlevel = Convert.ToString(databaseReader["Userlevel"]);
                        objCredential.Access = Convert.ToInt32(databaseReader["UserName"]);                   

                        oCredential.Add(objCredential);
                    }
                }

                return oCredential;
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
