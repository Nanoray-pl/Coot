using System;
using System.Collections.Generic;

namespace Nanoray.Coot
{
    public readonly struct CompositionInfo : IEquatable<CompositionInfo>
    {
        public readonly Type ComposedType;
        public readonly IReadOnlySet<Type> ComponentTypes;

        public CompositionInfo(Type composedType, IReadOnlySet<Type> componentTypes)
        {
            this.ComposedType = composedType;
            this.ComponentTypes = componentTypes;
        }

        /// <inheritdoc/>
        public bool Equals(CompositionInfo other)
            => ComposedType == other.ComposedType && ComponentTypes.SetEquals(other.ComponentTypes);

        /// <inheritdoc/>
        public override bool Equals(object obj)
            => obj is CompositionInfo info && Equals(info);

        /// <inheritdoc/>
        public override int GetHashCode()
            => (ComposedType, ComponentTypes).GetHashCode();

        /// <inheritdoc/>
        public static bool operator ==(CompositionInfo left, CompositionInfo right)
            => left.Equals(right);

        /// <inheritdoc/>
        public static bool operator !=(CompositionInfo left, CompositionInfo right)
            => !(left == right);
    }
}
