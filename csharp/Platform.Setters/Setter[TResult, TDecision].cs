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
        /// </summary>
        /// <param name="TrueValue">
        /// <para>A read-only field that represents a value that indicates true.</para>
        /// <para>Поле только для чтения, представляющее значение обозначающее истину.</para>
        /// </param>
        public readonly TDecision TrueValue;

        /// </summary>
        /// <param name="FalseValue">
        /// <para>A read-only field that represents a value that indicates false.</para>
        /// <para>Поле только для чтения, представляющее значение обозначающее ложь.</para>
        /// </param>
        public readonly TDecision FalseValue;

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Setter{TResult, TDecision}"/> class using the passed-in <paramref name="trueValue"/>, <paramref name="falseValue"/> and <paramref name="defaultValue"/>.</para>
        /// <para>Инициализирует новый экземпляр класса <see cref="Setter{TResult, TDecision}"/>, используя переданные значения <paramref name="trueValue"/>, <paramref name="falseValue"/> и <paramref name="defaultValue"/>.</para>
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
            TrueValue = trueValue;
            FalseValue = falseValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Setter{TResult, TDecision}"/> class using passed-in <paramref name="trueValue"/> and <paramref name="falseValue"/> as indicating true and false.</para>
        /// <para>Инициализирует новый экземпляр класса <see cref="Setter{TResult, TDecision}"/>, используя переданные значения <paramref name="trueValue"/> и <paramref name="falseValue"/> в качестве обозначающих истину и ложь.</para>
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
        /// <para>Initializes a new instance of the <see cref="Setter{TResult, TDecision}"/> class with the <see cref="Result"/> initialized to <paramref name="defaultValue"/>.</para>
        /// <para>Инициализирует новый экземпляр класса <see cref="Setter{TResult, TDecision}"/>, инициализируя <see cref="Result"/> значением <paramref name="defaultValue"/>.</para>
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
        /// <para>Sets the <paramref name="value"/> to the <see cref="Result"/> and returns the value indicating true.</para>
        /// <para>Устанавливает <paramref name="value"/> в <see cref="Result"/> и возвращает значение обозначающее истину.</para>
        /// </summary>
        /// <param name="value">
        /// <para>A result value.</para>
        /// <para>Результирующее значение.</para>
        /// </param>
        /// <returns>
        /// <para>A value that indicates true.</para>
        /// <para>Значение обозначающее истину.</para>
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetAndReturnTrue(TResult value)
        {
            _result = value;
            return TrueValue;
        }
        
        /// <summary>
        /// <para>Sets the <paramref name="value"/> to the <see cref="Result"/> and returns the value indicating false.</para>
        /// <para>Устанавливает <paramref name="value"/> как результат и возвращает значение обозначающее ложь.</para>
        /// </summary>
        /// <param name="value">
        /// <para>A result value.</para>
        /// <para>Результирующее значение.</para>
        /// </param>
        /// <returns>
        /// <para>A value that indicates false.</para>
        /// <para>Значение обозначающее ложь.</para>
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetAndReturnFalse(TResult value)
        {
            _result = value;
            return FalseValue;
        }
        
        /// <summary>
        /// <para>Sets the <paramref name="list"/> to the result and returns the value indicating true.</para>
        /// <para>Устанавливает <paramref name="list"/> в качестве результата и возвращает значение означающее истину.</para>
        /// </summary>
        /// <param name="list">
        /// <para>A list from which the first item will be set as <see cref="Result"/>.</para>
        /// <para>Список, первый элемент которого будет установлен в качестве <see cref="Result"/>.</para>
        /// </param>
        /// <returns>
        /// <para>A value that indicates true.</para>
        /// <para>Значение обозначающее истину.</para>
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetFirstAndReturnTrue(IList<TResult> list)
        {
            _result = list[0];
            return TrueValue;
        }
        
        /// <summary>
        /// <para>Sets the <paramref name="list"/> to the result and returns the value indicating false.</para>
        /// <para>Устанавливает <paramref name="list"/> в качестве результата и возвращает значение означающее ложь.</para>
        /// </summary>
        /// <param name="list">
        /// <para>A list from which the first item will be set as <see cref="Result"/>.</para>
        /// <para>Список, первый элемент которого будет установлен в качестве <see cref="Result"/>.</para>
        /// </param>
        /// <returns>
        /// <para>A value that indicates false.</para>
        /// <para>Значение обозначающее ложь.</para>
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision SetFirstAndReturnFalse(IList<TResult> list)
        {
            _result = list[0];
            return FalseValue;
        }
    }
}
