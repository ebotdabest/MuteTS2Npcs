using HarmonyLib;
using UnityEngine;

[HarmonyPatch(typeof(AI), "Update")]
public class PatchAIUpdate
{
    static void Postfix(AI __instance)
    {
        __instance.isMuted = true;
        __instance.VoiceSource.volume = 0;
    }
}

[HarmonyPatch(typeof(AI), nameof(AI.SpawnRandomSound))]
public class AnotherAiPatch
{
    static bool Prefix(AI __instance)
    {
        Debug.Log("I was abt to say something, somebody stop me!");
        return false;
    }
}


[HarmonyPatch(typeof(AI), "Start")]
public class CoolAIPatch
{
    static void Postfix(AI __instance)
    {
        __instance.VoiceSource.enabled = false;
    }
}