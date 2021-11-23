using System.Runtime.CompilerServices;
using Platform.Interfaces;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Setters
{
    /// <summary>
    /// <para>Provides a base class that allows to set a passed value as the result value.</para>
    /// <para>Предоставляет базовый класс, который позволяет установить переданное ему значение в качестве результирующего значения.</para>
    /// </summary>
    /// <typeparam name="TResult">
    /// <para>The type of a result value.</para>
    /// <para>Тип результирующего значения.</para>
    /// </typeparam>
    /// <remarks>
    /// <para>Must be class, not struct (in order to persist access to Result property value).</para>
    /// <para>Является классом, не структурой (чтобы сохранить доступ к значению свойства Result).</para>
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
        /// <para>Инициализирует новый экземпляр класса <see cref="SetterBase{TResult}"/>.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected SetterBase() { }
    
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SetterBase{TResult}"/> class using the passed-in value as the default result value.</para>
        /// <para>Инициализирует новый экземпляр класса <see cref="SetterBase{TResult}"/>, используя переданное значение в качестве результирующего по умолчанию.</para>
        /// </summary>
        /// <param name="defaultValue">
        /// <para>A default result value.</para>
        /// <para>Результирующее значение по умолчанию.</para>
        /// </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected SetterBase(TResult defaultValue) => _result = defaultValue;
        
        /// <summary>
        /// <para>Sets a <paramref name="value"/> as the result.</para>
        /// <para>Устанавливает переданное значение в качестве результирующего.</para>
        /// </summary>
        /// <param name="value">
        /// <para>A result value.</para>
        /// <para>Результирующее значение.</para>
        /// </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Set(TResult value) => _result = value;
    }
}
