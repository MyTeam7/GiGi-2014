using System;
using System.Data;
using System.Data.SqlClient;
using GiGi.COMMON;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace GiGi.DAL
{
    public class Connection
    {
        private SqlConnection oSqlConnection;
        private SqlTransaction oSqlTransaction;

        //private OracleConnection oOracleConnection;
        //private OracleTransaction oOracleTransaction;

        private MySqlConnection oMySqlConnection;
        private MySqlTransaction oMySqlTransaction;

        private string dbConString = string.Empty;

        private int connType;

        public int ConnType
        {
            get { return connType; }
        }

        private void CreateConnection()
        {
            //DataSet dbConDataSet;
            string dbname = string.Empty;
            string database = string.Empty;
            string dataSource = string.Empty;
            string userID = string.Empty;
            string password = string.Empty;
            string initialCatalog = string.Empty;
            string minPoolSize = string.Empty;
            string maxPoolSize = string.Empty;
            string port = string.Empty;
            string server = string.Empty;
            //SqlConnectionStringBuilder oSqlConnectionStringBuilder;

            try
            {
                StreamReader stream = new StreamReader("dbconfig.xml");

                XmlTextReader reader = null;
                reader = new XmlTextReader(stream);
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "connection"))
                    {
                        if (reader.HasAttributes)
                        {
                            server = reader.GetAttribute("host").ToString();
                            database = reader.GetAttribute("database").ToString();
                            userID = reader.GetAttribute("username").ToString();
                            password = reader.GetAttribute("password").ToString();
                            port = reader.GetAttribute("port").ToString();
                            dbname = reader.GetAttribute("dbname").ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Class: dbconfig, Method: GetDBData. Error: " + ex.Message);
            }
        
            //dbConDataSet = new DataSet();
            //dbConDataSet.ReadXml(@"C:\GiGi\GiGi-Inventory\GiGiCLIENT.CFG");

            //port = dbConDataSet.Tables[0].Rows[0]["database"].ToString();
            //database = dbConDataSet.Tables[0].Rows[0]["database"].ToString();
            //dataSource = dbConDataSet.Tables[0].Rows[0]["host"].ToString();
            //userID = dbConDataSet.Tables[0].Rows[0]["username"].ToString();
            //userID = CryptoUtil.Decrypt(userID, "DMSSWE");
            //password = dbConDataSet.Tables[0].Rows[0]["Password"].ToString();
            //password = CryptoUtil.Decrypt(password, "DMSSWE");

            //database = dbConDataSet.Tables[0].Rows[0]["Database"].ToString();
            //dataSource = dbConDataSet.Tables[0].Rows[0]["DataSource"].ToString();
            //userID = dbConDataSet.Tables[0].Rows[0]["UserID"].ToString();
            //userID = CryptoUtil.Decrypt(userID, "DMSSWE");
            //password = dbConDataSet.Tables[0].Rows[0]["Password"].ToString();
            //password = CryptoUtil.Decrypt(password, "DMSSWE");

            switch (dbname)
            {
                case "MS SQL Server":

                    //initialCatalog = dbConDataSet.Tables[0].Rows[0]["InitialCatalogue"].ToString();
                    //minPoolSize = dbConDataSet.Tables[0].Rows[0]["Min_Pool_Size"].ToString();
                    //maxPoolSize = dbConDataSet.Tables[0].Rows[0]["Max_Pool_Size"].ToString();
                    //oSqlConnectionStringBuilder = new SqlConnectionStringBuilder();
                    //oSqlConnectionStringBuilder.DataSource = dataSource;
                    //oSqlConnectionStringBuilder.UserID = userID;
                    //oSqlConnectionStringBuilder.Password = password;
                    //oSqlConnectionStringBuilder.InitialCatalog = initialCatalog;
                    //oSqlConnectionStringBuilder.MinPoolSize = Convert.ToInt32(minPoolSize);
                    //oSqlConnectionStringBuilder.MaxPoolSize = Convert.ToInt32(maxPoolSize);
                    //dbConString = oSqlConnectionStringBuilder.ConnectionString;
                    //connType = (int)ConnectionType.SQL;
                    //oSqlConnection = new SqlConnection(dbConString);
                    break;

                case "Oracle":
                    /*OracleConnectionStringBuilder oOracleConnectionStringBuilder = new OracleConnectionStringBuilder();

                    oOracleConnectionStringBuilder.DataSource = dataSource;
                    oOracleConnectionStringBuilder.UserID = userID;
                    oOracleConnectionStringBuilder.Password = password;

                    dbConString = oOracleConnectionStringBuilder.ConnectionString;

                    connType = (int)ConnectionType.Oracle;
                    oOracleConnection = new OracleConnection(dbConString);
                     * */
                    break;

                case "MySql":
                    MySqlConnectionStringBuilder oMySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();

                    //oMySqlConnectionStringBuilder.Database = dataSource;
                    //oMySqlConnectionStringBuilder.UserID = userID;
                    //oMySqlConnectionStringBuilder.Password = password;
                    oMySqlConnectionStringBuilder.Server = server;
                    oMySqlConnectionStringBuilder.Database = database;
                    oMySqlConnectionStringBuilder.UserID = userID;
                    oMySqlConnectionStringBuilder.Password = password;
                    oMySqlConnectionStringBuilder.Port = Convert.ToUInt32(port.ToString());


                    dbConString = oMySqlConnectionStringBuilder.ConnectionString;

                    connType = (int)ConnectionType.MySql;
                    oMySqlConnection = new MySqlConnection(dbConString);
                    
                    break;
            }
        }

        public void OpenConnection()
        {
            //if (oSqlConnection == null)
            //{
            //    CreateConnection();
            //}

            if (oMySqlConnection == null)
            {
                CreateConnection();
            }

#if(debug)
                dbCon.ConnectionTimeout = 0;
#endif
            if (connType == (int)ConnectionType.SQL)
            {
                //oSqlConnection.Open();
            }
            else if (connType == (int)ConnectionType.Oracle)
            {
                //oOracleConnection.Open();
            }
            else if (connType == (int)ConnectionType.MySql)
            {
                oMySqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connType == (int)ConnectionType.SQL)
            {
                //if (oSqlConnection.State != ConnectionState.Closed)
                //{
                //    oSqlConnection.Close();
                //}
            }
            else if (connType == (int)ConnectionType.Oracle)
            {
                /*
                if (oOracleConnection.State != ConnectionState.Closed)
                {
                    oOracleConnection.Close();
                }
                 * */
            }
            else if (connType == (int)ConnectionType.MySql)
            {
                
                if (oMySqlConnection.State != ConnectionState.Closed)
                {
                    oMySqlConnection.Close();
                }
                
            }
        }

        public void BeginTransaction(IsolationLevel isolationLevel)
        {
            if (connType == (int)ConnectionType.SQL)
            {
                //oSqlTransaction = oSqlConnection.BeginTransaction(isolationLevel);
            }
            /*
        else if (connType == (int)ConnectionType.Oracle)
        {
            oOracleTransaction = oOracleConnection.BeginTransaction(isolationLevel);
        }
             * */
            
        else if (connType == (int)ConnectionType.MySql)
        {
            oMySqlTransaction = oMySqlConnection.BeginTransaction(isolationLevel);
        }
             
        }

        public void BeginTransaction()
        {
            if (connType == (int)ConnectionType.SQL)
            {
                //oSqlTransaction = oSqlConnection.BeginTransaction();
            }
            /*
        else if (connType == (int)ConnectionType.Oracle)
        {
            oOracleTransaction = oOracleConnection.BeginTransaction();
        }
             * */
            
        else if (connType == (int)ConnectionType.MySql)
        {
            oMySqlTransaction = oMySqlConnection.BeginTransaction();
        }
             
        }

        public void CommitTransaction()
        {
            if (connType == (int)ConnectionType.SQL)
            {
                //oSqlTransaction.Commit();
            }
            /*
        else if (connType == (int)ConnectionType.Oracle)
        {
            oOracleTransaction.Commit();
        }
             * */
            
        else if (connType == (int)ConnectionType.MySql)
        {
            oMySqlTransaction.Commit();
        }
             
        }

        public void RollbackTransaction()
        {
            if (connType == (int)ConnectionType.SQL)
            {
                if (oSqlTransaction != null)
                {
                    //oSqlTransaction.Rollback();
                }
            }
            /*
           else if (connType == (int)ConnectionType.Oracle)
           {
               if (oOracleTransaction != null)
               {
                   oOracleTransaction.Rollback();
               }
           }
             * */
            
        else if (connType == (int)ConnectionType.MySql)
        {
            if (oMySqlTransaction != null)
            {
                oMySqlTransaction.Rollback();
            }
        }
             
        }

        //public SqlConnection GetSqlConnection()
        //{
        //    return oSqlConnection;
        //}

        //public SqlTransaction GetSqlTransaction()
        //{
        //    return oSqlTransaction;
        //}

        /*
        public OracleConnection GetOracleConnection()
        {
            return oOracleConnection;
        }

        public OracleTransaction GetOracleTransaction()
        {
            return oOracleTransaction;
        }
         * */
       
        public MySqlConnection GetMySqlConnection()
        {
            return oMySqlConnection;
        }

        public MySqlTransaction GetMySqlTransaction()
        {
            return oMySqlTransaction;
        }
         
    }
}