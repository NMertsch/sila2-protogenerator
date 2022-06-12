# SiLA 2 Proto Generator
Tool to convert SiLA 2 features (e.g. [SiLAService-v1_0.sila.xml](SiLAService-v1_0.sila.xml)) to a Protobuf service description.

## Build
- Install .NET 6 SDK
- Run `dotnet build`

## Usage during development
- Run `dotnet run SiLAService-v1_0.sila.xml SiLAService.proto`
- This should generate the file `SiLAService.proto`

