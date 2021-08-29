using System;

namespace FYPAPI.Models
{
    public class InterestedIn: IEquatable<InterestedIn>
    {
        public int fypId { get; set; }
        public int groupId { get; set; }
        public int priority { get; set; }

        public bool Equals(InterestedIn other)
        {
            return (this.fypId == other.fypId) &&
                    (this.groupId == other.groupId) &&
                    (this.priority == other.priority);
        }
    }
}