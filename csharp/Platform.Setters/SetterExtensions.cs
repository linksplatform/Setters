using System.Collections.Generic;

namespace Platform.Setters
{
    public static class SetterExtensions
    {
        public static TDecision SetFirstFromNonNullListAndReturnTrue<TResult, TDecision>(this Setter<TResult, TDecision> setter, IList<TResult>? list)
        {
            if (list != null)
            {
                setter.Set(list[0]);
            }
            return setter.TrueValue;
        }

        public static TDecision SetFirstFromNonNullFirstListAndReturnTrue<TResult, TDecision>(this Setter<TResult, TDecision> setter, IList<TResult>? list1, IList<TResult>? list2)
        {
            if (list1 != null)
            {
                setter.Set(list1[0]);
            }
            return setter.TrueValue;
        }

        public static TDecision SetSecondFromNonNullFirstListAndReturnTrue<TResult, TDecision>(this Setter<TResult, TDecision> setter, IList<TResult>? list1, IList<TResult>? list2)
        {
            if (list1 != null)
            {
                setter.Set(list1[1]);
            }
            return setter.TrueValue;
        }

        public static TDecision SetThirdFromNonNullFirstListAndReturnTrue<TResult, TDecision>(this Setter<TResult, TDecision> setter, IList<TResult>? list1, IList<TResult>? list2)
        {
            if (list1 != null)
            {
                setter.Set(list1[2]);
            }
            return setter.TrueValue;
        }

        public static TDecision SetFirstFromNonNullSecondListAndReturnTrue<TResult, TDecision>(this Setter<TResult, TDecision> setter, IList<TResult>? list1, IList<TResult>? list2)
        {
            if (list2 != null)
            {
                setter.Set(list2[0]);
            }
            return setter.TrueValue;
        }

        public static TDecision SetSecondFromNonNullSecondListAndReturnTrue<TResult, TDecision>(this Setter<TResult, TDecision> setter, IList<TResult>? list1, IList<TResult>? list2)
        {
            if (list2 != null)
            {
                setter.Set(list2[1]);
            }
            return setter.TrueValue;
        }

        public static TDecision SetThirdFromNonNullSecondListAndReturnTrue<TResult, TDecision>(this Setter<TResult, TDecision> setter, IList<TResult>? list1, IList<TResult>? list2)
        {
            if (list2 != null)
            {
                setter.Set(list2[2]);
            }
            return setter.TrueValue;
        }
    }
}

