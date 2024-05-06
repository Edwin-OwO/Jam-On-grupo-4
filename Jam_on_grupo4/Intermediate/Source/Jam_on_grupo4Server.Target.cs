using UnrealBuildTool;

public class Jam_on_grupo4ServerTarget : TargetRules
{
	public Jam_on_grupo4ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Jam_on_grupo4");
	}
}
