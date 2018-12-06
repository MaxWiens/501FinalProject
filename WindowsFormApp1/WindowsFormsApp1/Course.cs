
namespace SVTApp
{
    /// <summary>
    /// Course
    /// </summary>
    class Course
    {
        public string Subject { get; private set; }
        public int CatalogNumber { get; private set; }
        public string Description { get; private set; }

        /// <summary>
        /// Course constructor assigning all properties
        /// </summary>
        /// <param name="subject">course subject</param>
        /// <param name="catalogNumber">course catalog number</param>
        /// <param name="description">course description</param>
        public Course(string subject, int catalogNumber, string description)
        {
            Subject = subject;
            CatalogNumber = catalogNumber;
            Description = description;
        }

        /// <summary>
        /// Courses are equal if they share the smae subject, catalog number and description
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() == GetType())
            {
                Course c = (Course)obj;
                return Subject.Equals(c.Subject) && CatalogNumber == c.CatalogNumber && Description.Equals(c.Description);
            }
            return base.Equals(obj);
        }
    }
}
