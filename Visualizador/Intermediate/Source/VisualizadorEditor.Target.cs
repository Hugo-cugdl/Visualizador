using UnrealBuildTool;

public class VisualizadorEditorTarget : TargetRules
{
	public VisualizadorEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Visualizador");
	}
}
