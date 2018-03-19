using System.Collections.Generic;

namespace Refactoring.ReplaceRecordWithDataClass
{
    public class Customer : Dictionary<string, string>
    {
        protected bool Equals(Customer other)
        {
            return string.Equals(this["id"], other["id"]) &&
                   string.Equals(this["name"], other["name"]);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Customer) obj);
        }

        public override int GetHashCode()
        {
            return this["id"].GetHashCode() ^ this["name"].GetHashCode();
        }
    }
}
