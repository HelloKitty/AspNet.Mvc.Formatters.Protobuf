msbuild.exe AspNet.Mvc.Formatters.Protobuf.sln
cd ./src/AspNet.Mvc.Formatters.Protobuf
dnu restore
dnu build
dnu pack
dnu publish
cd ..
cd ..