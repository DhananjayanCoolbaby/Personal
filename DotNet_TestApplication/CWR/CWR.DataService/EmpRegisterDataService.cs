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
    public class EmpRegisterDataService : IEmpRegisterRepository
    {
        /// <summary>
        /// The Get Vendors List method
        /// </summary>
        /// <returns>return list</returns>        
        /// 
        public string NonBlankValueOf(string strTestString)
        {
            if (String.IsNullOrEmpty(strTestString))
                return "NA";
            else
                return strTestString;
        }
        public IList<CWRRegisterDetails> GetAllCWRRegisterDetails()
        {
           

            List<CWRRegisterDetails> olist = null;


            try
            {

                DbProviderFactory factory =
           DbProviderFactories.GetFactory("System.Data.SqlClient");
                DbConnection connection = factory.CreateConnection();
                connection.ConnectionString = ConnectionInfo.GetConnectionString;

                DataTable table = new DataTable();
                using (connection)
                {
                    string queryString = "TS_GetAllCWREmpRegisterDetails";
                    // Create the DbCommand.
                    DbCommand command = factory.CreateCommand();
                    command.CommandText = queryString;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    // Create the DbDataAdapter.
                    DbDataAdapter adapter = factory.CreateDataAdapter();
                    adapter.SelectCommand = command;
                    // Fill the DataTable.
                    adapter.Fill(table);
                    olist = new List<CWRRegisterDetails>();
                    foreach (DataRow row in table.Rows)
                    {
                        CWRRegisterDetails oCWRRegisterDetails = CreateObject.GetObject<CWRRegisterDetails>();


                        oCWRRegisterDetails.CWRID = (row["Date"].ToString() ?? string.Empty);
                        oCWRRegisterDetails.first = NonBlankValueOf(row["1"].ToString());
                        oCWRRegisterDetails.second = NonBlankValueOf(row["2"].ToString());
                        oCWRRegisterDetails.third = NonBlankValueOf(row["3"].ToString());
                        oCWRRegisterDetails.fourth = NonBlankValueOf(row["4"].ToString());
                        oCWRRegisterDetails.fifth = NonBlankValueOf(row["5"].ToString());
                        oCWRRegisterDetails.sixth = NonBlankValueOf(row["6"].ToString());
                        oCWRRegisterDetails.seventh = NonBlankValueOf(row["7"].ToString());
                        oCWRRegisterDetails.eighth = NonBlankValueOf(row["8"].ToString());
                        oCWRRegisterDetails.ninth = NonBlankValueOf(row["9"].ToString());
                        oCWRRegisterDetails.tenth = NonBlankValueOf(row["10"].ToString());
                        oCWRRegisterDetails.eleventh = NonBlankValueOf(row["11"].ToString());
                        oCWRRegisterDetails.twelfth = NonBlankValueOf(row["12"].ToString());
                        oCWRRegisterDetails.thirteenth = NonBlankValueOf(row["13"].ToString());
                        oCWRRegisterDetails.fourteenth = NonBlankValueOf(row["14"].ToString());
                        oCWRRegisterDetails.fifteenth = NonBlankValueOf(row["15"].ToString());
                        oCWRRegisterDetails.sixteenth = NonBlankValueOf(row["16"].ToString());
                        oCWRRegisterDetails.seventeenth = NonBlankValueOf(row["17"].ToString());
                        oCWRRegisterDetails.eighteenth = NonBlankValueOf(row["18"].ToString());
                        oCWRRegisterDetails.nineteenth = NonBlankValueOf(row["19"].ToString());
                        oCWRRegisterDetails.twentieth = NonBlankValueOf(row["20"].ToString());
                        oCWRRegisterDetails.twentyfirst = NonBlankValueOf(row["21"].ToString());
                        oCWRRegisterDetails.twentysecond = NonBlankValueOf(row["22"].ToString());
                        oCWRRegisterDetails.twentythird = NonBlankValueOf(row["23"].ToString());
                        oCWRRegisterDetails.twentyfourth = NonBlankValueOf(row["24"].ToString());
                        oCWRRegisterDetails.twentyfifth = NonBlankValueOf(row["25"].ToString());
                        oCWRRegisterDetails.twentysixth = NonBlankValueOf(row["26"].ToString());
                        oCWRRegisterDetails.twentyseventh = NonBlankValueOf(row["27"].ToString());
                        oCWRRegisterDetails.twentyeighth = NonBlankValueOf(row["28"].ToString());
                        oCWRRegisterDetails.twentyninth = NonBlankValueOf(row["29"].ToString());
                        oCWRRegisterDetails.thirtieth = NonBlankValueOf(row["30"].ToString());
                        oCWRRegisterDetails.thirtyfirst = NonBlankValueOf(row["31"].ToString());
                        olist.Add(oCWRRegisterDetails);
                    }

                    return olist;

                }
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

            }
        }
        public List<Dictionary<string, object>> Getvalue()
        {

            List<CWRRegisterDetails> olist = null;
            List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
            try
            {

                DbProviderFactory factory =
           DbProviderFactories.GetFactory("System.Data.SqlClient");

                DbConnection connection = factory.CreateConnection();
                connection.ConnectionString = ConnectionInfo.GetConnectionString;



                using (connection)
                {
                    CWRRegisterDetails oCWRRegisterDetails = CreateObject.GetObject<CWRRegisterDetails>();

                    // Define the query.
                    string queryString = "TS_GetAllCWREmpRegisterDetails";

                    // Create the DbCommand.
                    DbCommand command = factory.CreateCommand();
                    command.CommandText = queryString;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    // Create the DbDataAdapter.
                    DbDataAdapter adapter = factory.CreateDataAdapter();
                    adapter.SelectCommand = command;

                    // Fill the DataTable.
                    DataTable table = new DataTable();
                    adapter.Fill(table);



                    olist = new List<CWRRegisterDetails>();
                    Dictionary<string, object> childRow;
                    foreach (DataRow row in table.Rows)
                    {
                        childRow = new Dictionary<string, object>();
                        foreach (DataColumn col in table.Columns)
                        {
                            childRow.Add(col.ColumnName, row[col]);
                        }
                        parentRow.Add(childRow);
                    }

                }


                return parentRow;
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

            }
        }

        public IList<CWRRegisterDetails> GetMonthDate()
        {
            
           
            List<CWRRegisterDetails> olist = null;
            List<string> parentRow = new List<string>();
            try
            {

                DbProviderFactory factory =
           DbProviderFactories.GetFactory("System.Data.SqlClient");

                DbConnection connection = factory.CreateConnection();
                connection.ConnectionString = ConnectionInfo.GetConnectionString;

                List<string> childRow;
                CWRRegisterDetails oCWRRegisterDetails = CreateObject.GetObject<CWRRegisterDetails>();
                using (connection)
                {


                    // Define the query.
                    string queryString = "TS_GetAllCWREmpRegisterDetails";

                    // Create the DbCommand.
                    DbCommand command = factory.CreateCommand();
                    command.CommandText = queryString;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    // Create the DbDataAdapter.
                    DbDataAdapter adapter = factory.CreateDataAdapter();
                    adapter.SelectCommand = command;

                    // Fill the DataTable.
                    DataTable table = new DataTable();
                    adapter.Fill(table);



                    olist = new List<CWRRegisterDetails>();
                    childRow = new List<string>();


                    foreach (DataColumn col in table.Columns)
                    {
                        childRow.Add(col.ColumnName);
                    }

                    //for (int g = 0; g < childRow.Count; g++)
                    //{
                    //    oCWRRegisterDetails.CWRID = childRow[g].ToString();
                    //}

                    oCWRRegisterDetails.CWRID = childRow[0].ToString();
                    oCWRRegisterDetails.first = childRow[1].ToString();
                    oCWRRegisterDetails.second = childRow[2].ToString();
                    oCWRRegisterDetails.third = childRow[3].ToString();
                    oCWRRegisterDetails.fourth = childRow[4].ToString();
                    oCWRRegisterDetails.fifth = childRow[5].ToString();
                    oCWRRegisterDetails.sixth = childRow[6].ToString();
                    oCWRRegisterDetails.seventh = childRow[7].ToString();
                    oCWRRegisterDetails.eighth = childRow[8].ToString();
                    oCWRRegisterDetails.ninth = childRow[9].ToString();
                    oCWRRegisterDetails.tenth = childRow[10].ToString();
                    oCWRRegisterDetails.eleventh = childRow[11].ToString();
                    oCWRRegisterDetails.twelfth = childRow[12].ToString();
                    oCWRRegisterDetails.thirteenth = childRow[13].ToString();
                    oCWRRegisterDetails.fourteenth = childRow[14].ToString();
                    oCWRRegisterDetails.fifteenth = childRow[15].ToString();
                    oCWRRegisterDetails.sixteenth = childRow[16].ToString();
                    oCWRRegisterDetails.seventeenth = childRow[17].ToString();
                    oCWRRegisterDetails.eighteenth = childRow[18].ToString();
                    oCWRRegisterDetails.nineteenth = childRow[19].ToString();
                    oCWRRegisterDetails.twentieth = childRow[20].ToString();
                    oCWRRegisterDetails.twentyfirst = childRow[21].ToString();
                    oCWRRegisterDetails.twentysecond = childRow[22].ToString();
                    oCWRRegisterDetails.twentythird = childRow[23].ToString();
                    oCWRRegisterDetails.twentyfourth = childRow[24].ToString();
                    oCWRRegisterDetails.twentyfifth = childRow[25].ToString();
                    oCWRRegisterDetails.twentysixth = childRow[26].ToString();
                    oCWRRegisterDetails.twentyseventh = childRow[27].ToString();
                    oCWRRegisterDetails.twentyeighth = childRow[28].ToString();
                    oCWRRegisterDetails.twentyninth = childRow[29].ToString();
                    oCWRRegisterDetails.thirtieth = childRow[30].ToString();
                    oCWRRegisterDetails.thirtyfirst = childRow[31].ToString();
                    olist.Add(oCWRRegisterDetails);

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
               
            }
        }

        /// <summary>
        /// The rejactedCWRIDData  method
        /// </summary>
        /// <returns>return list</returns>        
        public int rejactedCWRIDData(String CWRID, DateTime Month)
        {

            SqlDatabase sqlConn;
            DbCommand databaseCommand;
            int result = 0;


            try
            {
                sqlConn = new SqlDatabase(ConnectionInfo.GetConnectionString);
                databaseCommand = sqlConn.GetStoredProcCommand("TS_rejactedCWRIDData");
                databaseCommand.CommandType = CommandType.StoredProcedure;
                sqlConn.AddInParameter(databaseCommand, "@CWRID", SqlDbType.VarChar, CWRID);
                sqlConn.AddInParameter(databaseCommand, "@Month", SqlDbType.DateTime, Month);
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


    }
}
