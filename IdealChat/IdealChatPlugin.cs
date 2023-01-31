using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace IdealChat;

[BepInAutoPlugin]
[BepInProcess("Among Us.exe")]
public partial class IdealChatPlugin : BasePlugin
{
    public Harmony Harmony { get; } = new(Id);

}
