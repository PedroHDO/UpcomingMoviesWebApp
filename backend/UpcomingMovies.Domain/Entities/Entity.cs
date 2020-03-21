using System;
using System.Collections.Generic;
using System.Text;

namespace UpcomingMovies.Domain.Entities
{
    public class Entity
    {
        public int Id { get; protected set; }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;

            if (compareTo is null) return false;
            if (ReferenceEquals(this, compareTo)) return true;

            return Id.Equals(compareTo.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
