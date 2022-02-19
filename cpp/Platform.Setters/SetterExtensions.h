namespace Platform::Setters
{
    class SetterExtensions
    {
    public:
        template<typename TResult, typename TDecision>
        static TDecision SetFirstFromFirstListAndReturnTrue(Setter<TResult, TDecision>& setter, Interfaces::CArray<TResult> auto&& list1, Interfaces::CArray<TResult> auto&& list2)
        {
            setter.Set(list1[0]);
            return setter.GetTrue();
        }

        template<typename TResult, typename TDecision>
        static TDecision SetSecondFromFirstListAndReturnTrue(Setter<TResult, TDecision>& setter, Interfaces::CArray<TResult> auto&& list1, Interfaces::CArray<TResult> auto&& list2)
        {
            setter.Set(list1[1]);
            return setter.GetTrue();
        }

        template<typename TResult, typename TDecision>
        static TDecision SetThirdFromFirstListAndReturnTrue(Setter<TResult, TDecision>& setter, Interfaces::CArray<TResult> auto&& list1, Interfaces::CArray<TResult> auto&& list2)
        {
            setter.Set(list1[2]);
            return setter.GetTrue();
        }

        template<typename TResult, typename TDecision>
        static TDecision SetFirstFromSecondListAndReturnTrue(Setter<TResult, TDecision>& setter, Interfaces::CArray<TResult> auto&& list1, Interfaces::CArray<TResult> auto&& list2)
        {
            setter.Set(list2[0]);
            return setter.GetTrue();
        }

        template<typename TResult, typename TDecision>
        static TDecision SetSecondFromSecondListAndReturnTrue(Setter<TResult, TDecision>& setter, Interfaces::CArray<TResult> auto&& list1, Interfaces::CArray<TResult> auto&& list2)
        {
            setter.Set(list2[1]);
            return setter.GetTrue();
        }

        template<typename TResult, typename TDecision>
        static TDecision SetThirdFromSecondListAndReturnTrue(Setter<TResult, TDecision>& setter, Interfaces::CArray<TResult> auto&& list1, Interfaces::CArray<TResult> auto&& list2)
        {
            setter.Set(list2[2]);
            return setter.GetTrue();
        }
    };
}
