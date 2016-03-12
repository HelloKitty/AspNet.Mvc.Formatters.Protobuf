cd ./src/AspNet.Mvc.Formatters.Protobuf
dnu restore
dnu build
dnu pack
dnu publish
cd ..
cd ..
xcopy ./artifacts/bin/AspNet.Mvc.Formatters.Protobuf ./src/AspNet.Mvc.Formatters.Protobuf /s