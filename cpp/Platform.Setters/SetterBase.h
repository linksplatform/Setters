namespace Platform::Setters
{
    template <typename ...> class SetterBase;
    template <typename TResult> class SetterBase<TResult>
    {
    public:
        TResult Result() { return _result; }
        void Set(TResult value) { _result = value; }
    protected:
        SetterBase() {}
        SetterBase(TResult defaultValue) { _result = defaultValue; }
        TResult _result = 0;
    };
}