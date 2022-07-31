using System;
using System.Collections.Generic;
using System.Text;

public abstract class Song
{
    public void ResumeSong() {
        Console.WriteLine("Song Playing..");
    }
    abstract public Song PlaySong { get;set; }
    abstract public bool StopSong { get; set; }
    abstract public bool RemoveSong { get; set; }
    abstract public int SongCount { get; set; }
}
