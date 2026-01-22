using System.ComponentModel;
using Spectre.Console.Cli;

namespace MediaCli;

internal class SetVolumeCommand : Command<SetVolumeCommand.Settings>
{
    public class Settings : CommandSettings
    {
        [CommandArgument(0, "<volume %>")]
        [Description("The volume to set (0-100)")]
        public int Volume { get; init; }
    }

    public override int Execute(CommandContext context, Settings settings, CancellationToken cancellation)
    {
        var volume = Math.Clamp(settings.Volume, 0, 100);
        VolumeControl.SetVolume(volume);
        Console.WriteLine($"Volume set to {volume}%");
        return 0;
    }
}

internal class IncreaseVolumeCommand : Command<IncreaseVolumeCommand.Settings>
{
    public class Settings : CommandSettings
    {
        [CommandArgument(0, "[step]")]
        [Description("The amount to increase volume by (default: 10)")]
        public int Step { get; init; } = 10;
    }

    public override int Execute(CommandContext context, Settings settings, CancellationToken cancellation)
    {
        var currentVolume = VolumeControl.GetVolume();
        var newVolume = Math.Clamp(currentVolume + settings.Step, 0, 100);
        VolumeControl.SetVolume(newVolume);
        Console.WriteLine($"Volume increased from {currentVolume}% to {newVolume}%");
        return 0;
    }
}

internal class DecreaseVolumeCommand : Command<DecreaseVolumeCommand.Settings>
{
    public class Settings : CommandSettings
    {
        [CommandArgument(0, "[step]")]
        [Description("The amount to decrease volume by (default: 10)")]
        public int Step { get; init; } = 10;
    }

    public override int Execute(CommandContext context, Settings settings, CancellationToken cancellation)
    {
        var currentVolume = VolumeControl.GetVolume();
        var newVolume = Math.Clamp(currentVolume - settings.Step, 0, 100);
        VolumeControl.SetVolume(newVolume);
        Console.WriteLine($"Volume decreased from {currentVolume}% to {newVolume}%");
        return 0;
    }
}
