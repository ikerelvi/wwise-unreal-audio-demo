// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class AudioPortfolio : ModuleRules
{
	public AudioPortfolio(ReadOnlyTargetRules Target) : base(Target)
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
			"AudioPortfolio",
			"AudioPortfolio/Variant_Platforming",
			"AudioPortfolio/Variant_Platforming/Animation",
			"AudioPortfolio/Variant_Combat",
			"AudioPortfolio/Variant_Combat/AI",
			"AudioPortfolio/Variant_Combat/Animation",
			"AudioPortfolio/Variant_Combat/Gameplay",
			"AudioPortfolio/Variant_Combat/Interfaces",
			"AudioPortfolio/Variant_Combat/UI",
			"AudioPortfolio/Variant_SideScrolling",
			"AudioPortfolio/Variant_SideScrolling/AI",
			"AudioPortfolio/Variant_SideScrolling/Gameplay",
			"AudioPortfolio/Variant_SideScrolling/Interfaces",
			"AudioPortfolio/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
