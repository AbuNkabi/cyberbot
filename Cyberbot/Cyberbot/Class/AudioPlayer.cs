using System;
using System.Media;

public class AudioPlayer
{
    public static void PlayGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("AudioAssist/greeting.wav");
            player.PlaySync();
        }
        catch
        {
            Console.WriteLine("Audio file not found.");
        }
    }
}