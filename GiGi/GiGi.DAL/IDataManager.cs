using System;
using System.Collections.Generic;
using System.Text;
using GiGi.COMMON;

namespace GiGi.DAL
{
    public interface IDataManager
    {
        List<EmployeeDTO> EmployeeDetailsSelect(Connection connecion);
    }
}