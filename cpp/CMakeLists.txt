cmake_minimum_required (VERSION 3.19)

project (Platform.Setters)
set(CMAKE_RUNTIME_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/bin)
find_package(Platform.Interfaces)
find_package(GTest)

add_library(${PROJECT_NAME}.Library INTERFACE)
target_include_directories(${PROJECT_NAME}.Library INTERFACE ${PROJECT_NAME})
target_link_libraries(${PROJECT_NAME}.Library INTERFACE Platform.Interfaces::Platform.Interfaces)

if((DEFINED LINKS_PLATFORM_TESTS) AND (${LINKS_PLATFORM_TESTS}))
    add_executable (${PROJECT_NAME}.Tests ${PROJECT_NAME}.Tests/SetterTests.cpp)
    set_target_properties(${PROJECT_NAME}.Tests PROPERTIES CXX_STANDARD 20)
    target_link_libraries(${PROJECT_NAME}.Tests PUBLIC GTest::gtest)
    target_link_libraries(${PROJECT_NAME}.Tests PUBLIC GTest::gtest_main)
    target_link_libraries(${PROJECT_NAME}.Tests PUBLIC ${PROJECT_NAME}.Library)
endif()
