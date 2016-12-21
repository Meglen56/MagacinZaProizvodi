using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SeminarskaKNI107
{
    public static class MagacinEventLog
    {
        public static string sSource = "SeminarskaKNI107";
        public static string sLog = "Application";
        public static string StartUp = Application.StartupPath;
        public static void WriteInformationLog(String EventToWrite)
        {
            CheckIfLogExixts();
            EventLog.WriteEntry(sSource, EventToWrite, EventLogEntryType.Information);
            File.AppendAllText(StartUp + @"/Magacinlog.txt", DateTime.Now + " Information " + Environment.NewLine + EventToWrite + Environment.NewLine);

        }
        public static void WriteWarningLog(String EventToWrite)
        {
            CheckIfLogExixts();
            EventLog.WriteEntry(sSource, EventToWrite, EventLogEntryType.Warning);
            File.AppendAllText(StartUp + @"/Magacinlog.txt", DateTime.Now + " Warning " + Environment.NewLine + EventToWrite + Environment.NewLine);
        }
        public static void WriteErrorLog(String EventToWrite)
        {
            CheckIfLogExixts();
            EventLog.WriteEntry(sSource, EventToWrite, EventLogEntryType.Error);
            File.AppendAllText(StartUp + @"/Magacinlog.txt", DateTime.Now + " Error " + Environment.NewLine + EventToWrite + Environment.NewLine);
        }
        public static void CheckIfLogExixts()
        {
            if (!EventLog.SourceExists(sSource))
            {
                EventLog.CreateEventSource(sSource, sLog);
            }
        }
    }
    }




