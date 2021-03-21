namespace Platform::Setters::Tests
{
    TEST_CLASS(SetterTests)
    {
        public: TEST_METHOD(ParameterlessConstructedSetterTest)
        {
            Setter<std::int32_t> setter = Setter<std::int32_t>();
            Assert::AreEqual(0, setter.Result);
        }

        public: TEST_METHOD(ConstructedWithDefaultValueSetterTest)
        {
            Setter<std::int32_t> setter = Setter<std::int32_t>(9);
            Assert::AreEqual(9, setter.Result);
        }

        public: TEST_METHOD(MethodsWithBooleanReturnTypeTest)
        {
            Setter<std::int32_t> setter = Setter<std::int32_t>();
            Assert::IsTrue(setter.SetAndReturnTrue(1));
            Assert::AreEqual(1, setter.Result);
            Assert::IsFalse(setter.SetAndReturnFalse(2));
            Assert::AreEqual(2, setter.Result);
            Assert::IsTrue(setter.SetFirstAndReturnTrue(std::int32_t[] { 3 }));
            Assert::AreEqual(3, setter.Result);
            Assert::IsFalse(setter.SetFirstAndReturnFalse(std::int32_t[] { 4 }));
            Assert::AreEqual(4, setter.Result);
        }

        public: TEST_METHOD(MethodsWithIntegerReturnTypeTest)
        {
            Setter<std::int32_t, std::int32_t> setter = Setter<std::int32_t, std::int32_t>(1, 0);
            Assert::AreEqual(1, setter.SetAndReturnTrue(1));
            Assert::AreEqual(1, setter.Result);
            Assert::AreEqual(0, setter.SetAndReturnFalse(2));
            Assert::AreEqual(2, setter.Result);
            Assert::AreEqual(1, setter.SetFirstAndReturnTrue(std::int32_t[] { 3 }));
            Assert::AreEqual(3, setter.Result);
            Assert::AreEqual(0, setter.SetFirstAndReturnFalse(std::int32_t[] { 4 }));
            Assert::AreEqual(4, setter.Result);
        }
    };
}
