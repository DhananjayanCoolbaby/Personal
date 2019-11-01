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
    public class EmpTimeSheetDataService : IEmpTimeSheetRepository
    {
        /// <summary>
        /// The Get Vendors List method
        /// </summary>
        /// <returns>return list</returns>        
        public IList<TimeSheet> GetDateandDays(String UserName)
        {

            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            List<TimeSheet> DateAndDays = null;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_FillMyTimeSheetDetails");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                //Parameters
                sqlConn.AddInParameter(databaseCommand, "@UserName", SqlDbType.VarChar, @UserName);
                using (IDataReader databaseReader = sqlConn.ExecuteReader(databaseCommand))
                {
                    DateAndDays = new List<TimeSheet>();
                    while (databaseReader.Read())
                    {
                        ///// creating object of UnbudgetedLoad class
                        TimeSheet OTimeSheet = CreateObject.GetObject<TimeSheet>();
                        OTimeSheet.Date = Convert.ToInt32(databaseReader["Date"]);
                        OTimeSheet.Days = Convert.ToString(databaseReader["Days"]);
                        OTimeSheet.DateWorked = Convert.ToString(databaseReader["DateWorked"]);
                        OTimeSheet.TimesheetPeriodid = Convert.ToInt32(databaseReader["TimesheetPeriodid"]);
                        OTimeSheet.RequestId = Convert.ToString(databaseReader["RequestId"]);
                        OTimeSheet.Status = Convert.ToString(databaseReader["Status"]);
                        OTimeSheet.ProjectHoursWorked = Convert.ToString(databaseReader["ProjectHoursWorked"]);
                        DateAndDays.Add(OTimeSheet);
                    }
                }

                return DateAndDays;
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


        public int SaveTimevalueDetails(string date, string ProjectHoursWorked, int TimesheetPeriodid, string AssociateID)
        {

            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            int result = 0;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_SaveProjectHours");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                sqlConn.AddInParameter(databaseCommand, "@CWRID", SqlDbType.VarChar, AssociateID);
                sqlConn.AddInParameter(databaseCommand, "@TimesheetPeriodid", SqlDbType.Int, TimesheetPeriodid);
                sqlConn.AddInParameter(databaseCommand, "@ProjectHoursWorked", SqlDbType.VarChar, ProjectHoursWorked);
                sqlConn.AddInParameter(databaseCommand, "@Status", SqlDbType.Int, 0);
                sqlConn.AddInParameter(databaseCommand, "@DateWorked", SqlDbType.VarChar, date);
                result = sqlConn.ExecuteNonQuery(databaseCommand);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlConn = null;
                databaseCommand = null;
            }
        }

        /// <summary>
        /// The GetDateandDays  method
        /// </summary>
        /// <returns>return list</returns>        
        public int SaveTimeSheetDetails(DataTable DtTimeSheet, string AssociateID)
        {

            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            int result = 0;
            DtTimeSheet.Columns.Remove("RequestId");
            DtTimeSheet.Columns.Remove("AssociateID");
            DtTimeSheet.Columns.Remove("Status");

            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_SubmitTimesheet");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                sqlConn.AddInParameter(databaseCommand, "@dtHoursworked", SqlDbType.Structured, DtTimeSheet);
                sqlConn.AddInParameter(databaseCommand, "@createdBy", SqlDbType.VarChar, AssociateID);
                result = sqlConn.ExecuteNonQuery(databaseCommand);
                return result;
            }
            catch (Exception)
            {
                throw;
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
        public IList<LegendDetails> FetchLegendDetails()
        {

            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            List<LegendDetails> oLegendDetails = null;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_FetchLegendDetails");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                //Parameters

                using (IDataReader databaseReader = sqlConn.ExecuteReader(databaseCommand))
                {
                    oLegendDetails = new List<LegendDetails>();
                    while (databaseReader.Read())
                    {
                        ///// creating object of UnbudgetedLoad class
                        LegendDetails oLegendDetail = CreateObject.GetObject<LegendDetails>();
                        oLegendDetail.LegendName = Convert.ToString(databaseReader["LegendName"]);
                        oLegendDetail.LegendShortName = Convert.ToString(databaseReader["LegendShortName"]);
                        oLegendDetails.Add(oLegendDetail);
                    }
                }

                return oLegendDetails;
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
        public IList<TimeSheetSaveedData> GetSavedTimeSheetDetailes(string AssociateId)
        {

            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            List<TimeSheetSaveedData> DateAndDays = null;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_GetSavedTimeSheetDetailes");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                //Parameters
                sqlConn.AddInParameter(databaseCommand, "@UserName", SqlDbType.VarChar, @AssociateId);
                using (IDataReader databaseReader = sqlConn.ExecuteReader(databaseCommand))
                {
                    DateAndDays = new List<TimeSheetSaveedData>();
                    while (databaseReader.Read())
                    {
                        ///// creating object of UnbudgetedLoad class
                        TimeSheetSaveedData OTimeSheet = CreateObject.GetObject<TimeSheetSaveedData>();
                        OTimeSheet.CWRID = Convert.ToString(databaseReader["CWRID"]);
                        OTimeSheet.EndDate = Convert.ToDateTime(databaseReader["EndDate"]).ToString("dd-MM-yyyy");
                        OTimeSheet.RequestId = Convert.ToString(databaseReader["RequestId"]);
                        OTimeSheet.Status = Convert.ToString(databaseReader["Status"]);
                        OTimeSheet.CreatedDate = Convert.ToString(databaseReader["CreatedDate"]);
                        DateAndDays.Add(OTimeSheet);
                    }
                }

                return DateAndDays;
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


        public IList<TimeSheet> FetchDataBasedOnRequestId(string AssociateId, string RequestId)
        {

            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            List<TimeSheet> DateAndDays = null;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_FetchDataBasedOnRequestId");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                //Parameters
                sqlConn.AddInParameter(databaseCommand, "@UserName", SqlDbType.VarChar, AssociateId);
                sqlConn.AddInParameter(databaseCommand, "@RequestId", SqlDbType.VarChar, RequestId);
                using (IDataReader databaseReader = sqlConn.ExecuteReader(databaseCommand))
                {
                    DateAndDays = new List<TimeSheet>();
                    while (databaseReader.Read())
                    {
                        ///// creating object of UnbudgetedLoad class
                        TimeSheet OTimeSheet = CreateObject.GetObject<TimeSheet>();
                        OTimeSheet.Date = Convert.ToInt32(databaseReader["Date"]);
                        OTimeSheet.Days = Convert.ToString(databaseReader["Days"]);
                        OTimeSheet.DateWorked = Convert.ToString(databaseReader["DateWorked"]);
                        OTimeSheet.TimesheetPeriodid = Convert.ToInt32(databaseReader["TimesheetPeriodid"]);
                        OTimeSheet.RequestId = Convert.ToString(databaseReader["RequestId"]);
                        OTimeSheet.ProjectHoursWorked = Convert.ToString(databaseReader["ProjectHoursWorked"]);
                        OTimeSheet.Status = Convert.ToString((databaseReader["Status"]));
                        DateAndDays.Add(OTimeSheet);
                    }
                }

                return DateAndDays;
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


        public IList<TimeSheet> FetchDataBasedOnDate(string AssociateId, DateTime date)
        {

            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            List<TimeSheet> DateAndDays = null;
            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_FetchDataBasedOnMonth");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                //Parameters
                sqlConn.AddInParameter(databaseCommand, "@UserName", SqlDbType.VarChar, AssociateId);
                sqlConn.AddInParameter(databaseCommand, "@DateandTime", SqlDbType.DateTime, date);
                using (IDataReader databaseReader = sqlConn.ExecuteReader(databaseCommand))
                {
                    DateAndDays = new List<TimeSheet>();
                    while (databaseReader.Read())
                    {
                        /////// creating object of UnbudgetedLoad class
                        TimeSheet OTimeSheet = CreateObject.GetObject<TimeSheet>();
                        OTimeSheet.Date = Convert.ToInt32(databaseReader["Date"]);
                        OTimeSheet.Days = Convert.ToString(databaseReader["Days"]);
                        OTimeSheet.DateWorked = Convert.ToString(databaseReader["DateWorked"]);
                        OTimeSheet.TimesheetPeriodid = Convert.ToInt32(databaseReader["TimesheetPeriodid"]);
                        OTimeSheet.RequestId = Convert.ToString(databaseReader["RequestId"]);
                        OTimeSheet.ProjectHoursWorked = Convert.ToString(databaseReader["ProjectHoursWorked"]);
                        DateAndDays.Add(OTimeSheet);
                    }
                }

                return DateAndDays;
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
