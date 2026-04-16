using UnrealBuildTool;

public class VisualizadorTarget : TargetRules
{
	public VisualizadorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Visualizador");
	}
}
