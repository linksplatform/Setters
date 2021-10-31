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
        /// <summary>
        /// <para>
        /// The true value.
        /// </para>
        /// <para>
        /// Значение "истина".
        /// </para>
        /// </summary>
        private readonly TDecision _trueValue;
        /// <summary>
        /// <para>
        /// The false value.
        /// </para>
        /// <para>
        /// Значение "ложь".
        /// </para>
        /// </summary>
        private readonly TDecision _falseValue;

        /// <summary>
        /// <para>Initializes a new instance of the Setter class using the passed-in value as the default result value.</para>
        /// <para>Инициализирует новый экземпляр класса Setter, используя переданные значения trueValue, falseValue, defaultValue в качестве результирующего по умолчанию.</para>
        /// </summary>
        /// <param name="defaultValue"><para>The default result value.</para><para>Результирующее значение по умолчанию.</para></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter(TDecision trueValue, TDecision falseValue, TResult defaultValue)
            : base(defaultValue)
        {
            _trueValue = trueValue;
            _falseValue = falseValue;
        }

        /// <summary>
        /// <para>Returns result value.</para>
        /// <para>Возвращает результирующее значение.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter(TDecision trueValue, TDecision falseValue) : this(trueValue, falseValue, default) { }
        
        /// <summary>
        /// <para>Returns result value.</para>
        /// <para>Возвращает результирующее значение.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter(TResult defaultValue) : base(defaultValue) { }
        
        /// <summary>
        /// <para>Returns result value.</para>
        /// <para>Возвращает результирующее значение.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter() { }
        
        /// <summary>
        /// <para>Returns result value.</para>
        /// <para>Возвращает результирующее значение.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetAndReturnTrue(TResult value)
        {
            _result = value;
            return _trueValue;
        }
        
        /// <summary>
        /// <para>Returns result value.</para>
        /// <para>Возвращает результирующее значение.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetAndReturnFalse(TResult value)
        {
            _result = value;
            return _falseValue;
        }
        
        /// <summary>
        /// <para>Returns result value.</para>
        /// <para>Возвращает результирующее значение.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetFirstAndReturnTrue(IList<TResult> list)
        {
            _result = list[0];
            return _trueValue;
        }
        
        /// <summary>
        /// <para>Returns result value.</para>
        /// <para>Возвращает результирующее значение.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetFirstAndReturnFalse(IList<TResult> list)
        {
            _result = list[0];
            return _falseValue;
        }
    }
}
