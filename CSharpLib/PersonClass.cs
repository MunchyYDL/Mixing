using System;
using System.Collections.Generic;

namespace CSharpLib
{
    public class PersonClass : IEquatable<PersonClass>
    {
        public string Name { get; }
        public DateTime DateOfBirth { get; }
        public List<PersonClass> Children { get; }

        public PersonClass(string name, DateTime dob, List<PersonClass> children = null)
        {
            Name = name;
            DateOfBirth = dob;
            Children = children ?? new List<PersonClass>();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as PersonClass);
        }

        public bool Equals(PersonClass other)
        {
            return other != null &&
                   Name == other.Name &&
                   DateOfBirth == other.DateOfBirth;
        }

        public override int GetHashCode()
        {
            var hashCode = -605153749;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + DateOfBirth.GetHashCode();
            return hashCode;
        }
    }
}
