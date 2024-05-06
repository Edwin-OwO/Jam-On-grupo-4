using UnrealBuildTool;

public class Jam_on_grupo4Target : TargetRules
{
	public Jam_on_grupo4Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Jam_on_grupo4");
	}
}
