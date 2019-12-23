using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;

namespace SchoolManagementSystem
{
    public class ObtainProgress : DBCommunication
    {
        private List<List<string>> _progressTableList;
        private readonly List<string> _progressTableColumns;
        public ObtainProgress()
        {
            GetProgressTable();
            _progressTableColumns = GetTableColumnsNames("progress");
        }

        private void GetProgressTable()
        {
            _progressTableList = ExecuteQuery("SELECT * FROM `progress`;", true);

        }

        public string CalculateSubjectAverageValue(string subjectName)
        {
            return ExecuteQuery($"SELECT AVG({subjectName}) FROM `progress`;", true)[0][0];
        }


        public int AmountOfUnprecedentedPupils(int idealValue)
        {
            int amount = 0;
            var list = CountAveragePupilMark();
            foreach (var elem in list)
            {
                if (elem <= idealValue)
                    amount++;                    
            }

            return amount;
        }

        private List<double> CountAveragePupilMark()
        {
            List<double> list = new List<double>();

            foreach (var row in _progressTableList)
            {
                int i, average = 0;
                for (i = 2; i < row.Count; i++)
                {
                    average += int.Parse(row[i]);
                }
                list.Add(item: (double)average / i);
            }

            return list;
        }

        public Dictionary<string, double> AverageForEachSubject()
        {
            var list = CountAverageInColumn();

            var dictionary = new Dictionary<string, double>();

            for (int i = 0; i < list.Count; i++)
            {
                dictionary.Add(_progressTableColumns[i + 2], list[i]);
            }

            return dictionary;
        }

        private List<double> CountAverageInColumn()
        {
            List<double> list = new List<double>();

            bool isListEmpty = true;
            foreach (var row in _progressTableList)
            {
                for (int i = 2; i < row.Count; i++)
                {
                    if (isListEmpty)
                    {
                        list.Add(int.Parse(row[i]));
                        continue;
                    }

                    list[i - 2] += int.Parse(row[i]);
                }

                isListEmpty = false;
            }

            for (int i = 0; i < list.Count; i++)
            {
                list[i] /= _progressTableList.Count;
            }

            return list;
        }

        public string TeacherWithLowerSuccessLevel()
        {
            double min = int.MaxValue;
            int minIndex = 0;
            var list = CountAverageInColumn();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                    minIndex = i;
                }
            }

            var subjects = SelectDataFromDataBase.SelectSubjectList();

            var linq = from subject in subjects
                where subject.Value == _progressTableColumns[minIndex + 2]
                select subject.Key;

            var teacher = ExecuteQuery(true, "SELECT `name`, `surname` FROM `teachers` WHERE `subjectID`=@subject;",
                new Dictionary<string, string>
                {
                    {
                        "@subject",
                        linq.ToList()[0]
                    }
                }, true);

            return teacher[0][0] + " " + teacher[0][1];
        }
        
        public void UpdateMark(string newMark, string id, string columnName)
        {
            var linq = from column in _progressTableColumns
                where column == columnName
                select column;
            ExecuteQuery(true, $"UPDATE `progress` SET `{linq.ToList()[0]}`=@mark WHERE `id`=@id;",
                new Dictionary<string, string> {{"@mark", newMark}, {"@id", id}}, false);

            GetProgressTable();
        }
    }
}