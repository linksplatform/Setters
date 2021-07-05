namespace Platform::Setters
{
    template <typename ...> class Setter;
    template <typename TResult, typename TDecision> class Setter<TResult, TDecision> : public SetterBase<TResult>
    {
        private: TDecision _trueValue {};
        private: TDecision _falseValue {};

        using base = SetterBase<TResult>;

        public: Setter(TDecision trueValue, TDecision falseValue, TResult defaultValue)
            : _trueValue(trueValue), _falseValue(falseValue), base(defaultValue)
        {
            _trueValue = trueValue;
            _falseValue = falseValue;
            base::_result = defaultValue;
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

        public: TDecision SetFirstAndReturnTrue(Platform::Interfaces::IArray<TResult> auto&& list)
        {
            base::_result = list[0];
            return _trueValue;
        }
        public: TDecision SetFirstAndReturnFalse(Platform::Interfaces::IArray<TResult> auto&& list)
        {
            base::_result = std::move(list[0]);
            return _falseValue;
        }
    };
}
