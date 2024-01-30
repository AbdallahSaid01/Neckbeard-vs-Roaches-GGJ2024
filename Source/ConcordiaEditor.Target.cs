// Copyright 2023 Andras Ketzer, All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ConcordiaEditorTarget : TargetRules
{
	public ConcordiaEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "Concordia" } );
	}
}
