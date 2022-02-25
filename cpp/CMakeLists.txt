cmake_minimum_required (VERSION 3.19)

set(CONAN_DISABLE_CHECK_COMPILER TRUE)

project (Platform.Setters)
include(${CMAKE_BINARY_DIR}/conanbuildinfo.cmake)
conan_basic_setup(TARGETS)

add_library(${PROJECT_NAME}.Library INTERFACE)
target_include_directories(${PROJECT_NAME}.Library INTERFACE ${PROJECT_NAME})
target_link_libraries(${PROJECT_NAME}.Library INTERFACE CONAN_PKG::platform.interfaces)

if((DEFINED LINKS_PLATFORM_TESTS) AND (${LINKS_PLATFORM_TESTS}))
    add_executable (${PROJECT_NAME}.Tests ${PROJECT_NAME}.Tests/SetterTests.cpp)
    set_target_properties(${PROJECT_NAME}.Tests PROPERTIES CXX_STANDARD 20)
    target_link_libraries(${PROJECT_NAME}.Tests PUBLIC CONAN_PKG::gtest)
    target_link_libraries(${PROJECT_NAME}.Tests PUBLIC ${PROJECT_NAME}.Library)
endif()

if((DEFINED LINKS_PLATFORM_BENCHMARKS) AND (${LINKS_PLATFORM_BENCHMARKS}))
    add_executable (${PROJECT_NAME}.Benchmarks ${PROJECT_NAME}.Benchmarks/AllBenchmarks.cpp)
    set_target_properties(${PROJECT_NAME}.Benchmarks PROPERTIES CXX_STANDARD 20)
    target_link_libraries(${PROJECT_NAME}.Benchmarks PUBLIC CONAN_PKG::gtest)
    target_link_libraries(${PROJECT_NAME}.Benchmarks PUBLIC CONAN_PKG::benchmark)
    target_link_libraries(${PROJECT_NAME}.Benchmarks PUBLIC ${PROJECT_NAME}.Library)
endif()
