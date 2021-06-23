#include <gtest/gtest.h>
#include <Platform.Setters.h>
namespace Platform::Setters::Tests
{
		TEST(SettersTests, ParameterlessConstructedSetterTest)
		{
			Setter<std::int32_t> setter = Setter<std::int32_t>();
			ASSERT_EQ(0, setter.Result());
		}

		TEST(SettersTests, ConstructedWithDefaultValueSetterTest)
		{
			Setter<std::int32_t> setter = Setter<std::int32_t>(9);
			ASSERT_EQ(9, setter.Result());
		}

		TEST(SettersTests, MethodsWithBooleanReturnTypeTest)
		{
			Setter<std::int32_t> setter = Setter<std::int32_t>();
			ASSERT_TRUE(setter.SetAndReturnTrue(1));
			ASSERT_EQ(1, setter.Result());
			ASSERT_FALSE(setter.SetAndReturnFalse(2));
			ASSERT_EQ(2, setter.Result());
			ASSERT_TRUE(setter.SetFirstAndReturnTrue(std::int32_t[]{ 3 }));
			ASSERT_EQ(3, setter.Result());
			ASSERT_FALSE(setter.SetFirstAndReturnFalse(std::int32_t[] { 4 }));
			ASSERT_EQ(4, setter.Result());
		}

		TEST(SettersTests, MethodsWithIntegerReturnTypeTest)
		{
			Setter<std::int32_t, std::int32_t> setter = Setter<std::int32_t, std::int32_t>(1, 0);
			ASSERT_EQ(1, setter.SetAndReturnTrue(1));
			ASSERT_EQ(1, setter.Result());
			ASSERT_EQ(0, setter.SetAndReturnFalse(2));
			ASSERT_EQ(2, setter.Result());
			ASSERT_EQ(1, setter.SetFirstAndReturnTrue(std::int32_t[] { 3 }));
			ASSERT_EQ(3, setter.Result());
			ASSERT_EQ(0, setter.SetFirstAndReturnFalse(std::int32_t[] { 4 }));
			ASSERT_EQ(4, setter.Result());
		}
}
