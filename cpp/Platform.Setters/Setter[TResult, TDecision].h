namespace Platform::Setters
{
    template <typename ...> class Setter;
    template <typename TResult, typename TDecision> class Setter<TResult, TDecision> : public SetterBase<TResult>
    {
        using base = SetterBase<TResult>;
        private: TDecision _trueValue {};
        private: TDecision _falseValue {};

        public: Setter(TDecision trueValue, TDecision falseValue, TResult defaultValue)
            : _trueValue(trueValue), _falseValue(falseValue), base(defaultValue)
        {
        }

        public: Setter(TDecision trueValue, TDecision falseValue) : Setter(trueValue, falseValue, {}) { }

        public: explicit Setter(TResult defaultValue) : base(defaultValue) { }

        public: Setter() = default;

        public: TDecision SetAndReturnTrue(TResult value)
        {
            base::_result = value;
            return _trueValue;
        }

        public: TDecision SetAndReturnFalse(TResult value)
        {
            base::_result = value;
            return _falseValue;
        }

        public: TDecision SetFirstAndReturnTrue(Interfaces::IArray<TResult> auto&& list)
        {
            base::_result = list[0];
            return _trueValue;
        }

        public: TDecision SetFirstAndReturnFalse(Interfaces::IArray<TResult> auto&& list)
        {
            base::_result = list[0];
            return _falseValue;
        }
    };
}
