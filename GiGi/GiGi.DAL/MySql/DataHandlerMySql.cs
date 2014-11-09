using System;
using System.Collections.Generic;

using System.Text;
using GiGi.COMMON;
using GiGi.DAL;

namespace GiGi.DAL
{
    public class DataHandlerMySql : IDataManager
    {
        public List<EmployeeDTO> EmployeeDetailsSelect(Connection connecion)
        {
            SqlEmployeeDAL oEmployee = new SqlEmployeeDAL();
            return oEmployee.EmployeeSelect(connecion);
        }
    }
}