using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Org.BouncyCastle.Asn1;

namespace SchoolManagementSystem
{
    public class UserVerifications
    {
        private static bool _admin = false;
        public static bool Admin { get=>_admin; }

        public static bool VerifyPassword(string username, string password)
        {
            List<List<string>> result;
            using (DBCommunication dbcom = new DBCommunication())
            {
                result = dbcom.InvokeEvent(true, "SELECT `password`,`admin` FROM `users` WHERE `username` = @username;",
                    new Dictionary<string, string>
                    {
                        {"@username", username}
                    }, true);
            }

            if (result != null && result.Count != 0)
            {
                _admin = bool.Parse(result[0][1]);

                if (result[0][0] == password)
                    return true;
            }

            return false;
        }

        public static string ObtainTextOfError(string username)
        {
            List<List<string>> result = new List<List<string>>();
            using (DBCommunication dbcom = new DBCommunication())
            {
                result = dbcom.InvokeEvent(false, "SELECT `username` FROM `admins`;", null, true);
            }

            if (result == null)
                return "Username and password doesn`t match.";
            return "Password does`t match";
        }

        public static string GetUserName(string username)
        {
            List<List<string>> result;
            using (DBCommunication dbcom = new DBCommunication())
            {
                result = dbcom.InvokeEvent(true,
                    "SELECT `name`, `surname` FROM `users` WHERE `username` = @username;",
                    new Dictionary<string, string>
                    {
                        {"@username", username}
                    }, true);
            }

            return result[0][0] + " " + result[0][1];
        }
    }
}