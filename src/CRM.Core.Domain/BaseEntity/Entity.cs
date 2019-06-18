using System;

namespace CRM.Core.Domain.BaseEntity
{
    public abstract class Entity<T> : IEquatable<Entity<T>>
    {
        public T Id { get; set; }

        public bool Equals(Entity<T> other)
        {
            if (other == null) return false;
            return this.Equals(other.Id);
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity<T>;
            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;
            return Id.Equals(compareTo.Id);
        }
        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 97) + Id.GetHashCode();
        }
        public override string ToString()
        {
            return GetType().Name + "[Id=" + Id + "]";
        }
    }
}
