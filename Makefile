CHAPTER=1
export CHAPTER
run:
	dotnet run $(CHAPTER)

build:
	dotnet build -c Release

run-build:
	dotnet run ./bin/Release/net8.0/csharp-pratices.dll
