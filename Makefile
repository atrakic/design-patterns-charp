all: clean build test

build:
	dotnet restore
	dotnet build --configuration Release --no-restore

clean:
	dotnet clean --configuration Release

dos2unix:
	find . -type f -name '*.cs' -exec dos2unix {} \;

test:
	dotnet test --configuration Release --no-restore
