using System.Collections.Generic;
using Xunit;

namespace Platform.Setters.Tests
{
    public class SetterTests
    {
        [Fact]
        public void ParameterlessConstructedSetterTest()
        {
            Setter<int> setter = new Setter<int>();
            Assert.Equal(default, setter.Result);
        }

        [Fact]
        public void ConstructedWithDefaultValueSetterTest()
        {
            Setter<int> setter = new Setter<int>(9);
            Assert.Equal(9, setter.Result);
        }

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

        [Fact]
        public void SetterBaseSetMethodTest()
        {
            Setter<string> setter = new Setter<string>();
            setter.Set("test");
            Assert.Equal("test", setter.Result);
        }

        [Fact]
        public void SetterWithTDecisionParameterlessConstructorTest()
        {
            Setter<int, int> setter = new Setter<int, int>();
            Assert.Equal(default, setter.Result);
            Assert.Equal(default, setter.TrueValue);
            Assert.Equal(default, setter.FalseValue);
        }

        [Fact]
        public void SetterWithTDecisionDefaultValueConstructorTest()
        {
            Setter<string, bool> setter = new Setter<string, bool>("default");
            Assert.Equal("default", setter.Result);
            Assert.Equal(default, setter.TrueValue);
            Assert.Equal(default, setter.FalseValue);
        }

        [Fact]
        public void SetterWithTDecisionTrueAndFalseValuesConstructorTest()
        {
            Setter<int, string> setter = new Setter<int, string>("success", "failure");
            Assert.Equal(default, setter.Result);
            Assert.Equal("success", setter.TrueValue);
            Assert.Equal("failure", setter.FalseValue);
        }

        [Fact]
        public void SetterWithTDecisionFullConstructorTest()
        {
            Setter<int, string> setter = new Setter<int, string>("success", "failure", 42);
            Assert.Equal(42, setter.Result);
            Assert.Equal("success", setter.TrueValue);
            Assert.Equal("failure", setter.FalseValue);
        }

        [Fact]
        public void SetFirstAndReturnTrueWithNullListTest()
        {
            Setter<int> setter = new Setter<int>(100);
            bool result = setter.SetFirstAndReturnTrue(null);
            Assert.True(result);
            Assert.Equal(100, setter.Result); // Should remain unchanged
        }

        [Fact]
        public void SetFirstAndReturnFalseWithNullListTest()
        {
            Setter<int> setter = new Setter<int>(100);
            bool result = setter.SetFirstAndReturnFalse(null);
            Assert.False(result);
            Assert.Equal(100, setter.Result); // Should remain unchanged
        }

        [Fact]
        public void SetFirstAndReturnTrueWithCustomTDecisionTest()
        {
            Setter<string, int> setter = new Setter<string, int>(1, 0);
            int result = setter.SetFirstAndReturnTrue(new string[] { "test" });
            Assert.Equal(1, result);
            Assert.Equal("test", setter.Result);
        }

        [Fact]
        public void SetFirstAndReturnFalseWithCustomTDecisionTest()
        {
            Setter<string, int> setter = new Setter<string, int>(1, 0);
            int result = setter.SetFirstAndReturnFalse(new string[] { "test" });
            Assert.Equal(0, result);
            Assert.Equal("test", setter.Result);
        }
    }

    public class SetterExtensionsTests
    {
        [Fact]
        public void SetFirstFromNonNullListAndReturnTrueTest()
        {
            var setter = new Setter<int, string>("success", "failure");
            var list = new List<int> { 1, 2, 3 };
            
            string result = setter.SetFirstFromNonNullListAndReturnTrue(list);
            
            Assert.Equal("success", result);
            Assert.Equal(1, setter.Result);
        }

        [Fact]
        public void SetFirstFromNonNullListAndReturnTrueWithNullListTest()
        {
            var setter = new Setter<int, string>("success", "failure", 42);
            
            string result = setter.SetFirstFromNonNullListAndReturnTrue(null);
            
            Assert.Equal("success", result);
            Assert.Equal(42, setter.Result); // Should remain unchanged
        }

        [Fact]
        public void SetFirstFromNonNullFirstListAndReturnTrueTest()
        {
            var setter = new Setter<string, bool>(true, false);
            var list1 = new List<string> { "first", "second" };
            var list2 = new List<string> { "third", "fourth" };
            
            bool result = setter.SetFirstFromNonNullFirstListAndReturnTrue(list1, list2);
            
            Assert.True(result);
            Assert.Equal("first", setter.Result);
        }

        [Fact]
        public void SetFirstFromNonNullFirstListAndReturnTrueWithNullFirstListTest()
        {
            var setter = new Setter<string, bool>(true, false, "default");
            var list2 = new List<string> { "third", "fourth" };
            
            bool result = setter.SetFirstFromNonNullFirstListAndReturnTrue(null, list2);
            
            Assert.True(result);
            Assert.Equal("default", setter.Result); // Should remain unchanged
        }

        [Fact]
        public void SetSecondFromNonNullFirstListAndReturnTrueTest()
        {
            var setter = new Setter<int, char>('T', 'F');
            var list1 = new List<int> { 10, 20, 30 };
            var list2 = new List<int> { 40, 50 };
            
            char result = setter.SetSecondFromNonNullFirstListAndReturnTrue(list1, list2);
            
            Assert.Equal('T', result);
            Assert.Equal(20, setter.Result);
        }

        [Fact]
        public void SetSecondFromNonNullFirstListAndReturnTrueWithNullFirstListTest()
        {
            var setter = new Setter<int, char>('T', 'F', 99);
            var list2 = new List<int> { 40, 50 };
            
            char result = setter.SetSecondFromNonNullFirstListAndReturnTrue(null, list2);
            
            Assert.Equal('T', result);
            Assert.Equal(99, setter.Result); // Should remain unchanged
        }

        [Fact]
        public void SetThirdFromNonNullFirstListAndReturnTrueTest()
        {
            var setter = new Setter<double, byte>(1, 0);
            var list1 = new List<double> { 1.1, 2.2, 3.3, 4.4 };
            var list2 = new List<double> { 5.5, 6.6 };
            
            byte result = setter.SetThirdFromNonNullFirstListAndReturnTrue(list1, list2);
            
            Assert.Equal(1, result);
            Assert.Equal(3.3, setter.Result);
        }

        [Fact]
        public void SetThirdFromNonNullFirstListAndReturnTrueWithNullFirstListTest()
        {
            var setter = new Setter<double, byte>(1, 0, 9.9);
            var list2 = new List<double> { 5.5, 6.6 };
            
            byte result = setter.SetThirdFromNonNullFirstListAndReturnTrue(null, list2);
            
            Assert.Equal(1, result);
            Assert.Equal(9.9, setter.Result); // Should remain unchanged
        }

        [Fact]
        public void SetFirstFromNonNullSecondListAndReturnTrueTest()
        {
            var setter = new Setter<string, int>(100, 0);
            var list1 = new List<string> { "first", "second" };
            var list2 = new List<string> { "third", "fourth" };
            
            int result = setter.SetFirstFromNonNullSecondListAndReturnTrue(list1, list2);
            
            Assert.Equal(100, result);
            Assert.Equal("third", setter.Result);
        }

        [Fact]
        public void SetFirstFromNonNullSecondListAndReturnTrueWithNullSecondListTest()
        {
            var setter = new Setter<string, int>(100, 0, "default");
            var list1 = new List<string> { "first", "second" };
            
            int result = setter.SetFirstFromNonNullSecondListAndReturnTrue(list1, null);
            
            Assert.Equal(100, result);
            Assert.Equal("default", setter.Result); // Should remain unchanged
        }

        [Fact]
        public void SetSecondFromNonNullSecondListAndReturnTrueTest()
        {
            var setter = new Setter<float, long>(1L, -1L);
            var list1 = new List<float> { 1.0f, 2.0f };
            var list2 = new List<float> { 3.0f, 4.0f, 5.0f };
            
            long result = setter.SetSecondFromNonNullSecondListAndReturnTrue(list1, list2);
            
            Assert.Equal(1L, result);
            Assert.Equal(4.0f, setter.Result);
        }

        [Fact]
        public void SetSecondFromNonNullSecondListAndReturnTrueWithNullSecondListTest()
        {
            var setter = new Setter<float, long>(1L, -1L, 9.9f);
            var list1 = new List<float> { 1.0f, 2.0f };
            
            long result = setter.SetSecondFromNonNullSecondListAndReturnTrue(list1, null);
            
            Assert.Equal(1L, result);
            Assert.Equal(9.9f, setter.Result); // Should remain unchanged
        }

        [Fact]
        public void SetThirdFromNonNullSecondListAndReturnTrueTest()
        {
            var setter = new Setter<char, bool>(true, false);
            var list1 = new List<char> { 'a', 'b' };
            var list2 = new List<char> { 'x', 'y', 'z', 'w' };
            
            bool result = setter.SetThirdFromNonNullSecondListAndReturnTrue(list1, list2);
            
            Assert.True(result);
            Assert.Equal('z', setter.Result);
        }

        [Fact]
        public void SetThirdFromNonNullSecondListAndReturnTrueWithNullSecondListTest()
        {
            var setter = new Setter<char, bool>(true, false, 'X');
            var list1 = new List<char> { 'a', 'b' };
            
            bool result = setter.SetThirdFromNonNullSecondListAndReturnTrue(list1, null);
            
            Assert.True(result);
            Assert.Equal('X', setter.Result); // Should remain unchanged
        }
    }
}
