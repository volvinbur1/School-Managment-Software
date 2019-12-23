using System.Collections.Generic;
using System.Linq;
using System.Resources;
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
                var result = dbcom.InvokeEvent(true, "INSERT INTO `subjects` (`subject_name`) VALUES (@subject)",
                    new Dictionary<string, string> { { "@subject", subject } }, false);
                if (!result.Any())
                {
                    result = dbcom.InvokeEvent(false, $"ALTER TABLE `progress` ADD COLUMN {subject} INT;", null, false);
                    if (!result.Any())
                        returnResult = true;
                }

            }

            return returnResult;
        }

        public static bool AddPupil(string name, string surname, string email, string group, string entranceYear)
        {
            using (DBCommunication dbcom = new DBCommunication())
            {
                var result = dbcom.InvokeEvent(true,
                    "INSERT INTO `pupils` (`name`, `surname`, `email`, `groupID`, `entrance_year`) VALUES" +
                    "(@name, @surname, @email, @group, @entrance_year);",
                    new Dictionary<string, string>
                    {
                        {"@name", name}, {"@surname", surname}, {"@email", email}, {"@group", group},
                        {"@entrance_year", entranceYear}
                    }, false);
                var id = dbcom.InvokeEvent(true,
                    "SELECT `id` FROM `pupils` WHERE `name` = @name AND `surname` = @surname;", new Dictionary<string,
                        string> {{"@name", name}, {"@surname", surname}}, true);
                dbcom.InvokeEvent(true, "INSERT INTO `progress` (`pupilId`) VALUES (@pupilId);",
                    new Dictionary<string, string> {{"@pupilId", id[0][0]}}, false);

                var amount = dbcom.InvokeEvent(false, $"SELECT `amount_of_pupils` FROM `groups` WHERE `id` = {group};", null, true);
                dbcom.InvokeEvent(false,
                    $"UPDATE `groups` SET `amount_of_pupils`={amount[0][0]}+1 WHERE `id`={group};", null,
                    false);

                if (!result.Any())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AddTeacher(string name, string surname, string subject, string cabinet)
        {
            using (DBCommunication dbcom = new DBCommunication())
            {
                var result = dbcom.InvokeEvent(true,
                    "INSERT INTO `teachers` (`name`, `surname`, `subjectID`, `cabinetID`) VALUES" +
                    "(@name, @surname, @subject, @cabinet);",
                    new Dictionary<string, string>
                    {
                        {"@name", name}, {"@surname", surname}, {"@subject", subject},
                        {"@cabinet", cabinet}
                    }, false);

                if (!result.Any())
                {
                    return true;
                }
            }

            return false;
        }
    }
}