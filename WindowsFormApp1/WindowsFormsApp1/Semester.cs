using System.Collections.Generic;

namespace SVTApp
{
    /// <summary>
    /// University Semester
    /// </summary>
    class Semester
    {
        public string Name { get; private set; }
        public List<Section> Sections { get; private set; }

        /// <summary>
        /// Semester Constructor
        /// </summary>
        /// <param name="name">semester name</param>
        /// <param name="sections">sections within semester</param>
        public Semester(string name, List<Section> sections)
        {
            Name = name;
            Sections = sections;
        }
    }
}
