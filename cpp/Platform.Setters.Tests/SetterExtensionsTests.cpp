namespace Platform::Setters::Tests
{
    TEST(SetterExtensionsTests, SetFirstFromListAndReturnTrue)
    {
        std::int32_t list { 1,2,3 };
        auto setter = Setter<std::int32_t>();
        bool decision = setter.SetFirstFromListAndReturnTrue(list);
        ASSERT_EQ(setter.GetTrue(), decision);
        ASSERT_EQ(list[0], setter.Result());
    }

    TEST(SetterExtensionsTests, SetFirstFromFirstListAndReturnTrue)
    {
        std::int32_t list { 1,2,3 };
        auto setter = Setter<std::int32_t>();
        bool decision = setter.SetFirstFromFirstListAndReturnTrue(list, list);
        ASSERT_EQ(setter.GetTrue(), decision);
        ASSERT_EQ(list[0], setter.Result());
    }

    TEST(SetterExtensionsTests, SetSecondFromFirstListAndReturnTrue)
    {
        std::int32_t list { 1,2,3 };
        auto setter = Setter<std::int32_t>();
        bool decision = setter.SetSecondFromFirstListAndReturnTrue(list, list);
        ASSERT_EQ(setter.GetTrue(), decision);
        ASSERT_EQ(list[1], setter.Result());
    }

    TEST(SetterExtensionsTests, SetThirdFromFirstListAndReturnTrue)
    {
        std::int32_t list { 1,2,3 };
        auto setter = Setter<std::int32_t>();
        bool decision = setter.SetThirdFromFirstListAndReturnTrue(list, list);
        ASSERT_EQ(setter.GetTrue(), decision);
        ASSERT_EQ(list[2], setter.Result());
    }

    TEST(SetterExtensionsTests, SetFirstFromFirstListAndReturnTrue)
    {
        std::int32_t list1 { 1,2,3 };
        std::int32_t list2 { 4,5,6 };
        auto setter = Setter<std::int32_t>();
        bool decision = setter.SetFirstFromFirstListAndReturnTrue(list1, list2);
        ASSERT_EQ(setter.GetTrue(), decision);
        ASSERT_EQ(list1[0], setter.Result());
    }

    TEST(SetterExtensionsTests, SetSecondFromFirstListAndReturnTrue)
    {
        std::int32_t list1 { 1,2,3 };
        std::int32_t list2 { 4,5,6 };
        auto setter = Setter<std::int32_t>();
        bool decision = setter.SetSecondFromFirstListAndReturnTrue(list1, list2);
        ASSERT_EQ(setter.GetTrue(), decision);
        ASSERT_EQ(list1[1], setter.Result());
    }

    TEST(SetterExtensionsTests, SetFirstFromFirstListAndReturnTrue)
    {
        std::int32_t list1 { 1,2,3 };
        std::int32_t list2 { 4,5,6 };
        auto setter = Setter<std::int32_t>();
        bool decision = setter.SetFirstFromFirstListAndReturnTrue(list1, list2);
        ASSERT_EQ(setter.GetTrue(), decision);
        ASSERT_EQ(list1[2], setter.Result());
    }

    TEST(SetterExtensionsTests, SetFirstFromSecondListAndReturnTrue)
    {
        std::int32_t list1 { 1,2,3 };
        std::int32_t list2 { 4,5,6 };
        auto setter = Setter<std::int32_t>();
        bool decision = setter.SetFirstFromSecondListAndReturnTrue(list1, list2);
        ASSERT_EQ(setter.GetTrue(), decision);
        ASSERT_EQ(list2[0], setter.Result());
    }

    TEST(SetterExtensionsTests, SetSecondFromSecondListAndReturnTrue)
    {
        std::int32_t list1 { 1,2,3 };
        std::int32_t list2 { 4,5,6 };
        auto setter = Setter<std::int32_t>();
        bool decision = setter.SetSecondFromSecondListAndReturnTrue(list1, list2);
        ASSERT_EQ(setter.GetTrue(), decision);
        ASSERT_EQ(list2[1], setter.Result());
    }

    TEST(SetterExtensionsTests, SetThirdFromSecondListAndReturnTrue)
    {
        std::int32_t list1 { 1,2,3 };
        std::int32_t list2 { 4,5,6 };
        auto setter = Setter<std::int32_t>();
        bool decision = setter.SetThirdFromSecondListAndReturnTrue(list1, list2);
        ASSERT_EQ(setter.GetTrue(), decision);
        ASSERT_EQ(list2[2], setter.Result());
    }
}
