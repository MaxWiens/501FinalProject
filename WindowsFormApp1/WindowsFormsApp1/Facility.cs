
namespace SVTApp
{
    /// <summary>
    /// University Facility
    /// </summary>
    class Facility
    {
        public string FacilityID { get; private set; }

        /// <summary>
        /// Facility Constructor
        /// </summary>
        /// <param name="id">The ID of the facility</param>
        public Facility(string id)
        {
            FacilityID = id;
        }

        /// <summary>
        /// A Facility is equal to annother if it has the smae Facility ID
        /// </summary>
        /// <param name="obj">object to compare</param>
        /// <returns>true if equal</returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() == GetType())
            {
                return FacilityID.Equals(((Facility)obj).FacilityID);
            }
            return base.Equals(obj);
        }
    }
}