using UnrealBuildTool;

public class VisualizadorServerTarget : TargetRules
{
	public VisualizadorServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Visualizador");
	}
}
