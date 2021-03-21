namespace Platform::Setters
{
    template <typename ...> class Setter;
    template <typename TResult, typename TDecision> class Setter<TResult, TDecision> : public SetterBase<TResult>
    {
        private: TDecision _trueValue = 0;
        private: TDecision _falseValue = 0;

        public: Setter(TDecision trueValue, TDecision falseValue, TResult defaultValue)
            : SetterBase(defaultValue)
        {
            _trueValue = trueValue;
            _falseValue = falseValue;
        }

        public: Setter(TDecision trueValue, TDecision falseValue) : this(trueValue, falseValue, 0) { }

        public: Setter(TResult defaultValue) : SetterBase(defaultValue) { }

        public: Setter() { }

        public: TDecision SetAndReturnTrue(TResult value)
        {
            _result = value;
            return _trueValue;
        }

        public: TDecision SetAndReturnFalse(TResult value)
        {
            _result = value;
            return _falseValue;
        }

        public: TDecision SetFirstAndReturnTrue(IList<TResult> &list)
        {
            _result = list[0];
            return _trueValue;
        }

        public: TDecision SetFirstAndReturnFalse(IList<TResult> &list)
        {
            _result = list[0];
            return _falseValue;
        }
    };
}
