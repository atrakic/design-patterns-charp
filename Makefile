
BASEDIR = $(shell pwd)

all: build test

build:
	dotnet restore
	dotnet build --configuration Release --no-restore

dos2unix:
	find . -type f -name '*.cs' -exec dos2unix {} \;

test:
	dotnet test --configuration Release --no-restore

clean:
	dotnet clean --configuration Release
	rm -rf $(BASEDIR)/src/*/{obj,bin}
	rm -rf $(BASEDIR)/tests/*/{obj,bin}
