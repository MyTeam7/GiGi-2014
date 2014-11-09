using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;


namespace GiGi.COMMON
{
    public class CustomException
    {
        /*
        private Int32 classID;
        private Int32 functionID;
        private bool isSuccess;
        private string message;
        private Int32 methodID;
        protected Int32 moduleID;
        private string valMessage;

        #region Public Attributes

        public Int32 ClassID
        {
            get { return classID; }
        }

        public Int32 FunctionID
        {
            get { return functionID; }
        }

        public bool IsSuccess
        {
            get { return isSuccess; }
        }

        public string Message
        {
            get { return message; }
        }

        public Int32 MethodID
        {
            get { return methodID; }
        }

        public Int32 ModuleID
        {
            get { return moduleID; }
        }

        public string ValMessage
        {
            get { return valMessage; }

            //set { valMessage = value; }
        }

        #endregion Public Attributes

        #region Constructor

        public CustomException(bool isSuccess)
        {
            this.isSuccess = isSuccess;
        }

        public CustomException(bool isSuccess, Int32 moduleId, Int32 functionId)
        {
            this.moduleID = moduleId;
            this.functionID = functionId;
            this.isSuccess = isSuccess;
        }

        #endregion Constructor

        private void RaiseError(, Exception exception)
        {
        }

        private void RaiseValidationError(string message)
        {
            this.isSuccess = false;
            this.message = message;
        }

        #region Private Methods

        private static void CheckLogDirectory()
        {
            //if (!Directory.Exists(Application.StartupPath + @"\GiGi\GiGi-Inventory"))
            //{
            //    Directory.CreateDirectory(Application.StartupPath + @"\GiGi\GiGi-Inventory");
            //}
        }

        private static void LockDirectory()
        {
            DirectorySecurity DSec = Directory.GetAccessControl(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\GiGi\GiGi-Inventory");
            DSec.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.Write, AccessControlType.Deny));
            DSec.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ReadAndExecute, AccessControlType.Allow));
            DSec.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.CreateFiles, AccessControlType.Deny));
            DSec.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.AppendData, AccessControlType.Deny));
            DSec.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ChangePermissions, AccessControlType.Deny));
            Directory.SetAccessControl(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\GiGi\GiGi-Inventory", DSec);
        }

        private static void UnlockDirectory()
        {
            DirectorySecurity DSec = Directory.GetAccessControl(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\GiGi-Inventory");
            DSec.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ChangePermissions, AccessControlType.Allow));
            DSec.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.Write, AccessControlType.Allow));
            DSec.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ReadAndExecute, AccessControlType.Allow));
            DSec.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.CreateFiles, AccessControlType.Allow));
            DSec.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.AppendData, AccessControlType.Allow));
            Directory.SetAccessControl(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\GiGi-Inventory", DSec);
        }

        #endregion Private Methods

        */

        //public static void RaiseError(Exception exception, Int32 moduleId, Int32 functionId, Int32 classId, Int32 methodId)
        //{
        //    string errorCode = string.Empty, heading = string.Empty;
        //    string errorMsg = CustomMessages(exception);

        //    errorCode = classId.ToString() + " " + methodId.ToString();
        //    heading = moduleId.ToString() + " " + functionId.ToString();

        //    WriteLog(errorCode, heading, exception.ToString());
        //}

        //public static string GetErrorMessage(Exception exception)
        //{
        //    return CustomMessages(exception);
        //}

       //private static string CustomMessages(Exception ex)
       // {
       //     ExceptionTypes resultExceptionTypes;
       //     if (Enum.Parse<ExceptionTypes>(ex.GetBaseException().GetType().Name, out resultExceptionTypes))
       //     {
       //         switch (resultExceptionTypes)
       //         {
       //             case ExceptionTypes.ArgumentException:
       //                 return "Method called with invalid arguments";
       //             case ExceptionTypes.ArgumentNullException:
       //                 return "Invalid arguments were pass";
       //             case ExceptionTypes.ArgumentOutOfRangeException:
       //                 return "Passed values falls outside the allowed numeric range";
       //             case ExceptionTypes.ArrayTypeMismatchException:
       //                 return "Assigned array value is not compatible";
       //             case ExceptionTypes.DirectoryNotFoundException:
       //                 return "Missing directory";
       //             case ExceptionTypes.DivideByZeroException:
       //                 return "Cannot divided by zero";
       //             case ExceptionTypes.FileNotFoundException:
       //                 return "Cannot find the specified file";
       //             case ExceptionTypes.FormatException:
       //                 return "Incorrect Format";
       //             case ExceptionTypes.IndexOutOfRangeException:
       //                 return "Statement tries to access an element at an index greater than the maximum allowable index";
       //             case ExceptionTypes.InvalidCastException:
       //                 return "Statement tries to cast one reference type to a reference type that is not compatible";
       //             case ExceptionTypes.InvalidOperationException:
       //                 return "Incorrect operation on collection";
       //             case ExceptionTypes.IOException:
       //                 return "Input output error";
       //             case ExceptionTypes.KeyNotFoundException:
       //                 return "Invalid usage of dictionary";
       //             case ExceptionTypes.NotImplementedException:
       //                 return "Request function is not implemented";
       //             case ExceptionTypes.NullReferenceException:
       //                 return "Cannot assign string to a null value";
       //             case ExceptionTypes.OutOfMemoryException:
       //                 return "Value is too large to store in memory";
       //             case ExceptionTypes.OverflowException:
       //                 return "Value is too large to represent";
       //             case ExceptionTypes.StackOverflowException:
       //                 return "Recursive method call identified";
       //             case ExceptionTypes.TypeInitializationException:
       //                 return "Error in type initialization";
       //             case ExceptionTypes.SqlException:
       //                 return SqlErrors(ex);
       //             default:
       //                 return ex.Message;
       //         }
       //     }
       //     else
       //     {
       //         return ex.Message;
       //     }
       // }

        private static string SqlErrors(Exception ex)
        {
            SqlException oSqlException = (SqlException)ex;
            CommonErrorCodes oCommonErrorCodes = (CommonErrorCodes)Enum.Parse(typeof(CommonErrorCodes), oSqlException.Number.ToString());
            switch (oCommonErrorCodes)
            {
                case CommonErrorCodes.Foreignkey_Violation:
                    return "Cannot delete this record due to foreign key";
                case CommonErrorCodes.Unique_Primary_Constraint_Violation:
                    return "Entered value already exists";
                default:
                    return oSqlException.Message;
            }
        }

        private static void WriteLog(string ErrorCode, string Heading, string errorMessage)
        {
            //CheckLogDirectory();
            //UnlockDirectory();

            string PreFix = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " ==> \r\n";
            string FileName = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0') + ".erlg";

            StreamWriter sw = new StreamWriter(Path.Combine(@"C:\GiGi\GiGi-Inventory\", FileName), true);
            sw.WriteLine(PreFix + "\r\n Error Code      : " + ErrorCode + "\r\n Heading         : " + Heading + "\r\n System Message : " + errorMessage + "\r\n -----------------------------------------------------");
            sw.Flush();
            sw.Close();

            //LockDirectory();
        }

    }
    //public static class ExceptionHelper
    //{
    //    public static void AddToClipBoard(this Exception x, Exception e)
    //    {
    //        try
    //        {
    //            Clipboard.SetText("Message Header:- " + e.Message.ToString() + "\r\nTrace Message:- " + e.StackTrace.ToString());
    //        }
    //        catch (System.Runtime.InteropServices.COMException)
    //        {
    //            try
    //            {
    //                Clipboard.SetText("Message Header:- " + e.Message.ToString() + "\r\nTrace Message:- " + e.StackTrace.ToString());
    //            }
    //            catch (System.Runtime.InteropServices.COMException)
    //            {
    //            }
    //        }
    //        catch { }
    //    }
    //}
}