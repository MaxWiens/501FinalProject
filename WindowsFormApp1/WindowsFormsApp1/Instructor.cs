
namespace SVTApp
{
    /// <summary>
    /// University Instructor
    /// </summary>
    class Instructor
    {
        public string Name { get; set; }

        /// <summary>
        /// Instructor constructor
        /// </summary>
        /// <param name="name">name of instructor</param>
        public Instructor(string name)
        {
            Name = name;
        }

        /// <summary>
        /// A Instructor is equal if they have the same name
        /// </summary>
        /// <param name="obj">object to compare</param>
        /// <returns>true if equal</returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() == GetType())
            {
                return Name.Equals(((Instructor)obj).Name);
            }
            return base.Equals(obj);
        }
    }
}
