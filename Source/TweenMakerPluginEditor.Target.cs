// Copyright 2018 Francesco Desogus. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class TweenMakerPluginEditorTarget : TargetRules
{
	public TweenMakerPluginEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("TweenMakerPlugin");
	}
}
