using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Configuration;

namespace WindowsBitcoinLogService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        public static void ScheduleService()
        {
            // Objekt klase Timer  
            Timer Schedular = new Timer(new TimerCallback(SchedularCallback));
            // Postavljanje vremena 'po defaultu' 
            DateTime scheduledTime = DateTime.MinValue;
            string mode = ConfigurationManager.AppSettings["Mode"].ToUpper();
            if (mode == "DAILY")
            {
                //Dohvati vrijeme iz konfiguracijske datoteke.
                scheduledTime =
                DateTime.Parse(System.Configuration.ConfigurationManager.AppSettings["ScheduledTime"]);
                if (DateTime.Now > scheduledTime)
                {
                    //Ukoliko je termin prošao, dodaj 1 dan.
                    scheduledTime = scheduledTime.AddDays(1);
                }
            }
            if (mode.ToUpper() == "INTERVAL")
            {
                // Dohvati vrijeme iz konfiguracijske datoteke
                int intervalMinutes =
                Convert.ToInt32(ConfigurationManager.AppSettings["IntervalMinutes"]);
                //Postavi zakazano vrijeme za jednu minutu od trenutnog vremena.
                scheduledTime = DateTime.Now.AddMinutes(intervalMinutes);
                if (DateTime.Now > scheduledTime)
                {
                    //Ukoliko je termin prošao, dodaj 1 minutu.
                    scheduledTime = scheduledTime.AddMinutes(intervalMinutes);
                }
            }
            // Vremenski interval 
            TimeSpan timeSpan = scheduledTime.Subtract(DateTime.Now);
            string schedule = string.Format("{0} day(s) {1} hour(s) {2} minute(s) {3} seconds(s)", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            //Razlika između trenutnog vremena i planiranog vremena 
            int dueTime = Convert.ToInt32(timeSpan.TotalMilliseconds);
            // Promjena vremena izvršavanja metode povratnog poziva. 
            Schedular.Change(dueTime, Timeout.Infinite);
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
