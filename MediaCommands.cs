using Spectre.Console.Cli;

namespace MediaCli;

internal class PlayPauseCommand : Command<PlayPauseCommand.Settings>
{
    public class Settings : CommandSettings { }

    public override int Execute(CommandContext context, Settings settings, CancellationToken cancellation)
    {
        MediaControl.PlayPause();
        Console.WriteLine("Play/Pause toggled");
        return 0;
    }
}

internal class TogglePlaybackCommand : Command<TogglePlaybackCommand.Settings>
{
    public class Settings : CommandSettings { }

    public override int Execute(CommandContext context, Settings settings, CancellationToken cancellation)
    {
        var isPlaying = MediaControl.IsPlaying();
        MediaControl.PlayPause();
        Console.WriteLine(isPlaying ? "Paused" : "Playing");
        return 0;
    }
}

internal class NextTrackCommand : Command<NextTrackCommand.Settings>
{
    public class Settings : CommandSettings { }

    public override int Execute(CommandContext context, Settings settings, CancellationToken cancellation)
    {
        MediaControl.NextTrack();
        Console.WriteLine("Next track");
        return 0;
    }
}

internal class PreviousTrackCommand : Command<PreviousTrackCommand.Settings>
{
    public class Settings : CommandSettings { }

    public override int Execute(CommandContext context, Settings settings, CancellationToken cancellation)
    {
        MediaControl.PreviousTrack();
        Console.WriteLine("Previous track");
        return 0;
    }
}
