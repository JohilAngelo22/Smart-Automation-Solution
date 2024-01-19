using System;

namespace DataVerification.DataModels
{
    public class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        //Override Equals method for custom equality comparison
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Person other = (Person)obj;
            return FirstName == other.FirstName && LastName == other.LastName;
        }

        // Override GetHashCode method when overriding Equals
        public  override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName);
        }
    }
}
