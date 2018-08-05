// Copyright 2018 Francesco Desogus. All Rights Reserved.

using UnrealBuildTool;

public class TweenMakerPlugin : ModuleRules
{
	public TweenMakerPlugin(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "UMG"});
	}
}
