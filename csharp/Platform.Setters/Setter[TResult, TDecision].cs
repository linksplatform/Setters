using System.Collections.Generic;
using System.Runtime.CompilerServices;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Setters
{
    /// <summary>
    /// <para>Represents implementation for an setter that allows to set a passed value as the result. This setter implementation has additional methods that, simultaneously with setting the result, return <typeparamref name="TDecision"/> values indicating true or false.</para>
    /// <para>Представляет реализацию для установщика, который позволяет установить переданное ему значение в качестве результата. В этой реализации установщика есть дополнительные методы, которые одновременно с установкой результата возвращают значения типа <typeparamref name="TDecision"/>, обозначающие истину или ложь.</para>
    /// </summary>
    /// <typeparam name="TResult">
    /// <para>The type of a result value.</para>
    /// <para>Тип результирующего значения.</para>
    /// </typeparam>
    /// <typeparam name="TDecision">
    /// <para>The type of a true and false value.</para>
    /// <para>Тип значений "истина" и "ложь".</para>
    /// </typeparam>
    public class Setter<TResult, TDecision> : SetterBase<TResult>
    {
        /// <summary>
        /// <para>A true value.</para>
        /// <para>Значение "истина".</para>
        /// </summary>
        private readonly TDecision _trueValue;
        
        /// <summary>
        /// <para>A false value.</para>
        /// <para>Значение "ложь".</para>
        /// </summary>
        private readonly TDecision _falseValue;

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Setter{TResult, TDecision}"/> class using the passed-in value as the default result.</para>
        /// <para>Инициализирует новый экземпляр класса <see cref="Setter{TResult, TDecision}"/>, используя переданные значения trueValue, falseValue, defaultValue в качестве результата по умолчанию.</para>
        /// </summary>
        /// <param name="defaultValue">
        /// <para>A default result value.</para>
        /// <para>Результирующее значение по умолчанию.</para>
        /// </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter(TDecision trueValue, TDecision falseValue, TResult defaultValue)
            : base(defaultValue)
        {
            _trueValue = trueValue;
            _falseValue = falseValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Setter{TResult, TDecision}"/> class.</para>
        /// <para>Иницаилизирует новый экземпляр класса <see cref="Setter{TResult, TDecision}"/>.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter(TDecision trueValue, TDecision falseValue) : this(trueValue, falseValue, default) { }
        
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Setter{TResult, TDecision}"/> class with the <paramref name="defaultValue"/> as a result.</para>
        /// <para>Инициализирует новый экземпляр класса <see cref="Setter{TResult, TDecision}"/>, со значением <paramref name="defaultValue"/> в качестве результата по умолчанию.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter(TResult defaultValue) : base(defaultValue) { }
        
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Setter{TResult, TDecision}"/> class.</para>
        /// <para>Инициализирует новый экземпляр класса <see cref="Setter{TResult, TDecision}"/>.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter() { }
        
        /// <summary>
        /// <para>Assigns the <paramref name="value"/> to the result and returns true value.</para>
        /// <para>Присваивает результату значение <paramref name="value"/> и возвращает истина-значение.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetAndReturnTrue(TResult value)
        {
            _result = value;
            return _trueValue;
        }
        
        /// <summary>
        /// <para>Assigns the <paramref name="value"/> to the result and returns false value.</para>
        /// <para>Присваивает результату значение <paramref name="value"/> и возвращает ложь-значение.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetAndReturnFalse(TResult value)
        {
            _result = value;
            return _falseValue;
        }
        
        /// <summary>
        /// <para>Assigns the <paramref name="list[0]"/> to the result and returns true value.</para>
        /// <para>Присваивает результату значение <paramref name="list[0]"/> и возвращает истина-значение.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetFirstAndReturnTrue(IList<TResult> list)
        {
            _result = list[0];
            return _trueValue;
        }
        
        /// <summary>
        /// <para>Assigns the <paramref name="list[0]"/> to the result and returns false value.</para>
        /// <para>Присваивает результату значение <paramref name="list[0]"/> и возвращает ложь-значение.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetFirstAndReturnFalse(IList<TResult> list)
        {
            _result = list[0];
            return _falseValue;
        }
    }
}
