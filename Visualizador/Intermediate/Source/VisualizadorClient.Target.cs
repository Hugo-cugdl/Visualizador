using UnrealBuildTool;

public class VisualizadorClientTarget : TargetRules
{
	public VisualizadorClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Visualizador");
	}
}
