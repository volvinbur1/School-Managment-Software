using System.Collections.Generic;
using System.Text.RegularExpressions;
using MySqlX.XDevAPI.Common;

namespace SchoolManagementSystem
{
    public class DeleteDataFromDatabase
    {
        public static bool DeletePupilFromDb(string pupilId)
        {
            bool isDeleted = false;

            using (DBCommunication dbcom = new DBCommunication())
            {
                var group = dbcom.InvokeEvent(false, $"SELECT `groupID` FROM `pupils` WHERE `id` = {pupilId};", null, true);
                dbcom.InvokeEvent(false, $"DELETE FROM `progress` WHERE `pupilID` = {pupilId};", null, false);
                dbcom.InvokeEvent(false, $"DELETE FROM `pupils` WHERE `id` = {pupilId};", null, false);
                var amount = dbcom.InvokeEvent(false, $"SELECT `amount_of_pupils` FROM `groups` WHERE `id` = {group[0][0]};", null, true);
                dbcom.InvokeEvent(false,
                    $"UPDATE `groups` SET `amount_of_pupils`={amount[0][0]}-1 WHERE `id`={group[0][0]};", null,
                    false);
                if (dbcom.InvokeEvent(false, $"SELECT * FROM `pupils` WHERE `id` = {pupilId};", null, true).Count ==
                    0 && dbcom.InvokeEvent(false, $"SELECT * FROM `progress` WHERE `pupilID` = {pupilId};", null, true)
                        .Count == 0)
                {
                    isDeleted = true;
                }
            }

            return isDeleted;
        }
    }
}