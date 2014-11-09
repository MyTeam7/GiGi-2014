using System;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text;
using GiGi.COMMON;

namespace GiGi.DAL
{
    public class SqlEmployeeDAL
    {
        public List<EmployeeDTO> EmployeeSelect(Connection oConnection)
        {
            string query;
            
            //SqlCommand oSqlCommand;
            //SqlDataReader oSqlDataReader;
            MySqlCommand oMySqlCommand;
            MySqlDataReader oMySqlDataReader;

            {
                List<EmployeeDTO> results = new List<EmployeeDTO>();

                try
                {
                    query = " SELECT * FROM Employee ";

                    oMySqlCommand = new MySqlCommand();
                    oMySqlCommand.CommandText = query;
                    oMySqlCommand.Connection = oConnection.GetMySqlConnection();
                    oMySqlCommand.Transaction = oConnection.GetMySqlTransaction();
                    oMySqlDataReader = oMySqlCommand.ExecuteReader();
                    while (oMySqlDataReader.Read())
                    {
                        EmployeeDTO oEmployeeDTO = new EmployeeDTO();

                        oEmployeeDTO.EmployeeId = Convert.ToInt32(oMySqlDataReader["employeeId"]);
                        oEmployeeDTO.EmpTp = Convert.IsDBNull(oMySqlDataReader["Tp"]) ? 0 : Convert.ToInt32(oMySqlDataReader["Tp"]);
                        oEmployeeDTO.EmpFirstName = Convert.IsDBNull(oMySqlDataReader["FName"]) ? string.Empty : Convert.ToString(oMySqlDataReader["FName"]);
                        oEmployeeDTO.EmpLastName = Convert.IsDBNull(oMySqlDataReader["LName"]) ? string.Empty : Convert.ToString(oMySqlDataReader["LName"]);
                       
                        results.Add(oEmployeeDTO);
                    }
                    oMySqlDataReader.Close();
                    return results;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
