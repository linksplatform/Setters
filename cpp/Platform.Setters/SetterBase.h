namespace Platform::Setters
{
    template <typename ...> class SetterBase;
    template <typename TResult> class SetterBase<TResult>
    {
        protected: TResult _result {};

        public: TResult Result() { return _result; }

        protected: SetterBase() {static_assert(std::default_initializable<TResult>);}

        protected: explicit SetterBase(TResult defaultValue) { _result = defaultValue; }

        public: void Set(TResult value) { _result = value; }
    };
}
