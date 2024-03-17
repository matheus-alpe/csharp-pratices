CHAPTER=1
ARG=2
export CHAPTER
export ARG
run:
	dotnet run $(CHAPTER) $(ARG)

build:
	dotnet build -c Release

run-build:
	dotnet run ./bin/Release/net8.0/csharp-pratices.dll
