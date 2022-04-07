using System.Runtime.CompilerServices;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Setters
{
    /// <summary>
    /// <para>Represents a setter that allows to set a passed value as the result. This setter variant has <typeparamref name="TDecision"/> preset to <see cref="Boolean"/>.</para>
    /// <para>Представляет установщик, позволяющий устанавливать переданное ему значение в качестве результата. Для этого варианта установщика <typeparamref name="TDecision"/> предустановлен в <see cref="Boolean"/>.</para>
    /// </summary>
    /// <typeparam name="TResult">
    /// <para>The type of a result value.</para>
    /// <para>Тип результирующего значения.</para>
    /// </typeparam>
    /// <typeparam name="TDecision">
    /// <para>The type of values indicating true and false.</para>
    /// <para>Тип значений обозначающих истину и ложь.</para>
    /// </typeparam>
    /// <seealso cref="Setter{TResult, bool}"/>
    public class Setter<TResult> : Setter<TResult, bool>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Setter{TResult, bool}"/> class with the <paramref name="defaultValue"/> as a result.</para>
        /// <para>Инициализирует новый экземпляр класса <see cref="Setter{TResult, bool}"/> с <paramref name="defaultValue"/> в качестве результата.</para>
        /// </summary>
        /// <param name="defaultValue">
        /// <para>A default result value.</para>
        /// <para>Результирующее значение по умолчанию.</para>
        /// </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter(TResult defaultValue) : base(true, false, defaultValue) { }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Setter{TResult, bool}"/> class.</para>
        /// <para>Инициализирует новый экземпляр класса <see cref="Setter{TResult, bool}"/>.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter() : base(true, false) { }
    }
}
