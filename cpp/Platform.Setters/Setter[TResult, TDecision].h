namespace Platform::Setters
{
    template <typename ...> class Setter;
template <typename TResult, typename TDecision> class Setter<TResult, TDecision> : public SetterBase<TResult>
    {
        private: TDecision _trueValue = 0;
        private: TDecision _falseValue = 0;

        public: Setter(TDecision trueValue, TDecision falseValue, TResult defaultValue)
        {
            _trueValue = trueValue;
            _falseValue = falseValue;
        }

        public: Setter(TDecision trueValue, TDecision falseValue) : Setter(trueValue, falseValue, 0) { }

        public: Setter(TResult defaultValue) { }

        public: Setter() { }

        public: TDecision SetAndReturnTrue(TResult value)
        {
            TResult _result = value;
            return _trueValue;
        }

        public: TDecision SetAndReturnFalse(TResult value)
        {
            TResult _result = value;
            return _falseValue;
        }

    public: TDecision SetFirstAndReturnTrue(Platform::Interfaces::IList<TResult> auto list)
        {
            TResult _result = list[0];
            return _trueValue;
        }
    public: TDecision SetFirstAndReturnFalse(Platform::Interfaces::IList<TResult> auto list)
        {
            TResult _result = list[0];
            return _falseValue;
        }
    };
}
