Write-Host "Build script"

Remove-Item -Path .\TodoApi\Data\Migrations -Recurse -Force -ErrorAction SilentlyContinue

dotnet ef migrations --project TodoApi add InitialCreate -o Data\Migrations

dotnet ef migrations script --project TodoApi --output .\setup\init.sql

docker compose up -d --build