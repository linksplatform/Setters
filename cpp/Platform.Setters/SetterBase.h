namespace Platform::Setters
{
    template <typename ...> class SetterBase;
    template <typename TResult> class SetterBase<TResult>
    {
        static_assert(std::default_initializable<TResult>);

        protected: TResult _result {};

        public: TResult Result() { return _result; }

        protected: SetterBase() = default;

        protected: explicit SetterBase(TResult defaultValue) { _result = defaultValue; }

        public: void Set(TResult value) { _result = value; }

        public: ~SetterBase() requires Interfaces::ISetter<decltype(*this), TResult> = default;
    };
}
