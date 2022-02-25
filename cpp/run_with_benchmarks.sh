cmake_flags="-DCMAKE_BUILD_TYPE=Release -DCMAKE_CXX_COMPILER=g++-10 -DLINKS_PLATFORM_BENCHMARKS=ON"
cmake_build_dir="build"
cd cpp && mkdir -p $cmake_build_dir && cd $cmake_build_dir
conan install .. -pr=linksplatform --build=missing
cmake .. $cmake_flags
cmake --build .
scan-build cmake --build .
binaries=bin/*
for binary in $binaries
do
   ./$binary
done
