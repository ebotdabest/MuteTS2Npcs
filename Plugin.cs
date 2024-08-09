using System;
using BepInEx;
using HarmonyLib;

namespace ShutTfUp;

[BepInPlugin("hu.ebot.stfu", "Shut up npcs!", "1.0.0")]
public class Plugin : BaseUnityPlugin
{
    private void Awake()
    {
        Logger.LogInfo("The Stfu npc's mod loaded!");
        Harmony harmony = new Harmony("hu.ebot.stfu");
        harmony.PatchAll();
    }
}
