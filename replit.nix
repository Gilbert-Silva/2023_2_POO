{ pkgs }: {
	deps = [
		pkgs.python310
  pkgs.mono5
  pkgs.jq.bin
  pkgs.dotnet-sdk
    pkgs.omnisharp-roslyn
	];
}