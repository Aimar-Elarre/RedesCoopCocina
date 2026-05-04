// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CoopCocinaOnline : ModuleRules
{
	public CoopCocinaOnline(ReadOnlyTargetRules Target) : base(Target)
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
			"CoopCocinaOnline",
			"CoopCocinaOnline/Variant_Platforming",
			"CoopCocinaOnline/Variant_Platforming/Animation",
			"CoopCocinaOnline/Variant_Combat",
			"CoopCocinaOnline/Variant_Combat/AI",
			"CoopCocinaOnline/Variant_Combat/Animation",
			"CoopCocinaOnline/Variant_Combat/Gameplay",
			"CoopCocinaOnline/Variant_Combat/Interfaces",
			"CoopCocinaOnline/Variant_Combat/UI",
			"CoopCocinaOnline/Variant_SideScrolling",
			"CoopCocinaOnline/Variant_SideScrolling/AI",
			"CoopCocinaOnline/Variant_SideScrolling/Gameplay",
			"CoopCocinaOnline/Variant_SideScrolling/Interfaces",
			"CoopCocinaOnline/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
