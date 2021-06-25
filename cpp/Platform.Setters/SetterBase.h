
namespace Platform::Setters
{
    template <typename ...> class SetterBase;
    template <typename TResult> class SetterBase<TResult> : public ISetter<TResult>
    {
        protected: TResult _result = 0;
        
        public: TResult Result() { return _result; }
        
        protected: SetterBase() { }
    
        protected: SetterBase(TResult defaultValue) { _result = defaultValue; }
        
        public: void Set(TResult value) { _result = value; }

        struct EmptySet{
            TResult Set(){return{};}
        };

        static_assert(ISetter<EmptySet, TResult>);
    };
}
