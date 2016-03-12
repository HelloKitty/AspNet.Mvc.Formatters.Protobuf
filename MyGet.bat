cd ./src/AspNet.Mvc.Formatters.Protobuf
dnu restore
dnu build
dnu pack
cd ..
cd ..
msbuild AspNet.Mvc.Formatters.Protobuf.sln