using System.Runtime.CompilerServices;
using Platform.Interfaces;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Setters
{
    /// <summary>
    /// <para>Represents a base implementation for a setter that allows to set a passed value as the result.</para>
    /// <para>Представляет базовую реализацию для установщика, который позволяет установить переданное ему значение в качестве результата.</para>
    /// </summary>
    /// <typeparam name="TResult">
    /// <para>The type of a result value.</para>
    /// <para>Тип результирующего значения.</para>
    /// </typeparam>
    /// <remarks>
    /// <para>Must be class, not struct (in order to persist access to Result property value).</para>
    /// <para>Должен быть классом, а не структурой (чтобы сохранить доступ к значению свойства Result, при передаче ссылки на метод в качестве обработчика).</para>
    /// </remarks>
    public abstract class SetterBase<TResult> : ISetter<TResult>
    {
        /// <summary>
        /// <para>Represents a result value.</para>
        /// <para>Представляет результирующие значение.</para>
        /// </summary>
        protected TResult _result;
        
        /// <summary>
        /// <para>Gets a result value.</para>
        /// <para>Возвращает результирующее значение.</para>
        /// </summary>
        public TResult Result => _result;
        
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SetterBase"/> class.</para>
        /// <para>Инициализирует новый экземпляр класса <see cref="SetterBase"/>.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected SetterBase() { }
    
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SetterBase"/> class using the <paramref name="defaultValue"/> as the default result.</para>
        /// <para>Инициализирует новый экземпляр класса <see cref="SetterBase"/>, используя <paramref name="defaultValue"/> в качестве результата по умолчанию.</para>
        /// </summary>
        /// <param name="defaultValue">
        /// <para>A default result value.</para>
        /// <para>Результирующее значение по умолчанию.</para>
        /// </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected SetterBase(TResult defaultValue) => _result = defaultValue;
        
        /// <summary>
        /// <para>Sets a <paramref name="value"/> as the result.</para>
        /// <para>Устанавливает <paramref name="value"/> в качестве результата.</para>
        /// </summary>
        /// <param name="value">
        /// <para>A result value.</para>
        /// <para>Результирующее значение.</para>
        /// </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Set(TResult value) => _result = value;
    }
}
