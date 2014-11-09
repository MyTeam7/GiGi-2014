using System.ComponentModel;

namespace GiGi.COMMON
{
    public enum ConnectionType
    {
        SQL = 1,
        Oracle = 2,
        MySql = 3
    }

    public enum ExceptionTypes
    {
        ArgumentException = 1,
        ArgumentNullException = 2,
        ArgumentOutOfRangeException = 3,
        ArrayTypeMismatchException = 4,
        DirectoryNotFoundException = 5,
        DivideByZeroException = 6,
        FileNotFoundException = 7,
        FormatException = 8,
        IndexOutOfRangeException = 9,
        InvalidCastException = 10,
        InvalidOperationException = 11,
        IOException = 12,
        KeyNotFoundException = 13,
        NotImplementedException = 14,
        NullReferenceException = 15,
        OutOfMemoryException = 16,
        OverflowException = 17,
        StackOverflowException = 18,
        TypeInitializationException = 19,
        SqlException = 20
    }

    public enum CommonErrorCodes
    {
        //Sql Exception Error Codes
        Foreignkey_Violation = 547,

        Unique_Primary_Constraint_Violation = 2627
    }
}