using TLinkAddress = std::int32_t;

namespace Platform::Setters::Tests
{
    TEST(SetterExtensionsTests, SetFirstFromFirstListAndReturnTrue)
    {
        TLinkAddress list1[] { 1,2,3 };
        TLinkAddress list2[] { 4,5,6 };
        Setter<TLinkAddress> setter {};
        bool decision { SetterExtensions::SetFirstFromFirstListAndReturnTrue(setter, list1, list2) };
        ASSERT_EQ(setter.GetTrue(), decision);
        ASSERT_EQ(list1[0], setter.Result());
    }

    TEST(SetterExtensionsTests, SetSecondFromFirstListAndReturnTrue)
    {
        TLinkAddress list1[] { 1,2,3 };
        TLinkAddress list2[] { 4,5,6 };
        Setter<TLinkAddress> setter {};
        bool decision { SetterExtensions::SetSecondFromFirstListAndReturnTrue(setter, list1, list2) };
        ASSERT_EQ(setter.GetTrue(), decision);
        ASSERT_EQ(list1[1], setter.Result());
    }

    TEST(SetterExtensionsTests, SetFirstFromSecondListAndReturnTrue)
    {
        TLinkAddress list1[] { 1,2,3 };
        TLinkAddress list2[] { 4,5,6 };
        Setter<TLinkAddress> setter {};
        bool decision { SetterExtensions::SetFirstFromSecondListAndReturnTrue(setter, list1, list2) };
        ASSERT_EQ(setter.GetTrue(), decision);
        ASSERT_EQ(list2[0], setter.Result());
    }

    TEST(SetterExtensionsTests, SetSecondFromSecondListAndReturnTrue)
    {
        TLinkAddress list1[] { 1,2,3 };
        TLinkAddress list2[] { 4,5,6 };
        Setter<TLinkAddress> setter {};
        bool decision { SetterExtensions::SetSecondFromSecondListAndReturnTrue(setter, list1, list2) };
        ASSERT_EQ(setter.GetTrue(), decision);
        ASSERT_EQ(list2[1], setter.Result());
    }

    TEST(SetterExtensionsTests, SetThirdFromSecondListAndReturnTrue)
    {
        TLinkAddress list1[] { 1,2,3 };
        TLinkAddress list2[] { 4,5,6 };
        Setter<TLinkAddress> setter {};
        bool decision { SetterExtensions::SetThirdFromSecondListAndReturnTrue(setter, list1, list2) };
        ASSERT_EQ(setter.GetTrue(), decision);
        ASSERT_EQ(list2[2], setter.Result());
    }
}
