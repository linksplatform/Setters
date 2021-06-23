cmake_minimum_required (VERSION 3.19)

project (Platform.Setters)
include(${CMAKE_BINARY_DIR}/conanbuildinfo.cmake)
conan_basic_setup(TARGETS)

add_library(${PROJECT_NAME}.Library INTERFACE)
target_include_directories(${PROJECT_NAME}.Library INTERFACE ${PROJECT_NAME})
target_link_directories(${PROJECT_NAME}.Library INTERFACE CONAN_PKG::platform.interfaces)

add_executable (${PROJECT_NAME}.Tests ${PROJECT_NAME}.Tests/SetterTests.cpp)
set_target_properties (${PROJECT_NAME}.Tests PROPERTIES CXX_STANDARD 20)

target_link_libraries(${PROJECT_NAME}.Tests PUBLIC CONAN_PKG::gtest)
target_link_libraries(${PROJECT_NAME}.Tests PUBLIC ${PROJECT_NAME}.Library)