using UnrealBuildTool;

public class Jam_on_grupo4EditorTarget : TargetRules
{
	public Jam_on_grupo4EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Jam_on_grupo4");
	}
}
