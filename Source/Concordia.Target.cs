// Copyright 2023 Andras Ketzer, All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ConcordiaTarget : TargetRules
{
	public ConcordiaTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "Concordia" } );
	}
}
