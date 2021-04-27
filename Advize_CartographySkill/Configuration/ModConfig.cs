﻿namespace Advize_CartographySkill.Configuration
{
    class ModConfig
    {
        //General
        private ConfigEntry<float> exploreRadiusIncrease;
        private ConfigEntry<float> baseExploreRadius;
        private ConfigEntry<int> nexusID;
        //Progression
        private ConfigEntry<float> skillIncrease;
        private ConfigEntry<int> tilesDiscoveredForXPGain;
        //Spyglass
        private ConfigEntry<bool> enableSpyglass;
        private ConfigEntry<float> fovReductionFactor;
        private ConfigEntry<float> zoomMultiplier;
        //Controls
        private ConfigEntry<string> increaseZoomKey;
        private ConfigEntry<string> decreaseZoomModifierKey;
        private ConfigEntry<string> removeZoomKey;
        //Troubleshooting
        private ConfigEntry<bool> enableDebugMessages;

        internal ModConfig(Config config)
        {
            nexusID = config.Bind(
                "General",
                "NexusID",
                394,
                "Nexus mod ID for updates.", false);
            exploreRadiusIncrease = config.Bind(
                "General",
                "RadiusIncreasePerLevel",
                1f,
                "Amount to increase base explore radius by per skill level");
            baseExploreRadius = config.Bind(
                "General",
                "BaseExploreRadius",
                100f,
                "BaseExploreRadius (Vanilla value is 100)");
            skillIncrease = config.Bind(
                "Progression",
                "LevelingIncrement",
                0.5f,
                "Experience gain when cartography skill XP is awarded");
            tilesDiscoveredForXPGain = config.Bind(
                "Progression",
                "TileDiscoveryRequirement",
                100,
                "Amount of map tiles that need to be discovered before XP is awarded (influences BetterUI xp gain spam)");
            enableSpyglass = config.Bind(
                "Spyglass",
                "EnableSpyglass",
                true,
                "Enables the spyglass item");
            fovReductionFactor = config.Bind(
                "Spyglass",
                "FovReductionFactor",
                5f,
                "Influences field of view when zoomed, recommended range is 0 (disabled) to 5");
            zoomMultiplier = config.Bind(
                "Spyglass",
                "ZoomMultiplier",
                5f,
                "Increase/Decrease camera zoom distance");
            increaseZoomKey = config.Bind(
                "Controls",
                "IncreaseZoomKey",
                "mouse 1",
                "Key to increase zoom level. See https://docs.unity3d.com/Manual/class-InputManager.html", false);
            decreaseZoomModifierKey = config.Bind(
                "Controls",
                "DecreaseZoomModifierKey",
                "left shift",
                "Hold this key while pressing IncreaseZoomKey to decrease zoom level. See https://docs.unity3d.com/Manual/class-InputManager.html", false);
            removeZoomKey = config.Bind(
                "Controls",
                "RemoveZoomKey",
                "",
                "Optional key to fully zoom out. See https://docs.unity3d.com/Manual/class-InputManager.html", false);
            enableDebugMessages = config.Bind(
                "Troubleshooting",
                "EnableDebugMessages",
                false,
                "Enable mod debug messages in console", false);

            
        }

        internal float SkillIncrease
        {
            get { return skillIncrease.Value; }
        }
        internal int TilesDiscoveredForXPGain
        {
            get { return tilesDiscoveredForXPGain.Value; }
        }
        internal float ExploreRadiusIncrease
        {
            get { return exploreRadiusIncrease.Value; }
        }
        internal float BaseExploreRadius
        {
            get { return baseExploreRadius.Value; }
        }
        internal bool EnableDebugMessages
        {
            get { return enableDebugMessages.Value; }
        }
        internal bool EnableSpyglass
        {
            get { return enableSpyglass.Value; }
        }
        internal float FovReductionFactor
        {
            get { return fovReductionFactor.Value; }
        }
        internal float ZoomMultiplier
        {
            get { return zoomMultiplier.Value; }
        }
        internal string IncreaseZoomKey
        {
            get { return increaseZoomKey.Value; }
        }
        internal string DecreaseZoomModifierKey
        {
            get { return decreaseZoomModifierKey.Value; }
        }
        internal string RemoveZoomKey
        {
            get { return removeZoomKey.Value; }
        }
    }
}