using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SVTApp
{
    class SemesterLoader
    {
        public static Semester Load(StreamReader stream) 
        {
            try
            {
                string semesterName = stream.ReadLine().Split(',')[0];
                stream.ReadLine();

                List<Section> sections = new List<Section>();

                // reads each section in
                while (!stream.EndOfStream)
                {
                    string[] line = stream.ReadLine().Split(',');
                    if (!int.TryParse(line[1], out int catalogNumber)) return null;
                    Course course = new Course(line[0], catalogNumber, line[2]);
                    Instructor instructor = new Instructor(line[4]);
                    if (!int.TryParse(line[6], out int enrollmentCap)) return null;
                    DateTime meetingStartDate;
                    {
                        string[] date = line[8].Split('/');
                        if (!int.TryParse(date[0], out int month)) return null;
                        if (!int.TryParse(date[1], out int day)) return null;
                        if (!int.TryParse(date[2], out int year)) return null;
                        meetingStartDate = new DateTime(year, month, day);
                    }
                    DateTime meetingEndDate;
                    {
                        string[] date = line[9].Split('/');
                        if (!int.TryParse(date[0], out int month)) return null;
                        if (!int.TryParse(date[1], out int day)) return null;
                        if (!int.TryParse(date[2], out int year)) return null;
                        meetingEndDate = new DateTime(year, month, day);
                    }
                    Facility facility = new Facility(line[10]);

                    TimeSpan meetingTimeStart;
                    {
                        string[] time = line[11].Split(':', ' ');
                        if (!int.TryParse(time[0], out int hours)) return null;
                        if (!int.TryParse(time[1], out int minutes)) return null;
                        if (time[2].Equals("PM")) hours += 12;
                        meetingTimeStart = new TimeSpan(hours, minutes, 0);
                    }

                    TimeSpan meetingTimeEnd;
                    {
                        string[] time = line[12].Split(':', ' ');
                        if (!int.TryParse(time[0], out int hours)) return null;
                        if (!int.TryParse(time[1], out int minutes)) return null;
                        if (time[2].Equals("PM")) hours += 12;
                        meetingTimeEnd = new TimeSpan(hours, minutes, 0);
                    }

                    DayMarker meetingDays;
                    {
                        bool[] days = new bool[7];
                        for (int i = 0; i < 7; i++)
                        {
                            switch (line[13 + i][0])
                            {
                                case 'Y':
                                    days[i] = true;
                                    break;
                                case 'N':
                                    days[i] = false;
                                    break;
                                default:
                                    return null;
                            }
                        }
                        meetingDays = new DayMarker(days[0], days[1], days[2], days[3], days[4], days[5], days[6]);
                    }
                    if (!int.TryParse(line[20], out int unitsMin)) return null;
                    if (!int.TryParse(line[21], out int unitsMax)) return null;
                    sections.Add(new Section(course, line[3], instructor, line[5], enrollmentCap, line[7], meetingStartDate, meetingEndDate, facility, meetingTimeStart, meetingTimeEnd, meetingDays, unitsMin, unitsMax, line[22]));
                }
                return new Semester(semesterName, sections);
            }
            catch (IOException) { }
            catch (IndexOutOfRangeException) { }
            return null;
        }
    }
}
