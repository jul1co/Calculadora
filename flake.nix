perSystem = { pkgs, ... }: {
  devShells = {
    default = pkgs.mkShell {
      nativeBuildInputs = with pkgs; [
        dotnetCorePackages.sdk_7_0
      ];

      DOTNET_BIN = "${pkgs.dotnetCorePackages.sdk_7_0}/bin/dotnet";
    };
  };

  builds = {
    default = {
      # Add your dotnet project build command here
      buildCommand = ''
        ${pkgs.dotnetCorePackages.sdk_7_0}/bin/dotnet build path/to/your/project.csproj
      '';

      # Add your dotnet project run command here
      runCommand = ''
        ${pkgs.dotnetCorePackages.sdk_7_0}/bin/dotnet run --project path/to/your/project.csproj
      '';
    };
  };
};
