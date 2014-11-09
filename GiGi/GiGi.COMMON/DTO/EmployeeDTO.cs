using System;
using System.Collections.Generic;
using System.Text;

namespace GiGi.COMMON
{
    /// <summary>
    /// Represents a row of Employee data
    /// </summary>
    public class EmployeeDTO
    {
        /// <summary>
        /// Gets or sets a int value for the EmployeeId column.
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets a string value for the EmpFirstName column.
        /// </summary>
        public string EmpFirstName { get; set; }

        /// <summary>
        /// Gets or sets a string value for the EmpLastName column.
        /// </summary>
        public string EmpLastName { get; set; }

        /// <summary>
        /// Gets or sets a int value for the EmpTp column.
        /// </summary>
        public int EmpTp { get; set; }
    }
}