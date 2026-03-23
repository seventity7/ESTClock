using Dalamud.Configuration;
using System;
using System.Numerics;

namespace ESTClock;

[Serializable]
public class Configuration : IPluginConfiguration
{
    public int Version { get; set; } = 0;

    public bool AutoStart { get; set; } = true; // Fix: Propriedade adicionada
    public bool IsConfigWindowMovable { get; set; } = true;
    public bool ClockTransparent { get; set; } = true;
    public float ClockTextScale { get; set; } = 2.0f;

    public Vector4 ClockTextColor { get; set; } = new Vector4(1, 1, 1, 1);
    public Vector4 ClockShadowColor { get; set; } = new Vector4(0, 0, 0, 0.8f);
    public float ClockBackgroundOpacity { get; set; } = 0.0f;
    public Vector4 ClockBackgroundColor { get; set; } = new Vector4(0, 0, 0, 1);

    public void Save()
    {
        Plugin.PluginInterface.SavePluginConfig(this);
    }
}