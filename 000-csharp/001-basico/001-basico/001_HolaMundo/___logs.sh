PS C:\Users\cesvh\dev\github\csharp\000-csharp\001-basico\001-basico>
PS C:\Users\cesvh\dev\github\csharp\000-csharp\001-basico\001-basico> dotnet new console -o 001_HolaMundo

Esto es .NET 9.0.
---------------------
Versión del SDK: 9.0.203

Telemetría
---------
Las herramientas de .NET recopilan datos de uso para ayudarnos a mejorar su experiencia. Microsoft los recopila y los comparte con la comunidad. Puede optar por no participar en la telemetría si establece la variable de entorno DOTNET_CLI_TELEMETRY_OPTOUT en "1" o "true" mediante su shell favorito.

Lea más sobre la telemetría de las herramientas de la CLI de .NET: https://aka.ms/dotnet-cli-telemetry

----------------
Instalar un certificado de desarrollo HTTPS de ASP.NET Core.
Para confiar en el certificado, ejecute "dotnet dev-certs https --trust"
Obtenga información sobre HTTPS: https://aka.ms/dotnet-https

----------------
Escribir su primera aplicación: https://aka.ms/dotnet-hello-world
Descubra las novedades: https://aka.ms/dotnet-whats-new
Explore la documentación: https://aka.ms/dotnet-docs
Notificar problemas y encontrar el código fuente en GitHub: https://github.com/dotnet/core
Use "dotnet --help" para ver los comandos disponibles o visite: https://aka.ms/dotnet-cli
--------------------------------------------------------------------------------------
La plantilla "Aplicación de consola" se creó correctamente.

Procesando acciones posteriores a la creación...
Restaurando C:\Users\cesvh\dev\github\csharp\000-csharp\001-basico\001-basico\001_HolaMundo\001_HolaMundo.csproj:
Restauración realizada correctamente.


PS C:\Users\cesvh\dev\github\csharp\000-csharp\001-basico\001-basico>
PS C:\Users\cesvh\dev\github\csharp\000-csharp\001-basico\001-basico> ls

    Directory: C:\Users\cesvh\dev\github\csharp\000-csharp\001-basico\001-basico

Mode                 LastWriteTime         Length Name
----                 -------------         ------ ----
d----       24/04/2025 05:03 p. m.                001_HolaMundo
-a---       23/04/2025 04:55 p. m.              0 pendiente.txt

PS C:\Users\cesvh\dev\github\csharp\000-csharp\001-basico\001-basico>
PS C:\Users\cesvh\dev\github\csharp\000-csharp\001-basico\001-basico> cd .\001_HolaMundo\
PS C:\Users\cesvh\dev\github\csharp\000-csharp\001-basico\001-basico\001_HolaMundo>
PS C:\Users\cesvh\dev\github\csharp\000-csharp\001-basico\001-basico\001_HolaMundo> ls

    Directory: C:\Users\cesvh\dev\github\csharp\000-csharp\001-basico\001-basico\001_HolaMundo

Mode                 LastWriteTime         Length Name
----                 -------------         ------ ----
d----       24/04/2025 05:02 p. m.                obj
-a---       24/04/2025 05:03 p. m.              0 ___logs.sh
-a---       24/04/2025 05:02 p. m.            303 001_HolaMundo.csproj
-a---       24/04/2025 05:02 p. m.            105 Program.cs

PS C:\Users\cesvh\dev\github\csharp\000-csharp\001-basico\001-basico\001_HolaMundo>
PS C:\Users\cesvh\dev\github\csharp\000-csharp\001-basico\001-basico\001_HolaMundo> dotnet run
Hello, World!
PS C:\Users\cesvh\dev\github\csharp\000-csharp\001-basico\001-basico\001_HolaMundo>
PS C:\Users\cesvh\dev\github\csharp\000-csharp\001-basico\001-basico\001_HolaMundo>
PS C:\Users\cesvh\dev\github\csharp\000-csharp\001-basico\001-basico\001_HolaMundo> dotnet build
Restauración completada (0.5s)
  001_HolaMundo realizado correctamente (0.3s) → bin\Debug\net9.0\001_HolaMundo.dll

Compilación realizado correctamente en 1.5s
PS C:\Users\cesvh\dev\github\csharp\000-csharp\001-basico\001-basico\001_HolaMundo>
PS C:\Users\cesvh\dev\github\csharp\000-csharp\001-basico\001-basico\001_HolaMundo>