// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class maxvgl1_Lab2_Tsk3_V1EditorTarget : TargetRules
{
	public maxvgl1_Lab2_Tsk3_V1EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "maxvgl1_Lab2_Tsk3_V1" } );
	}
}
