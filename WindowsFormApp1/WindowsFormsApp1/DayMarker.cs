namespace SVTApp
{
    /// <summary>
    /// A class which marks specific days of the week
    /// </summary>
    class DayMarker
    {
        public bool Monday {get; private set; }
        public bool Tuesday { get; private set; }
        public bool Wednesday { get; private set; }
        public bool Thursday { get; private set; }
        public bool Friday { get; private set; }
        public bool Saturday { get; private set; }
        public bool Sunday { get; private set; }

        /// <summary>
        /// DayMarker Constructor
        /// </summary>
        /// <param name="mon">true to mark this day of the week</param>
        /// <param name="tue">true to mark this day of the week</param>
        /// <param name="wed">true to mark this day of the week</param>
        /// <param name="thu">true to mark this day of the week</param>
        /// <param name="fri">true to mark this day of the week</param>
        /// <param name="sat">true to mark this day of the week</param>
        /// <param name="sun">true to mark this day of the week</param>
        public DayMarker(bool mon, bool tue, bool wed, bool thu, bool fri, bool sat, bool sun)
        {
            Monday = mon;
            Tuesday = tue;
            Wednesday = wed;
            Thursday = thu;
            Friday = fri;
            Saturday = sat;
            Sunday = sun;
        }

        /// <summary>
        /// A DayMarker is equal to annother if it has all the same marks as the other
        /// </summary>
        /// <param name="obj">object to compare</param>
        /// <returns>true if equal</returns>
        public override bool Equals(object obj)    
        {
            if (obj.GetType() == GetType())
            {
                DayMarker dm = (DayMarker)obj;
                return (Sunday == dm.Sunday) && (Monday == dm.Monday) && (Tuesday == dm.Tuesday) && (Wednesday == dm.Wednesday) && (Thursday == dm.Thursday) && (Friday == dm.Friday) && (Saturday == dm.Saturday);
            }
            return base.Equals(obj);
        }
    }
}
