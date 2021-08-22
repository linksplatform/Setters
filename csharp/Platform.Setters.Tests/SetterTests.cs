using Xunit;

namespace Platform.Setters.Tests
{
    /// <summary>
    /// <para>
    /// Represents the setter tests.
    /// </para>
    /// <para></para>
    /// </summary>
    public class SetterTests
    {
        /// <summary>
        /// <para>
        /// Tests that parameterless constructed setter test.
        /// </para>
        /// <para></para>
        /// </summary>
        [Fact]
        public void ParameterlessConstructedSetterTest()
        {
            Setter<int> setter = new Setter<int>();
            Assert.Equal(default, setter.Result);
        }

        /// <summary>
        /// <para>
        /// Tests that constructed with default value setter test.
        /// </para>
        /// <para></para>
        /// </summary>
        [Fact]
        public void ConstructedWithDefaultValueSetterTest()
        {
            Setter<int> setter = new Setter<int>(9);
            Assert.Equal(9, setter.Result);
        }

        /// <summary>
        /// <para>
        /// Tests that methods with boolean return type test.
        /// </para>
        /// <para></para>
        /// </summary>
        [Fact]
        public void MethodsWithBooleanReturnTypeTest()
        {
            Setter<int> setter = new Setter<int>();
            Assert.True(setter.SetAndReturnTrue(1));
            Assert.Equal(1, setter.Result);
            Assert.False(setter.SetAndReturnFalse(2));
            Assert.Equal(2, setter.Result);
            Assert.True(setter.SetFirstAndReturnTrue(new int[] { 3 }));
            Assert.Equal(3, setter.Result);
            Assert.False(setter.SetFirstAndReturnFalse(new int[] { 4 }));
            Assert.Equal(4, setter.Result);
        }

        /// <summary>
        /// <para>
        /// Tests that methods with integer return type test.
        /// </para>
        /// <para></para>
        /// </summary>
        [Fact]
        public void MethodsWithIntegerReturnTypeTest()
        {
            Setter<int, int> setter = new Setter<int, int>(1, 0);
            Assert.Equal(1, setter.SetAndReturnTrue(1));
            Assert.Equal(1, setter.Result);
            Assert.Equal(0, setter.SetAndReturnFalse(2));
            Assert.Equal(2, setter.Result);
            Assert.Equal(1, setter.SetFirstAndReturnTrue(new int[] { 3 }));
            Assert.Equal(3, setter.Result);
            Assert.Equal(0, setter.SetFirstAndReturnFalse(new int[] { 4 }));
            Assert.Equal(4, setter.Result);
        }
    }
}
