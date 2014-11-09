using System;
using System.Collections.Generic;

using System.Text;
using GiGi.COMMON;
using GiGi.DAL;

namespace GiGi.BL
{
    public class EmployeeBL
    {
        public List<EmployeeDTO> Select()
        {
            return Select(null);
        }

        internal List<EmployeeDTO> Select(Connection oConnection)
        {
            try
            {
                List<EmployeeDTO> results = new List<EmployeeDTO>();
                bool newConnection = false;
                if (oConnection == null)
                {
                    oConnection = new Connection();
                    oConnection.OpenConnection();
                    oConnection.BeginTransaction();
                    newConnection = true;
                }

                DataManager oDataManager = new DataManager(oConnection);
                results = oDataManager.EmployeeDetailsSelect();

                if (newConnection)
                {
                    oConnection.CommitTransaction();
                    oConnection.CloseConnection();
                }

                return results;
            }
            catch (Exception ex)
            {
                oConnection.RollbackTransaction();
                oConnection.CloseConnection();
                throw ex;
            }
        }
    }
}
