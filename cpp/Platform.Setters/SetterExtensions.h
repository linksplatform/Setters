namespace Platform::Setters
{
    template<typename TResult, typename TDecision>
    class SetterExtensions
    {
    public:
        static TDecision SetFirstFromListAndReturnTrue(Setter<TResult, TDecision> setter, IList<TResult> list)
        {
            setter.Set(list[0]);
            return setter.GetTrue();
        }

        static TDecision SetFirstFromFirstListAndReturnTrue(Setter<TResult, TDecision> setter, IList<TResult> list1, IList<TResult> list2)
        {
            setter.Set(list1[0]);
            return setter.GetTrue();
        }

        static TDecision SetSecondFromFirstListAndReturnTrue(Setter<TResult, TDecision> setter, IList<TResult> list1, IList<TResult> list2)
        {
            setter.Set(list1[1]);
            return setter.GetTrue();
        }

        static TDecision SetThirdFromFirstListAndReturnTrue(Setter<TResult, TDecision> setter, IList<TResult> list1, IList<TResult> list2)
        {
            setter.Set(list1[2]);
            return setter.GetTrue();
        }

        static TDecision SetFirstFromSecondListAndReturnTrue(Setter<TResult, TDecision> setter, IList<TResult> list1, IList<TResult> list2)
        {
            setter.Set(list2[0]);
            return setter.GetTrue();
        }

        static TDecision SetSecondFromSecondListAndReturnTrue(Setter<TResult, TDecision> setter, IList<TResult> list1, IList<TResult> list2)
        {
            setter.Set(list2[1]);
            return setter.GetTrue();
        }

        static TDecision SetThirdFromSecondListAndReturnTrue(Setter<TResult, TDecision> setter, IList<TResult> list1, IList<TResult> list2)
        {
            setter.Set(list2[2]);
            return setter.GetTrue();
        }
    };
}
