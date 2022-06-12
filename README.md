# SiLA 2 Proto Generator
Tool to convert SiLA 2 features (e.g. [SiLAService-v1_0.sila.xml](SiLAService-v1_0.sila.xml)) to a Protobuf service description.

## Usage during development
Run `dotnet run SiLAService-v1_0.sila.xml SiLAService.proto`. This generates the file SiLAService.proto`.

## Build
Run `dotnet publish -c Release -o .`. This generates `SiLA2ProtoGenerator.exe`.

## Usage
Run `SiLA2ProtoGenerator.exe SiLAService-v1_0.sila.xml SiLAService.proto` from inside the current directory (required until the xsl files are bundled).
