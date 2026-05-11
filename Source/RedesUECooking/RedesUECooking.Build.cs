// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RedesUECooking : ModuleRules
{
	public RedesUECooking(ReadOnlyTargetRules Target) : base(Target)
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
			"Slate",
			"PhotonFusion"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"RedesUECooking",
			"RedesUECooking/Variant_Platforming",
			"RedesUECooking/Variant_Platforming/Animation",
			"RedesUECooking/Variant_Combat",
			"RedesUECooking/Variant_Combat/AI",
			"RedesUECooking/Variant_Combat/Animation",
			"RedesUECooking/Variant_Combat/Gameplay",
			"RedesUECooking/Variant_Combat/Interfaces",
			"RedesUECooking/Variant_Combat/UI",
			"RedesUECooking/Variant_SideScrolling",
			"RedesUECooking/Variant_SideScrolling/AI",
			"RedesUECooking/Variant_SideScrolling/Gameplay",
			"RedesUECooking/Variant_SideScrolling/Interfaces",
			"RedesUECooking/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
