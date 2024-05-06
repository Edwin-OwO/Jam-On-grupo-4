using UnrealBuildTool;

public class Jam_on_grupo4ClientTarget : TargetRules
{
	public Jam_on_grupo4ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Jam_on_grupo4");
	}
}
