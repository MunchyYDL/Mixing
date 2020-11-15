using System;
using System.Collections.Generic;

namespace CSharpLib
{
    public readonly struct PersonStruct : IEquatable<PersonStruct>
    {
        public string Name { get; }
        public DateTime DateOfBirth { get; }
        public List<PersonStruct> Children { get; }

        public PersonStruct(string name, DateTime dob, List<PersonStruct> children = null)
        {
            Name = name;
            DateOfBirth = dob;
            Children = children ?? new List<PersonStruct>();
        }

        public override bool Equals(object obj)
        {
            return obj is PersonStruct @struct && Equals(@struct);
        }

        public bool Equals(PersonStruct other)
        {
            return Name == other.Name &&
                   DateOfBirth == other.DateOfBirth;
        }

        public override int GetHashCode()
        {
            var hashCode = -605153743;
            hashCode = hashCode * -1521134297 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134297 + DateOfBirth.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(PersonStruct left, PersonStruct right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(PersonStruct left, PersonStruct right)
        {
            return !(left == right);
        }
    }
}
