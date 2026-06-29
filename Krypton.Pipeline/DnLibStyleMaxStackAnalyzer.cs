using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Krypton.Pipeline.Stages
{
    internal sealed class ObjectReferenceEqualityComparer<T> : IEqualityComparer<T>
        where T : class
    {
        public static readonly ObjectReferenceEqualityComparer<T> Instance =
            new ObjectReferenceEqualityComparer<T>();

        private ObjectReferenceEqualityComparer()
        {
        }

        public bool Equals(T x, T y)
        {
            return ReferenceEquals(x, y);
        }

        public int GetHashCode(T obj)
        {
            return RuntimeHelpers.GetHashCode(obj);
        }
    }
}