using LogManager.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LogManager.Data
{
    public interface ILogData
    {
        IEnumerable<Log> GetLogCalled(string name);
        IEnumerable<Log> GetLogContaining(string keyword);
        bool CreateLog(string fileDirectory, string name, string[] Lines);
        bool DeleteLog(int id);
        bool StampLog(string fileDirectory, int id);
        bool AddStoredLog(int id);
        bool RemoveStoredLog(int id);
        IEnumerable<int> GetStoredLogs();
        bool ClearStoredLogs();
    }

    public class InMemoryLogData : ILogData
    {
        private List<Log> Logs;

        private List<int> StoredLogs;

        string[] ExampleContent1 = new string[]
        {
            "Panel4.btn_Position_Summary", "Panel5.btn_Static_LME_DPRS", "Panel1.btn_Save", "Panel5.BankJournals_btn",
            "Panel5.btn_Static_LME_DPRS", "Panel2.btn_DuCo_EclipseSDS_TopDayTrades"
        };

        string[] ExampleContent2 = new string[]
        {
            "Panel5.btn_Static_LME_DPRS", "Panel2.btn_IFF_Manual", "Panel1.btn_Save", "Panel16.Button1",
            "OUTPUT_Client_Services_LGFCINC_PDF_Report", "BARGAINS_Daily_Import"
        };

        string[] ExampleContent3 = new string[]
        {
            "Panel4.btn_Position_Summary", "Panel5.btn_Static_LME_DPRS", "Panel1.btn_Save", "Panel5.BankJournals_btn",
            "OUTPUT_DuCo_EclipseCSC_RegulatoryAccountStatic", "OUTPUT_Eclipse_Contract_Setup|07/03/2019|07/03/2019"
        };

        public InMemoryLogData()
        {
            Logs = new List<Log>()
            {
                new Log {Id = 1, Name = "TestLog1", Content = ExampleContent1, LastModified = "12/07/2018"},
                new Log {Id = 2, Name = "TestLog2", Content = ExampleContent3, LastModified = "12/05/2019"},
                new Log {Id = 3, Name = "TestLog3", Content = ExampleContent2, LastModified = "12/01/2018"},
                new Log {Id = 4, Name = "TestLog4", Content = ExampleContent2, LastModified = "12/04/2019"},
                new Log {Id = 5, Name = "RandomName", Content = ExampleContent3, LastModified = "12/05/2019"},
                new Log {Id = 6, Name = "TestLog6", Content = ExampleContent1, LastModified = "12/12/2017"},
                new Log {Id = 7, Name = "TestLog7", Content = ExampleContent1, LastModified = "12/11/2018"},
                new Log {Id = 8, Name = "TestLog8", Content = ExampleContent3, LastModified = "12/08/2019"},
                new Log {Id = 9, Name = "TestLog9", Content = ExampleContent1, LastModified = "12/10/2019"},
                new Log {Id = 10, Name = "TestLog10", Content = ExampleContent2, LastModified = "12/08/2019"}
            };
        }

        public IEnumerable<Log> GetLogCalled(string name)
        {
            List<Log> Results = new List<Log>();
            foreach (var log in Logs)
            {
                if(name == null)
                {
                    return Logs;
                }
                if (log.Name.Contains(name))
                {
                   Results.Add(log);
                }
            }
            return Results;
        }

        public IEnumerable<Log> GetLogContaining(string keyword)
        {
            List<Log> Results = new List<Log>();
            foreach (var log in Logs)
            {
                if (keyword == null)
                {
                    return Logs;
                }
                if (log.Content.Contains(keyword))
                {
                    Results.Add(log);
                }
            }
            return Results;
        }

        public bool CreateLog(string fileDirectory, string name, string[] Lines)
        {
            string path = fileDirectory + "\\" + name;
            int newId = (Logs[Logs.Count].Id) + 1;

            Log newLog = new Log() {Id=newId, Name=name, Content=Lines, LastModified=DateTime.Now.ToString() };

            using (StreamWriter sw = File.CreateText(path))
            {
                foreach(var line in Lines)
                {
                    sw.WriteLine(line);
                }
            }

            if (Logs.Exists(log => log.Id == newId))
            {
                return true;
            }
            else return false;

        }

        //Returns a boolean value representing if the element was removed.
        public bool DeleteLog(int id)
        {
            RemoveStoredLog(id);
            return Logs.Remove(new Log() { Id = id });
        }

        //Should this method return a boolean value to show if failed?
        public bool StampLog(string fileDirectory, int id)
        {
            foreach (var log in Logs)
            {
                if (log.Id.Equals(id))
                {
                    using (StreamWriter sw = File.AppendText(fileDirectory))
                    {
                        sw.WriteLine(DateTime.Now);
                    }
                    return true;
                }
            }
            return false;
        }

        public bool AddStoredLog(int id)
        {
            StoredLogs.Add(id);

            if (StoredLogs.Contains(id))
            {
                return true;
            }
            else return false;
        }

        public bool RemoveStoredLog(int id)
        {
            StoredLogs.Remove(id);

            if (StoredLogs.Contains(id))
            {
                return false;
            }
            return true;
        }

        public IEnumerable<int> GetStoredLogs()
        {
            return StoredLogs;
        }

        public bool ClearStoredLogs()
        {
            StoredLogs.Clear();

            if (StoredLogs.Any())
            {
                return false;
            }
            return true;
        }
    }
}
