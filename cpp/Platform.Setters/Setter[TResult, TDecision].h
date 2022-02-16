namespace Platform::Setters
{
    template <typename ...> class Setter;
    template <typename TResult, typename TDecision> class Setter<TResult, TDecision> : public SetterBase<TResult>
    {
        using base = SetterBase<TResult>;
    private:
        TDecision _trueValue {};
        TDecision _falseValue {};

        public: Setter(TDecision _trueValue, TDecision _falseValue, TResult defaultValue)
            : _trueValue(_trueValue), _falseValue(_falseValue), base(defaultValue)
        {
        }

        public: Setter(TDecision _trueValue, TDecision _falseValue) : Setter(_trueValue, _falseValue, {}) { }

        public: explicit Setter(TResult defaultValue) : base(defaultValue) { }

        public: Setter() = default;

    public:
        TDecision GetTrue()
        {
            return _trueValue;
        }

        TDecision GetFalse()
        {
            return _falseValue;
        }

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
