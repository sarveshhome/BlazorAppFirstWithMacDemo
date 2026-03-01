#!/bin/bash

echo "Setting up HTTPS certificates for BlazorAppFirstWithMacDemo..."

# Clean and create new certificate
echo "Creating trusted HTTPS certificate..."
dotnet dev-certs https --clean
dotnet dev-certs https --export-path ./https-cert.pfx --password "@761" --trust

# Projects to configure
projects=(
    "BlazorAppFirstWithMacDemo"
)

# Setup user secrets for each project
for project in "${projects[@]}"; do
    echo "Setting up certificates for $project..."
    dotnet user-secrets init --project "$project.csproj"
    dotnet user-secrets set "KestrelCertificatePassword" "@761" --project "$project.csproj"
done

echo "HTTPS setup complete!"
echo "Certificate created: ./https-cert.pfx"
echo "Password stored in user secrets"
echo ""
echo "To run the project with HTTPS: dotnet run"