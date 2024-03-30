all: build test dos2unix

build:
	dotnet restore
	dotnet build --configuration Release --no-restore

dos2unix:
	find . -type f -name '*.cs' -exec dos2unix {} \;

test:
	dotnet test --configuration Release --no-restore
