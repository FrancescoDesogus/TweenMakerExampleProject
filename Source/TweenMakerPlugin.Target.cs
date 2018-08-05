// Copyright 2018 Francesco Desogus. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class TweenMakerPluginTarget : TargetRules
{
	public TweenMakerPluginTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TweenMakerPlugin");
	}
}
