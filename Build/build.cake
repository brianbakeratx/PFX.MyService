#load tools\Atlas.Build\Content\main.cake

Build.Settings = new BuildSettings 
{
  SolutionPath = @"..\PFX.MyService.sln",

  TestProjectFilePattern = @"../Tests/**/*.csproj",

  WebServicePath = @"..\PFX.MyService\PFX.MyService.csproj",

  UseDotNetCoreBuild = true,

  VersionFormat = "1.0.0.{0}"
};

var target = Argument("target", "Default");
RunTarget(target);
