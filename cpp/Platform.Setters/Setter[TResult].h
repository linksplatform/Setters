namespace Platform::Setters
{
    template <typename ...> class Setter;
    template <typename TResult> class Setter<TResult> : public Setter<TResult, bool>
    {
        public: Setter(TResult defaultValue) : Setter<TResult, bool>(true, false, defaultValue) { }

        public: Setter() : Setter<TResult, bool>(true, false) { }
    };
}
