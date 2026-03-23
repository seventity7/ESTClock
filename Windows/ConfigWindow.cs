using System;
using System.Numerics;
using ImGuiNET; // Corrigido
using Dalamud.Interface.Windowing;

namespace ESTClock.Windows;

public class ConfigWindow : Window, IDisposable
{
    private readonly Configuration configuration;

    public ConfigWindow(Plugin plugin) : base("EST Clock - Config###ConfigWindow")
    {
        this.configuration = plugin.Configuration;
        Size = new Vector2(300, 250);
        SizeCondition = ImGuiCond.Always;
    }

    public void Dispose() { }

    public override void Draw()
    {
        var autoStart = configuration.AutoStart;
        if (ImGui.Checkbox("Auto-Start with Game", ref autoStart))
        {
            configuration.AutoStart = autoStart;
            configuration.Save();
        }

        var movable = configuration.IsConfigWindowMovable;
        if (ImGui.Checkbox("Movable Clock", ref movable))
        {
            configuration.IsConfigWindowMovable = movable;
            configuration.Save();
        }

        var scale = configuration.ClockTextScale;
        if (ImGui.SliderFloat("Text Scale", ref scale, 0.5f, 5.0f))
        {
            configuration.ClockTextScale = scale;
            configuration.Save();
        }
    }

}