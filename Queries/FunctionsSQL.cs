using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace Querys
{
    class FunctionsSQL
    {
        #region DatabaseStruct
        /// <summary>
        /// نام پایگاه داده و جدول
        /// </summary>
        public struct DatabaseStruct
        {
            #region DataBaseName
            private string _DataBaseName;
            /// <summary>
            /// نام پایگاه اطلاعاتی
            /// </summary>
            public string DataBaseName
            {
                get { return _DataBaseName; }
                set { _DataBaseName = value; }
            }
            #endregion

            #region TableName
            private string _TableName;
            /// <summary>
            /// نام جدول
            /// </summary>
            public string TableName
            {
                get { return _TableName; }
                set { _TableName = value; }
            }
            #endregion
        }


        #endregion


        #region SqlConnection
        public SqlConnection sqlConnection(string server = ".", string user = "", string pass = "", string dbName = "")
        {
            string strconn, strdbName;


            //  set data base name
            if (dbName == "") { strdbName = "master"; } else { strdbName = dbName; }


            // create connection string
            if (user != "" && pass != "")
            { strconn = "Data Source=" + server + ";Initial Catalog=" + strdbName + ";Persist Security Info=True;User ID=" + user + ";Password=" + pass; }

            else strconn = "Data Source=.;Initial Catalog=" + strdbName + ";Integrated Security=True;Connect Timeout=5";


            SqlConnection sqlConn = new SqlConnection(strconn);
            return sqlConn;
        }
        #endregion


        #region sqlExcutCommand
        public bool sqlExcutCommand(string Query, string Server)
        {

            ServerConnection svrConn = new ServerConnection(sqlConnection(Server));
            Server srtserver = new Server(svrConn);

            srtserver.ConnectionContext.ExecuteNonQuery(Query);

            return true;

        }


        public string sqlExcutCommand(string Query, SqlConnection sqlConnection,string strState="")
        {
            SqlCommand cmd = new SqlCommand(Query, sqlConnection);
            try
            {
                // conection timeoute
                cmd.CommandTimeout = 3600;

                // execute query
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }

                return "انجام شد";
            }

            catch (Exception) { return strState; }


        }

        #endregion


        #region sqlGetDBName
        /// <summary>
        /// بر روی سیستم SQL لیستی شامل تمام پایگاه  داده های
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable sqlGetDBName(string server, string dbname = "master")
        {
            string qry = "SELECT name FROM sys.databases WHERE database_id>0 order by name";
            DataTable dt = sqlDataAdapter(qry, server, dbname);
            return dt;
        }

        public DataTable sqlGetDBName(SqlConnection sqlConnection)
        {
            string qry = "SELECT name FROM sys.databases WHERE database_id>0 order by name";
            DataTable dt = sqlDataAdapter(qry, sqlConnection);
            return dt;
        }

        #endregion


        #region sqlDataAdapter

        public DataTable sqlDataAdapter(string query, string server, string DBName = "master", string stat = "sqldataadapter")
        {
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection(server));
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                if (stat != "sqldataadapter")
                    MessageBox.Show(stat + Environment.NewLine + e.Message, "خطا");
                return dt;
            }
        }

        public DataTable sqlDataAdapter(string query, SqlConnection sqlConnection, string stat = "sqlDataAdapter")
        {
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                if (stat != "sqlDataAdapter")
                    MessageBox.Show(stat + Environment.NewLine + e.Message, "خطا");
                return dt;
            }
        }


        #endregion


        #region بوسیله نام پایگاه داده
        /// <summary>
        /// لیستی شامل جداول موجود در پایگاه داده انتخاب شده 
        /// </summary>
        /// <param name="DBName">نام پایگاه داده</param>
        /// <returns>جدول نام جداول موجود در پایگاه داده</returns>
        public DataTable sqlGetTableNameInDB(string server, string DBName = "master")
        {
            string Query = " SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' GROUP BY TABLE_NAME";
            DataTable dt = sqlDataAdapter(Query, server, DBName);
            return dt;
        }
        #endregion

        #region sqlColumnsName
        /// <summary>
        /// لیست نام ستون های جدول
        /// </summary>
        /// <param name="Database">ساختار پایگاه داده</param>
        /// <returns>DataTable</returns>
        public DataTable sqlColumnsName(DatabaseStruct DBStruct, string server)
        {
            string Query = "SELECT COLUMN_NAME as 'نام ستون' FROM INFORMATION_SCHEMA.COLUMNS " + "WHERE TABLE_NAME = '";
            return sqlDataAdapter(Query, server);
        }

        public DataTable sqlColumnsName(string DBName, string TblName, string server)
        {
            string Query = "SELECT COLUMN_NAME as 'نام ستون' FROM INFORMATION_SCHEMA.COLUMNS " + "WHERE TABLE_NAME = N'" + TblName + "'";
            return sqlDataAdapter(Query, server);
        }

        public DataTable sqlcolumnsname(string DBName, string TblName, string server, string Where = "")
        {
            if (Where == "")
            {
                string Query = "SELECT COLUMN_NAME  as 'نام ستون' FROM INFORMATION_SCHEMA.COLUMNS " + "WHERE TABLE_NAME = N'" + TblName + "'";
                return sqlDataAdapter(Query, server);
            }
            else
            {
                string Query = "SELECT COLUMN_NAME  as 'نام ستون' FROM INFORMATION_SCHEMA.COLUMNS " + "WHERE TABLE_NAME = N'" + TblName + "' and COLUMN_NAME like 'N%" + Where + "%'";                
                return sqlDataAdapter(Query, server);
            }
        }
        
        public DataTable sqlColumnsNameCLB(DatabaseStruct DBStruct, string server)
        {
            string Query = "SELECT COLUMN_NAME+'  [' + DATA_TYPE + ']' as 'نام ستون' FROM INFORMATION_SCHEMA.COLUMNS " + "WHERE TABLE_NAME = N'" + DBStruct.TableName + "'";
            return sqlDataAdapter(Query, server);
        }

        public DataTable sqlColumnsNameCLB(string DBName, string TblName, string server)
        {
            string Query = "SELECT COLUMN_NAME + '  [' + DATA_TYPE + ']' as 'نام ستون' FROM INFORMATION_SCHEMA.COLUMNS " + "WHERE TABLE_NAME = N'" + TblName + "'";
            return sqlDataAdapter(Query, server);
        }

        public DataTable sqlColumnsNameCLBNew(DatabaseStruct DBStruct, string server)
        {
            string Query = "SELECT TABLE_NAME,COLUMN_NAME,IS_NULLABLE,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH FROM [" + DBStruct + "].INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME=N'" + DBStruct.TableName + "'";
            return sqlDataAdapter(Query, server);
        }
        
        public DataTable sqlColumnsNameCLBNew(string DBName, string TBName, string server)
        {
            string Query = "SELECT TABLE_NAME,COLUMN_NAME,IS_NULLABLE,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH FROM [" + DBName + "].INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME=N'" + TBName + "'";
            return sqlDataAdapter(Query, server);
        }
        #endregion

        #region GetTableNameInDB
        /// <summary>
        /// لیستی شامل جداول موجود در پایگاه داده انتخاب شده 
        /// </summary>
        /// <param name="DBStruct">ساختار داده ای پایگاه داده</param>
        /// <returns>جدول نام جداول موجود در پایگاه داده</returns>
        public DataTable sqlGetTableNameInDB(DatabaseStruct DBStruct, string server)
        {
            string Query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES GROUP BY TABLE_NAME";
            DataTable dt = sqlDataAdapter(Query, server);
            return dt;
        }


        public DataTable sqlGetTableNameInDB(SqlConnection sqlConnection)
        {

            string Query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES GROUP BY TABLE_NAME";
            DataTable dt = sqlDataAdapter(Query, sqlConnection);
            return dt;
        }


        #endregion



        #region RecoredCount
        public int sqlcount(string query, string server)
        {
            SqlCommand cmd = new SqlCommand(query, sqlConnection(server));
            int count;
            cmd.Connection.Open();
            cmd.CommandTimeout = 3600;
            count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return count;
        }
        public int sqlCount(string query, string server)
        {
            SqlCommand cmd = new SqlCommand(query, sqlConnection(server));
            int count;
            cmd.Connection.Open();
            count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return count;
        }
        //public int sqlcountTB(string TBName,string DBName) 
        //{
        //    string query = "select * from "+DBName+".dbo.["+TBName+"]";
        //}
        #endregion


        #region SqlConnectionChangeDB


        public SqlConnection SqlConnectionChangeDB(SqlConnection sqlConnection, string newDB)
        {
            sqlConnection.Close();

            SqlConnection sqlConn = new SqlConnection(sqlConnection.ConnectionString.Replace(sqlConnection.Database, newDB));

            return sqlConn;
        }


        #endregion



    }
}
