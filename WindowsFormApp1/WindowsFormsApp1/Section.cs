using System;

namespace SVTApp
{
    /// <summary>
    /// Class Section
    /// </summary>
    class Section
    {
        public Course Course { get; private set; }
        public string SectionNumber { get; private set; }
        public Instructor Instructor { get; private set; }
        public string Consent { get; private set; }
        public int EnrollmentCap { get; private set; }
        public string TopicDescription { get; private set; }
        public DateTime MeetingStartDate { get; private set; }
        public DateTime MeetingEndDate { get; private set; }
        public Facility Facility { get; private set; }
        public TimeSpan MeetingTimeStart { get; private set; }
        public TimeSpan MeetingTimeEnd { get; private set; }
        public DayMarker MeetingDays { get; private set; }
        public int UnitsMin { get; private set; }
        public int UnitsMax { get; private set; }
        public string ClassAssnComponent { get; private set; }

        /// <summary>
        /// Section Constructor
        /// </summary>
        /// <param name="course">section course</param>
        /// <param name="sectionNumber">section number</param>
        /// <param name="instructor">section instructor</param>
        /// <param name="consent">section consent</param>
        /// <param name="enrollmentCap">section enrollment cap</param>
        /// <param name="topicDescription">section topic</param>
        /// <param name="meetingStartDate">section meeting start date</param>
        /// <param name="meetingEndDate">section meeting end date</param>
        /// <param name="facility">section facility</param>
        /// <param name="meetingTimeStart">meeting start time</param>
        /// <param name="meetingTimeEnd">meeting end time</param>
        /// <param name="meetingDays">meeting days</param>
        /// <param name="unitsMin">section units minimum</param>
        /// <param name="unitsMax">section units maximum</param>
        /// <param name="classAssnComponent">section class assn component</param>
        public Section(Course course, string sectionNumber, Instructor instructor, string consent,
            int enrollmentCap, string topicDescription, DateTime meetingStartDate, DateTime meetingEndDate,
            Facility facility, TimeSpan meetingTimeStart, TimeSpan meetingTimeEnd, DayMarker meetingDays,
            int unitsMin, int unitsMax, string classAssnComponent)
        {
            Course = course;
            SectionNumber = sectionNumber;
            Instructor = instructor;
            Consent = consent;
            EnrollmentCap = enrollmentCap;
            TopicDescription = topicDescription;
            MeetingStartDate = meetingStartDate;
            MeetingEndDate = meetingEndDate;
            Facility = facility;
            MeetingTimeStart = meetingTimeStart;
            MeetingTimeEnd = meetingTimeEnd;
            MeetingDays = meetingDays;
            UnitsMin = unitsMin;
            UnitsMax = unitsMax;
            ClassAssnComponent = classAssnComponent;
        }

        /// <summary>
        /// A Section is equal to annother if all of its data has the same value as the other
        /// </summary>
        /// <param name="obj">the object to compare</param>
        /// <returns>true if equal</returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() == GetType())
            {
                Section s = (Section)obj;
                return Course.Equals(s.Course) &&
                    SectionNumber.Equals(s.SectionNumber) &&
                    Instructor.Equals(s.Instructor) &&
                    Consent.Equals(s.Consent) &&
                    EnrollmentCap == s.EnrollmentCap &&
                    TopicDescription.Equals(s.TopicDescription) &&
                    MeetingStartDate.Equals(s.MeetingStartDate) &&
                    MeetingEndDate.Equals(s.MeetingEndDate) &&
                    Facility.Equals(s.Facility) &&
                    MeetingTimeStart.Equals(s.MeetingTimeStart) &&
                    MeetingTimeEnd.Equals(s.MeetingTimeEnd) &&
                    UnitsMin == s.UnitsMin &&
                    UnitsMax == s.UnitsMax &&
                    ClassAssnComponent == s.ClassAssnComponent;
            }
            return base.Equals(obj);
        }
    }
}
