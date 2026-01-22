namespace MediaCli;

internal static class VolumeControl
{
    public static int GetVolume()
    {
        try
        {
            using var enumerator = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            using var device = enumerator.GetDefaultAudioEndpoint(NAudio.CoreAudioApi.DataFlow.Render, NAudio.CoreAudioApi.Role.Communications);
            var volume = device.AudioEndpointVolume.MasterVolumeLevelScalar;
            return (int)Math.Round(volume * 100);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error getting volume: {ex.Message}");
            return 50;
        }
    }

    public static void SetVolume(int volumeLevel)
    {
        try
        {
            using var enumerator = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            using var device = enumerator.GetDefaultAudioEndpoint(NAudio.CoreAudioApi.DataFlow.Render, NAudio.CoreAudioApi.Role.Communications);
            var scalar = volumeLevel / 100f;
            device.AudioEndpointVolume.MasterVolumeLevelScalar = scalar;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error setting volume: {ex.Message}");
        }
    }
}
