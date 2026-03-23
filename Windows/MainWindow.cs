using System;
using System.Numerics;
using ImGuiNET; // Corrigido
using Dalamud.Interface.Windowing;

namespace ESTClock.Windows;

public class MainWindow : Window, IDisposable
{
    private readonly Plugin plugin;

    public MainWindow(Plugin plugin) : base("EST CLOCK", 
        ImGuiWindowFlags.NoTitleBar | ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoBackground | ImGuiWindowFlags.NoDecoration)
    {
        this.plugin = plugin;
    }

    public void Dispose() { }

    public override void Draw()
    {
        DateTime estTime;
        try {
            estTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "Eastern Standard Time");
        } catch {
            estTime = DateTime.UtcNow.AddHours(-5);
        }

        var text = $"{estTime:hh:mm tt} EST";
        ImGui.SetWindowFontScale(plugin.Configuration.ClockTextScale);
        ImGui.TextColored(plugin.Configuration.ClockTextColor, text);
    }

    public void Toggle() => IsOpen = !IsOpen;
}