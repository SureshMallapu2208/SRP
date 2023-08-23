
namespace SRP
{
    internal static class ErrorLog
    {

        public static void WriteLog(string[] messages)
        {
            System.IO.File.WriteAllLines(@"C:\NetCore\Error.txt", messages);
        }


    }
}
