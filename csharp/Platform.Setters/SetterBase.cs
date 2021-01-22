using System.Runtime.CompilerServices;
using Platform.Interfaces;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Setters
{
    /// <summary>
    /// <para>Represents a base implementation for an setter that allows you to set a passed value to it as the resulting value.</para>
    /// <para>Представляет базовую реализацию для установщика, который позволяет установить переданное ему значение в качестве результирующего значения.</para>
    /// </summary>
    /// <remarks>
    /// Must be class, not struct (in order to persist access to Result property value).
    /// </remarks>
    public abstract class SetterBase<TResult> : ISetter<TResult>
    {
        /// <summary>
        /// <para>Represents a range between minumum and maximum values.</para>
        /// <para>Представляет диапазон между минимальным и максимальным значениями.</para>
        /// </summary>
        protected TResult _result;
        
        /// <summary>
        /// <para>Represents a range between minumum and maximum values.</para>
        /// <para>Представляет диапазон между минимальным и максимальным значениями.</para>
        /// </summary>
        public TResult Result => _result;
        
        /// <summary>
        /// <para>Initializes a new instance of the SetterBase class.</para>
        /// <para>Инициализирует новый экземпляр класса SetterBase.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected SetterBase() { }
    
        /// <summary>
        /// <para>Initializes a new instance of the SetterBase class using the passed-in value as the default result.</para>
        /// <para>Инициализирует новый экземпляр класса SetterBase, используя переданное значение в качестве результирующего по умолчанию.</para>
        /// </summary>
        /// <param name="defaultValue"><para>The default result value.</para><para>Результирующее значение по умолчанию.</para></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected SetterBase(TResult defaultValue) => _result = defaultValue;
        
        /// <summary>
        /// <para>Sets the passed value as the result.</para>
        /// <para>Устанавливает переданное значение в качестве результирующего.</para>
        /// </summary>
        /// <param name="value"><para>The result value.</para><para>Результирующее значение.</para></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Set(TResult value) => _result = value;
    }
}
