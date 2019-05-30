using LogManager.Core;
using System.Collections.Generic;

namespace LogManager.Data
{
    public interface ILogData
    {
        List<Log> GetLogCalled(string name);
        List<Log> GetLogContaining(string keyword);

    }

    public class InMemoryLogData : ILogData
    {
        private List<Log> Logs;

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

        public List<Log> GetLogCalled(string name)
        {
            List<Log> Results = new List<Log>();
            foreach (var log in Logs)
            {
                if (log.Name.Contains(name))
                {
                   Results.Add(log);
                }
            }
            return Results;
        }

        public List<Log> GetLogContaining(string keyword)
        {
            List<Log> Results = new List<Log>();
            foreach (var log in Logs)
            {
                for (int i = 0; i < log.Content.Length; i++)
                {
                    if (log.Content[i].Contains(keyword))
                    {
                        Results.Add(log);
                    }
                }
            }
            return Results;
        }
    }
}
