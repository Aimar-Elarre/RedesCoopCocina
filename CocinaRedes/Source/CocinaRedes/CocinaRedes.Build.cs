// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CocinaRedes : ModuleRules
{
	public CocinaRedes(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"CocinaRedes",
			"CocinaRedes/Variant_Platforming",
			"CocinaRedes/Variant_Platforming/Animation",
			"CocinaRedes/Variant_Combat",
			"CocinaRedes/Variant_Combat/AI",
			"CocinaRedes/Variant_Combat/Animation",
			"CocinaRedes/Variant_Combat/Gameplay",
			"CocinaRedes/Variant_Combat/Interfaces",
			"CocinaRedes/Variant_Combat/UI",
			"CocinaRedes/Variant_SideScrolling",
			"CocinaRedes/Variant_SideScrolling/AI",
			"CocinaRedes/Variant_SideScrolling/Gameplay",
			"CocinaRedes/Variant_SideScrolling/Interfaces",
			"CocinaRedes/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
