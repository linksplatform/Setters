#include <gtest/gtest.h>
#include <benchmark/benchmark.h>
#include <complex>
#include <Platform.Interfaces.h>
#include <Platform.Setters.h>

template<typename TLinkAddress>
class MySetter : Platform::Setters::Setter<TLinkAddress, TLinkAddress>
{
    using base = Platform::Setters::Setter<TLinkAddress, TLinkAddress>;

public:

    template<typename TLink>
    static TLinkAddress StaticSet(base&& setter, TLink&& link)
    {
        return setter.SetFirstAndReturnTrue(link);
    }
};

using namespace Platform::Setters;
using namespace Platform::Interfaces;

//template<typename TLinkAddress>
//struct Constants
//{
//    TLinkAddress Continue { 777 };
//    TLinkAddress Break { 666 };
//    TLinkAddress Null { 0 };
//};

//template<typename TFunction, typename... TArgs>
//requires requires (TFunction f, TArgs&&... args) { { f(std::forward<TArgs>(args)...) } -> std::same_as<int>; }
//int call(TFunction f, TArgs&&... args)
//{
//    return f(std::forward<TArgs>(args)...);
//}

template<typename TLinkAddress, typename TFunction>
TLinkAddress call(TFunction&& f, Platform::Interfaces::CArray auto&& link)
{
    return f(link);
}

static void BenchmarkSetterMemberFunctionWithStdBind()
{
//    Constants<int> constants {};
    Platform::Setters::Setter<int, int> setter { 777, 666, 0 };
    auto fp = &Platform::Setters::Setter<int, int>::SetFirstAndReturnTrue<std::vector<int>>;

    // auto f = std::bind(&Platform::Setters::Setter<int, int>::SetFirstAndReturnTrue<std::vector<int>>, &setter, std::placeholders::_1);
    // auto v = std::vector<int> { 1, 1, 1 };
    // auto v = std::array{ 1, 2, 3 };


    // f(v);
    // fp(&setter, v);

    // ((&setter)->*fp)(v);
    ((&setter)->*fp)(std::vector<int> { 1, 1, 1 });
    // call<int>(f, v);
}

//static int BenchmarkLambda()
//{
//    return call( [](Platform::Interfaces::CEnumerable auto&& link){return link[0];}, std::array{ 1, 2, 3 } );
//}
//
//int main()
//{
//    std::cout << BenchmarkLambda();
//}


//static void BenchmarkStaticSetterMemberFunction()
//{
//    Constants constants {};
//    Platform::Setters::Setter<int, int> setter { 777, 666, 0 };
//    call<int>(std::bind(&MySetter<int>::StaticSet<std::vector<int>>, &setter, std::placeholders::_1), std::vector { 1, 1, 1 });
//}



static void BenchmarkSetterMemberFunctionWithLambda()
{
//    Constants constants {};
    Platform::Setters::Setter<int, int> setter { 777, 666, 0 };
    call<int>([&setter](Platform::Interfaces::CArray auto&& link){ return setter.SetFirstAndReturnTrue(link); }, std::array{ 1, 2, 3 });
}

static void BenchmarkLambdaWithCapture()
{
//    Constants constants {};
    int linkAddress;
    call<int>([&linkAddress](Platform::Interfaces::CEnumerable auto&& link) {
        linkAddress = link[0];
        return 777;
    }, std::array { 1, 2, 3 });
}

//static void BM_StaticSetterMemberFunction(benchmark::State& state) {
//    // Perform setup here
//    for (auto _ : state) {
//        // This code gets timed
//        BenchmarkStaticSetterMemberFunction();
//    }
//}

static void BM_SetterMemberFunctionWithStdBind(benchmark::State& state) {
    // Perform setup here
    for (auto _ : state) {
        // This code gets timed
        BenchmarkSetterMemberFunctionWithStdBind();
    }
}

static void BM_SetterMemberFunctionWithLambda(benchmark::State& state) {
    // Perform setup here
    for (auto _ : state) {
        // This code gets timed
        BenchmarkSetterMemberFunctionWithLambda();
    }
}

static void BM_LambdaWithCapture(benchmark::State& state) {
    // Perform setup here
    for (auto _ : state) {
        // This code gets timed
        BenchmarkLambdaWithCapture();
    }
}

// Register the function as a benchmark
//BENCHMARK(BM_StaticSetterMemberFunction);
BENCHMARK(BM_SetterMemberFunctionWithStdBind);
BENCHMARK(BM_SetterMemberFunctionWithLambda);
BENCHMARK(BM_LambdaWithCapture);
// Run the benchmark
BENCHMARK_MAIN();
