# Create container images without Dockerfile

With .NET 7.0 Microsoft introduced a feature which helps to create container images without Dockerfile.

To do this first, add the `Microsoft.NET.Build.Containers` nuget package to the project using the following command.

`dotnet add package Microsoft.NET.Build.Containers`

For creating the image, execute the following command.

`dotnet publish --os linux --arch x64 -p:PublishProfile=DefaultContainer -p:ContainerImageName=helloworld -p:ContainerImageTag=latest`

Now execute the `docker images` command and it will list the `helloworld` container image.