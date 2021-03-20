using System.Collections.Generic;
using System.Runtime.CompilerServices;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Setters
{
    /// <summary>
    /// <para>Represents implementation for an setter that allows you to set a passed value as the result value. This setter implementation has additional methods that, simultaneously with setting the result value, return <typeparamref name="TDecision"/> values indicating true or false.</para>
    /// <para>Представляет реализацию для установщика, который позволяет установить переданное ему значение в качестве результирующего значения. В этой реализации установщика есть дополнительные методы, которые одновременно с установкой результирующего значения возвращают значения типа <typeparamref name="TDecision"/>, обозначающие истину или ложь.</para>
    /// </summary>
    /// <typeparam name="TResult"><para>The type of result value.</para><para>Тип результирующего значения.</para></typeparam>
    /// <typeparam name="TDecision"><para>The type of value which will be used to make the decision.</para><para>Тип значения на основе которого будет приниматься решение.</para></typeparam>
    public class Setter<TResult, TDecision> : SetterBase<TResult>
    {
        private readonly TDecision _trueValue;
        private readonly TDecision _falseValue;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter(TDecision trueValue, TDecision falseValue, TResult defaultValue)
            : base(defaultValue)
        {
            _trueValue = trueValue;
            _falseValue = falseValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter(TDecision trueValue, TDecision falseValue) : this(trueValue, falseValue, default) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter(TResult defaultValue) : base(defaultValue) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter() { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetAndReturnTrue(TResult value)
        {
            _result = value;
            return _trueValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetAndReturnFalse(TResult value)
        {
            _result = value;
            return _falseValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetFirstAndReturnTrue(IList<TResult> list)
        {
            _result = list[0];
            return _trueValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetFirstAndReturnFalse(IList<TResult> list)
        {
            _result = list[0];
            return _falseValue;
        }
    }
}
