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

 

namespace NewTimeApp.Helpers
{
    class TimeTableGenarate
    {

        SQLiteConnection sqlCon;
        SQLiteCommand sqlCom;
        SQLiteDataAdapter DB;
        String connectString;
        SQLiteDataReader sqlite_datareader;

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

            SQLiteCommand command = new SQLiteCommand(sql,sqlCon);

           // command.ExecuteNonQuery();
            MessageBox.Show("done");
            sqlite_datareader = command.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                //int WorkingDays = (int)sqlite_datareader["WorkingDays"];
                string WorkingHours = (string)sqlite_datareader["WorkingHours"];
                int WorkingHours1= Int32.Parse(WorkingHours);
                string TimeSlot = (string)sqlite_datareader["TimeSlot"];
                int TimeSlot1 = Int32.Parse(TimeSlot);


                //string[] SelectedDays = (string[])sqlite_datareader["selectedDays"];

                string[] SelectedDays = new string[5];
                SelectedDays = (string[])sqlite_datareader["selectedDays"];
                //int WorkingDays = 5;
                //  int WorkingHours = 8;
                int startTime = 8;
                int slotCount = 0;
                int timeSlot;

                /*if(TimeSlot == "One Hour")
                {
                    timeSlot = 1;
                }
                else
                {
                    timeSlot = 2;
                }*/


                if(TimeSlot1 == 1)
                {
                    //int workingHours = Convert.ToInt32("WorkingHours");
                    slotCount = WorkingHours1;
                }
                else
                {
                   // int workingHours = int.Parse("WorkingHours");
                    timeSlot = 2;
                    slotCount = (WorkingHours1 * 60)/TimeSlot1;
                }

                string Topic = "";
                string Data = "";

                for (int i = 0; i < SelectedDays.Length; i++)
                {
                    Topic += "<th>" + SelectedDays[i] + "</th>\n";
                    /*Topic += "<th>" + SelectedDays[1] + "</th>\n";
                    Topic += "<th>" + SelectedDays[2] + "</th>\n";
                    Topic += "<th>" + SelectedDays[3] + "</th>\n";
                    Topic += "<th>" + SelectedDays[4] + "</th>\n";*/
                }
                for (int i = 0; i < slotCount; i++)
                {
                    
                    Data += "<tr>";
                    Data += "<td>" + (startTime) + ".00</td>";

                    for (int j = 0; j < SelectedDays.Length; j++)
                    {
                        Data+= "<td>--X--</td>";
                    }
                    Data += "</tr>";
                    startTime = startTime + TimeSlot1;
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
                File.WriteAllText(@"C:\Users\Mishane\source\repos\Timetable-Generator\TimeTable\timeTable.html", code);
                MessageBox.Show("html");

            }
            MessageBox.Show("done2");
            
            sqlCon.Close();
            /* using(command = new SQLiteCommand("SELECT * FROM WorkingDays"))
             {
                 using(var reader = command.ExecuteReader())
                 {
                     if (reader.HasRows)
                     {
                         while (reader.NextResult())
                         {
                             var WorkingDays = reader["WorkingDays"];
                             var WorkingHours = reader["WorkingHours"];
                             var TimeSlot = reader["TimeSlot"];

                         }
                     }
                 }
             }*/

            /*Console.WriteLine(workingDays);
            sqlCon.Close();*/


        }
    }
}
