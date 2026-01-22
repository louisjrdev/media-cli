# Media CLI

A Windows command-line tool for controlling media playback and system volume.

## Features

- **Volume Control**: Set, increase, or decrease system volume
- **Media Playback**: Control play/pause, next track, and previous track
- **Smart Toggle**: Automatically pause or play based on current playback state
- **Silent Execution**: Runs without showing a console window (perfect for automation tools like Zebar)
- **Standalone**: No .NET runtime required - completely self-contained

## Installation

### From Release
1. Download `media-cli.exe` from the [latest release](https://github.com/YOUR_USERNAME/media-cli/releases)
2. Place it in a directory of your choice
3. Optionally add it to your PATH

### With Winget (coming soon)
```bash
winget install YourPublisher.MediaCli
```

## Usage

### Volume Commands

Set volume to a specific level (0-100):
```bash
media-cli set-volume 50
```

Increase volume by 10% (default):
```bash
media-cli increase-volume
```

Increase volume by a custom amount:
```bash
media-cli increase-volume 5
```

Decrease volume by 10% (default):
```bash
media-cli decrease-volume
```

Decrease volume by a custom amount:
```bash
media-cli decrease-volume 15
```

### Media Control Commands

Toggle play/pause:
```bash
media-cli play
# or
media-cli pause
```

Smart toggle (shows current state):
```bash
media-cli toggle-playback
```

Next track:
```bash
media-cli next
```

Previous track:
```bash
media-cli previous
```

## Use with Zebar

This tool is designed to work seamlessly with [Zebar](https://github.com/glzr-io/zebar) and other automation tools:

```json
{
  "type": "text",
  "on_click": "shell-exec: C:\\path\\to\\media-cli.exe toggle-playback"
}
```

## Building from Source

Requirements:
- .NET 10 SDK
- Windows 10/11

```bash
git clone https://github.com/YOUR_USERNAME/media-cli.git
cd media-cli
dotnet publish -c Release -o publish
```

The standalone executable will be in `publish/media-cli.exe`.

## License

MIT
