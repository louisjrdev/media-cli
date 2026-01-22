using MediaCli;
using Spectre.Console.Cli;

var app = new CommandApp();

app.Configure(cfg =>
{
    cfg.AddCommand<SetVolumeCommand>("set-volume");
    cfg.AddCommand<IncreaseVolumeCommand>("increase-volume");
    cfg.AddCommand<DecreaseVolumeCommand>("decrease-volume");
    cfg.AddCommand<PlayPauseCommand>("play");
    cfg.AddCommand<PlayPauseCommand>("pause");
    cfg.AddCommand<TogglePlaybackCommand>("toggle-playback");
    cfg.AddCommand<NextTrackCommand>("next");
    cfg.AddCommand<PreviousTrackCommand>("previous");
});

return app.Run(args);

