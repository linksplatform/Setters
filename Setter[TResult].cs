using System.Runtime.CompilerServices;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Setters
{
    public class Setter<TResult> : Setter<TResult, bool>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter(TResult defaultValue) : base(true, false, defaultValue) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter() { }
    }
}
