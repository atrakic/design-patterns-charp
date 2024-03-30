
# Build and test the project
all: build test


# Build the project
build:
	dotnet restore
	dotnet build --configuration Release --no-restore


# Test the project
test:
	dotnet test --configuration Release --no-restore
