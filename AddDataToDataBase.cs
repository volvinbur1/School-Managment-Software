using System.Collections.Generic;
using System.Linq;
using MySqlX.XDevAPI.Common;

namespace SchoolManagementSystem
{
    public class AddDataToDataBase
    {
        public static bool AddCabinet(int cabinetNumber)
        {
            List<List<string>> result;
            using (DBCommunication dbcom = new DBCommunication())
            {
                result = dbcom.InvokeEvent(true, "INSERT INTO `cabinets` (`cabinet_number`) VALUES (@cabinet)",
                    new Dictionary<string, string> {{"@cabinet", cabinetNumber.ToString()}}, false);
            }

            if (result.Count == 0)
                return true;
            return false;
        }

        public static bool AddSubject(string subject)
        {
            bool returnResult = false;
            using (DBCommunication dbcom = new DBCommunication())
            {
                var result = dbcom.InvokeEvent(true, "INSERT INTO `subjects` (`subject`) VALUES (@subject)",
                    new Dictionary<string, string> { { "@subject", subject } }, false);
                if (!result.Any())
                {
                    result = dbcom.InvokeEvent(true, "ALTER TABLE `progress` ADD @subject INT;",
                        new Dictionary<string, string> {{"@subject", subject}}, false);
                    if (!result.Any())
                        returnResult = true;
                }

            }

            return returnResult;
        }
    }
}