{ pkgs }: {
	deps = [
    pkgs.adoptopenjdk-openj9-bin-16
    pkgs.python310
    pkgs.mono5
    pkgs.jq.bin
    pkgs.dotnet-sdk
    pkgs.omnisharp-roslyn
	];
}