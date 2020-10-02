using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTimeApp.Helpers;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Data.Entity.Core.Mapping;
using System.Collections;
using NewTimeApp.UserControlers;
using System.Reflection;

namespace NewTimeApp.Helpers
{
    class TimeTableGenarate
    {

        SQLiteConnection sqlCon;
        SQLiteCommand sqlCom;
        SQLiteDataAdapter DB;
        String connectString;
        SQLiteDataReader sqlite_datareader1, sqlite_datareader2;

        Add_WorkingDaysAndHoursUC Add_WorkingDaysAndHoursUC = new Add_WorkingDaysAndHoursUC();

        /*public void getConnection()
        {
            try{
                connectString = @"Data Source=" + Application.StartupPath + @"\Database\TimeAppDB.db; version=3;Foreign Keys=True;";
                sqlCon = new SQLiteConnection(connectString);
                sqlCon.Open();
            }
            catch{

            }
        }*/
        //WorkingDaysAndHours WorkingDaysAndHours = new WorkingDaysAndHours();

        Dictionary<string, WorkingDaysAndHours> workingDays = new Dictionary<string, WorkingDaysAndHours>();

        public void LoadData()
        {
            connectString = @"Data Source=" + Application.StartupPath + @"\Database\TimeAppDB.db; version=3;Foreign Keys=True;";
            sqlCon = new SQLiteConnection(connectString);
            sqlCon.Open();
            //sqlite_cmd = sqlCon.CreateCommand();
            string sql = "SELECT * FROM WorkingDays";
            string sql2 = "SELECT * FROM SelectedDays";

            SQLiteCommand command1 = new SQLiteCommand(sql, sqlCon);
            SQLiteCommand command = new SQLiteCommand(sql2, sqlCon);

            sqlite_datareader1 = command1.ExecuteReader();
            sqlite_datareader2 = command.ExecuteReader();

            while (sqlite_datareader1.Read())
            {
                //int WorkingDays = (int)sqlite_datareader["WorkingDays"];
                string WorkingHours = (string)sqlite_datareader1["WorkingHours"];
                int WorkingHours1 = Int16.Parse(WorkingHours);
                string TimeSlot = (string)sqlite_datareader1["TimeSlot"];
                //int TimeSlot1 = Int16.Parse(TimeSlot);

                //string SelectedDays = (string)sqlite_datareader2["SelectedDays"];

                string[] terms = new string[5];
                List<string> SelectedDayslist = new List<string>();
                for (int i = 0; i < 5; i++)
                {
                    while (sqlite_datareader2.Read())
                    {
                        terms[i] = (string)sqlite_datareader2["SelectedDays"];
                        SelectedDayslist.Add(terms[i]);
                    }

                }
                string[] SelectedDays = SelectedDayslist.ToArray();

                int startTime = 8;
                int slotCount = 0;
                int timeSlot;

                if (TimeSlot == "One Hour")
                {
                    timeSlot = 1;
                }
                else
                {
                    timeSlot = 2;
                }


                if (timeSlot == 1)
                {
                    slotCount = WorkingHours1;
                }
                else
                {
                    timeSlot = 2;
                    slotCount = (WorkingHours1 * 2) / timeSlot;
                }

                string Topic = "";
                string Data = "";

                for (int i = 0; i < SelectedDays.Length; i++)
                {
                    Topic += "<th>" + SelectedDays[i] + "</th>\n";
                }
                if (timeSlot == 1)
                {
                    for (int i = 0; i < slotCount; i++)
                    {

                        Data += "<tr>";
                        Data += "<td>" + (startTime) + ".00</td>";

                        for (int j = 0; j < SelectedDays.Length; j++)
                        {
                            Data += "<td>--X--</td>";
                        }
                        Data += "</tr>";
                        startTime = startTime + timeSlot;
                    }
                }
                else
                {

                    for (int i = 0; i < slotCount; i++)
                    {

                        Data += "<tr>";
                        Data += "<td>" + (startTime) + ".30</td>";

                        for (int j = 0; j < SelectedDays.Length; j++)
                        {
                            Data += "<td>--X--</td>";
                        }
                        Data += "</tr>";
                        startTime = startTime + timeSlot;
                    }
                }
                string HEAD = "<html>"
                + "<head> "
                + "<style>"
                + "table, th, td {border: 1px solid black; padding: 0px;}\n"
                + "table {border-spacing: 1px;}"
                + "</style>"
                + "</head><body>"
                + " <table style=\"width:100%\">" +
                "  <tr>" +
                "    <th>Time</th>";

                string BODY = "</table> "
                  + "</body></html>";

                string code = HEAD + "" + Topic + "" + Data + "" + BODY;
                File.WriteAllText(Application.StartupPath + @"\TimeTable\TimeTable.html", code);

            }

            sqlCon.Close();

        }


    }
}
