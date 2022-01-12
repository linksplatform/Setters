using System.Collections.Generic;
using System.Runtime.CompilerServices;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Setters
{
    /// <summary>
    /// <para>Represents a setter that allows to set a passed value as the result. This setter variant has additional methods that, simultaneously with setting the result, return <typeparamref name="TDecision"/> values indicating true or false.</para>
    /// <para>Представляет реализацию для установщика, который позволяет установить переданное ему значение в качестве результата. В этой реализации установщика есть дополнительные методы, которые одновременно с установкой результата возвращают значения типа <typeparamref name="TDecision"/>, обозначающие истину или ложь.</para>
    /// </summary>
    /// <typeparam name="TResult">
    /// <para>The type of a result value.</para>
    /// <para>Тип результирующего значения.</para>
    /// </typeparam>
    /// <typeparam name="TDecision">
    /// <para>The type of values indicating true and false.</para>
    /// <para>Тип значений обозначающих истину и ложь.</para>
    /// </typeparam>
    public class Setter<TResult, TDecision> : SetterBase<TResult>
    {
        private readonly TDecision _trueValue;
        
        private readonly TDecision _falseValue;
        
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Setter{TResult, TDecision}"/> class using the passed-in <paramref name="trueValue"/>, <paramref name="falseValue"/>, <paramref name="defaultValue"/> values as <paramref name="defaultValue"/>.</para>
        /// <para>Инициализирует новый экземпляр класса <see cref="Setter{TResult, TDecision}"/>, используя переданные значения <paramref name="trueValue"/>, <paramref name="falseValue"/>, <paramref name="defaultValue"/> в качестве <paramref name="defaultValue"/>.</para>
        /// </summary>
        /// <param name="trueValue">
        /// <para>A value that indicates true.</para>
        /// <para>Значение обозначающее истину.</para>
        /// </param>
        /// <param name="falseValue">
        /// <para>A value that indicates false.</para>
        /// <para>Значение обозначающее ложь.</para>
        /// </param>
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
        /// <para>Initializes a new instance of the <see cref="Setter{TResult, TDecision}"/> class using passed-in <paramref name="trueValue"/> and <paramref name="falseValue"/> as indicating true and false.</para>
        /// <para>Иницаилизирует новый экземпляр класса <see cref="Setter{TResult, TDecision}"/>, используя переданные значения <paramref name="trueValue"/> и <paramref name="falseValue"/> в качестве обозначающих истину и ложь.</para>
        /// </summary>
        /// <param name="trueValue">
        /// <para>A value that indicates true.</para>
        /// <para>Значение обозначающее истину.</para>
        /// </param>
        /// <param name="falseValue">
        /// <para>A value that indicates false.</para>
        /// <para>Значение обозначающее ложь.</para>
        /// </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter(TDecision trueValue, TDecision falseValue) : this(trueValue, falseValue, default) { }
        
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Setter{TResult, TDecision}"/> class with the <paramref name="defaultValue"/> as a result.</para>
        /// <para>Инициализирует новый экземпляр класса <see cref="Setter{TResult, TDecision}"/>, используя значение <paramref name="defaultValue"/> в качестве результата по умолчанию.</para>
        /// </summary>
        /// <param name="defaultValue">
        /// <para>A default result value.</para>
        /// <para>Результирующее значение по умолчанию.</para>
        /// </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter(TResult defaultValue) : base(defaultValue) { }
        
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Setter{TResult, TDecision}"/> class.</para>
        /// <para>Инициализирует новый экземпляр класса <see cref="Setter{TResult, TDecision}"/>.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter() { }
        
        /// <summary>
        /// <para>Sets the <paramref name="value"/> to the result and returns the value indicating true.</para>
        /// <para>Устанавливает <paramref name="value"/> в качестве результата и возвращает значение означающее истину.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetAndReturnTrue(TResult value)
        {
            _result = value;
            return _trueValue;
        }
        
        /// <summary>
        /// <para>Sets the <paramref name="value"/> to the result and returns the value indicating false.</para>
        /// <para>Устанавливает <paramref name="value"/> в качестве результата и возвращает значение означающее ложь.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetAndReturnFalse(TResult value)
        {
            _result = value;
            return _falseValue;
        }
        
        /// <summary>
        /// <para>Sets the <paramref name="list[0]"/> to the result and returns the value indicating true.</para>
        /// <para>Устанавливает <paramref name="list[0]"/> в качестве результата и возвращает значение означающее истину.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetFirstAndReturnTrue(IList<TResult> list)
        {
            _result = list[0];
            return _trueValue;
        }
        
        /// <summary>
        /// <para>Sets the <paramref name="list[0]"/> to the result and returns the value indicating false.</para>
        /// <para>Устанавливает <paramref name="list[0]"/> в качестве результата и возвращает значение означающее ложь.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetFirstAndReturnFalse(IList<TResult> list)
        {
            _result = list[0];
            return _falseValue;
        }
    }
}
