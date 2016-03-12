dnvm upgrade
dnu restore -s https://www.myget.org/F/aspnetvnext/ -f https://www.nuget.org/api/v2/
dnu build ./src/AspNet.Mvc.Formatters.Protobuf/project.json