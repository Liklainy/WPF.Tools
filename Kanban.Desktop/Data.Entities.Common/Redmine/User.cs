﻿using System;

namespace Data.Entities.Common.Redmine
{
    public class User : IEquatable<User>, IComparable, IComparable<User>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CompareTo(User other)
        {
            return Id.CompareTo(other.Id);
        }

        public int CompareTo(object obj)
        {
            return CompareTo((User)obj);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as User);
        }

        public bool Equals(User other)
        {
            return other != null &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
