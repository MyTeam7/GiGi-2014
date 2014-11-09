using System;
using System.Collections.Generic;

using System.Text;
using GiGi.COMMON;

namespace GiGi.DAL
{
    public class DataManager
    {
        private IDataManager iDataManager = null;
        private Connection connection = null;

        #region Constructor

        public DataManager(Connection oConnection)
        {
            connection = oConnection;
            if (oConnection.ConnType == (int)ConnectionType.MySql)
            {
                iDataManager = new DataHandlerMySql();
            }
        }

        #endregion Constructor

        #region Employee

        public List<EmployeeDTO> EmployeeDetailsSelect()
        {
            return iDataManager.EmployeeDetailsSelect(connection);
        }

        #endregion Employee
    }
}