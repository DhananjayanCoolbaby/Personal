using CWR.DataService.DBConnection;
using CWR.Entity;
using CWR.Repository;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWR.DataService
{

    public class AdminDataService : IAdminRepository
    {
        /// <summary>
        /// The Get Vendors List method
        /// </summary>
        /// <returns>return list</returns>        
        public IList<State> GetState()
        {

            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            List<State> olist = null;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("GetState");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                //Parameters

                using (IDataReader databaseReader = sqlConn.ExecuteReader(databaseCommand))
                {
                    olist = new List<State>();
                    while (databaseReader.Read())
                    {
                        State oState = CreateObject.GetObject<State>();
                        oState.ID = Convert.ToInt32(databaseReader["id"]);
                        oState.Name = Convert.ToString(databaseReader["Name"]);
                        olist.Add(oState);

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
        public IList<Position> GetPosition()
        {

            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            List<Position> olist = null;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("GetPosition");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                //Parameters

                using (IDataReader databaseReader = sqlConn.ExecuteReader(databaseCommand))
                {
                    olist = new List<Position>();
                    while (databaseReader.Read())
                    {
                        Position oPosition = CreateObject.GetObject<Position>();
                        oPosition.ID = Convert.ToInt32(databaseReader["id"]);
                        oPosition.Name = Convert.ToString(databaseReader["Name"]);
                        olist.Add(oPosition);

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
        /// The Save Multi Point of contact Details method
        /// </summary>
        /// <param name="Username">The Username parameter</param>
        /// <param name="Name">The Name parameter</param>
        /// <param name="JoiningDate">The point of JoiningDate parameter</param>
        /// <param name="Position">The point of Contact Name parameter</param>
        /// <param name="FatherName">The point of FatherName Id parameter</param>
        /// <param name="DOB">The point of Contact parameter</param>
        /// <param name="Address">The facility Id parameter</param>
        /// <param name="MobileNo">The createdBy parameter</param>
        ///   <param name="Gender">The createdBy parameter</param>
        ///   <param name="Email">The createdBy parameter</param>
        ///   <param name="State">The createdBy parameter</param>
        ///   <param name="Postcode">The createdBy parameter</param>
        ///   <param name="Reporting">The createdBy parameter</param>
        /// <returns>The integer type object</returns>
        public int SaveCWRData(string Username, string Password, string koneEmail, string Reporting, string Vendor,
        string Position, string FName, string LName, string DOB, string FatherName, string MobileNo, string Gender, string Address, string CityorTown, string State,
            string Remarks, string PersonalEmail, string EmergencycontactNo, string Employeeid, string JoiningDate, string Reportingdate, string EmployeerEmailAddress)
        {
            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            int result = 0;
            string emergencyContactName="Cool";
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_SaveCWRData");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                sqlConn.AddInParameter(databaseCommand, "@Username", SqlDbType.VarChar, Username);
                sqlConn.AddInParameter(databaseCommand, "@Password", SqlDbType.VarChar, Password);
                sqlConn.AddInParameter(databaseCommand, "@koneEmail", SqlDbType.VarChar, koneEmail);
                sqlConn.AddInParameter(databaseCommand, "@Reporting", SqlDbType.VarChar, Reporting);
                sqlConn.AddInParameter(databaseCommand, "@Vendor", SqlDbType.VarChar, Vendor);
                sqlConn.AddInParameter(databaseCommand, "@Position", SqlDbType.VarChar, Position);
                sqlConn.AddInParameter(databaseCommand, "@FName", SqlDbType.VarChar, FName);
                sqlConn.AddInParameter(databaseCommand, "@LName", SqlDbType.VarChar, LName);
                //DateTime jDOB = DateTime.ParseExact(DOB, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                sqlConn.AddInParameter(databaseCommand, "@DOB", SqlDbType.Date, DOB);
                sqlConn.AddInParameter(databaseCommand, "@FatherName", SqlDbType.VarChar, FatherName);
                sqlConn.AddInParameter(databaseCommand, "@MobileNo", SqlDbType.VarChar, MobileNo);
                sqlConn.AddInParameter(databaseCommand, "@Gender", SqlDbType.VarChar, Gender);
                sqlConn.AddInParameter(databaseCommand, "@Address", SqlDbType.VarChar, Address);
                sqlConn.AddInParameter(databaseCommand, "@CityorTown", SqlDbType.VarChar, CityorTown);
                sqlConn.AddInParameter(databaseCommand, "@State", SqlDbType.VarChar, State);
                sqlConn.AddInParameter(databaseCommand, "@Remarks", SqlDbType.VarChar, Remarks);
                sqlConn.AddInParameter(databaseCommand, "@PersonalEmail", SqlDbType.VarChar, PersonalEmail);
                sqlConn.AddInParameter(databaseCommand, "@EmergencycontactNo", SqlDbType.VarChar, EmergencycontactNo);
                sqlConn.AddInParameter(databaseCommand, "@Employeeid", SqlDbType.VarChar, Employeeid);              
              //  DateTime jodate = DateTime.ParseExact(JoiningDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                sqlConn.AddInParameter(databaseCommand, "@JoiningDate", SqlDbType.Date, JoiningDate);
               // DateTime reReportingdate = DateTime.ParseExact(Reportingdate.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                sqlConn.AddInParameter(databaseCommand, "@Reportingdate", SqlDbType.Date, Reportingdate);
                sqlConn.AddInParameter(databaseCommand, "@EmployeerEmailAddress", SqlDbType.VarChar, EmployeerEmailAddress);
                sqlConn.AddInParameter(databaseCommand, "@emergencyContactName", SqlDbType.VarChar, emergencyContactName);
               
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
        public IList<CWRSavedData> GetSavedCWRDetailes()
        {

            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            List<CWRSavedData> olist = null;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_GetSavedCWRData");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                //Parameters

                using (IDataReader databaseReader = sqlConn.ExecuteReader(databaseCommand))
                {
                    olist = new List<CWRSavedData>();
                    while (databaseReader.Read())
                    {
                        CWRSavedData oCWRSavedData = CreateObject.GetObject<CWRSavedData>();
                        oCWRSavedData.UserName = Convert.ToString(databaseReader["UserName"]).ToUpper();
                        oCWRSavedData.Name = Convert.ToString(databaseReader["Name"]);
                        oCWRSavedData.JoiningDate = Convert.ToString(databaseReader["JoiningDate"]);
                        olist.Add(oCWRSavedData);

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
        public IList<CWRSavedDataDetails> FetchDataBasedOnUserName(string Username)
        {

            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            List<CWRSavedDataDetails> olist = null;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_GetSavedCWRDataDetails");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                //Parameters
                sqlConn.AddInParameter(databaseCommand, "@UserName", SqlDbType.VarChar, Username);
                using (IDataReader databaseReader = sqlConn.ExecuteReader(databaseCommand))
                {
                    olist = new List<CWRSavedDataDetails>();
                    while (databaseReader.Read())
                    {
                        CWRSavedDataDetails oCWRSavedData = CreateObject.GetObject<CWRSavedDataDetails>();
                        oCWRSavedData.Username = Convert.ToString(databaseReader["Username"]).ToUpper();
                        oCWRSavedData.Name = Convert.ToString(databaseReader["Name"]);
                        oCWRSavedData.JoiningDate = Convert.ToString(databaseReader["JoiningDate"]);
                        oCWRSavedData.Position = Convert.ToString(databaseReader["Position"]).ToUpper();
                        oCWRSavedData.FatherName = Convert.ToString(databaseReader["FatherName"]);
                        oCWRSavedData.DOB = Convert.ToString(databaseReader["DOB"]);
                        oCWRSavedData.Address = Convert.ToString(databaseReader["Address"]).ToUpper();
                        oCWRSavedData.MobileNo = Convert.ToString(databaseReader["MobileNo"]);
                        oCWRSavedData.Gender = Convert.ToString(databaseReader["Gender"]);
                        oCWRSavedData.Email = Convert.ToString(databaseReader["Email"]).ToUpper();
                        oCWRSavedData.State = Convert.ToString(databaseReader["State"]);
                        oCWRSavedData.Postcode = Convert.ToString(databaseReader["Postcode"]);
                        oCWRSavedData.Reporting = Convert.ToString(databaseReader["Reporting"]).ToUpper();
                        oCWRSavedData.UserLevel = Convert.ToString(databaseReader["UserLevel"]);
                        oCWRSavedData.Password = Convert.ToString(databaseReader["Password"]);
                        olist.Add(oCWRSavedData);

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
        /// The CheckUsernamesAvailability method
        /// </summary>
        /// <param name="UserName">The UserName parameter</param>
        /// <returns>The boolean type object</returns>        
        public bool CheckUsernamesAvailability(string UserName)
        {
            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_CheckUsernamesAvailability");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                ////Parameter    
                sqlConn.AddInParameter(
                    databaseCommand, "@UserName", SqlDbType.VarChar, UserName);
                int count = (int)sqlConn.ExecuteScalar(databaseCommand);
                if (count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
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
        public IList<Reporting> GetReportingDetiles()
        {

            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            List<Reporting> olist = null;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_GetReporting");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                //Parameters

                using (IDataReader databaseReader = sqlConn.ExecuteReader(databaseCommand))
                {
                    olist = new List<Reporting>();
                    while (databaseReader.Read())
                    {
                        Reporting oReporting = CreateObject.GetObject<Reporting>();
                        oReporting.ReportingID = Convert.ToInt32(databaseReader["id"]);
                        oReporting.ReportingName = Convert.ToString(databaseReader["Name"]);
                        olist.Add(oReporting);

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
        public IList<Vendor> GetVendorDetiles()
        {

            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            List<Vendor> olist = null;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_GetVendorDetiles");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                //Parameters

                using (IDataReader databaseReader = sqlConn.ExecuteReader(databaseCommand))
                {
                    olist = new List<Vendor>();
                    while (databaseReader.Read())
                    {
                        Vendor oVendor = CreateObject.GetObject<Vendor>();
                        oVendor.ID = Convert.ToInt32(databaseReader["id"]);
                        oVendor.Name = Convert.ToString(databaseReader["Name"]);
                        olist.Add(oVendor);

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

    }
}
