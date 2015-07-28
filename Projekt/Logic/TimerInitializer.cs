using System;
using System.ComponentModel;
using System.Timers;
using System.Windows.Forms;
using Logic;
using Timer = System.Timers.Timer;

public class TimerInitializer
{
    public Timer timer; // From System.Timers
    private FeedReader reader;
    private SamlingsBibliotek samlingsBibliotek;
    private string url;

    public string TimerID { get; set; }

    public TimerInitializer(FeedReader inReader, string inUrl, SamlingsBibliotek inSamlingsBibliotek)
    {
        reader = inReader;
        samlingsBibliotek = inSamlingsBibliotek;
        url = inUrl;
    }

    /// <summary>
    /// Instansierar ett nytt timer-objekt baserat på angiven tidsintervall.
    /// </summary>
    /// <param name="time"></param>
    public void Start(int time)
    {
        timer = new Timer(time);
        timer.Elapsed += new ElapsedEventHandler(timerElapsed);
        timer.Enabled = true;
    }

    /// <summary>
    /// Byter intervalltid baserad på angiven tid.
    /// </summary>
    /// <param name="time"></param>
    public void ChangeIntervalTime(int time)
    {
        timer.Interval = time;
    }

    /// <summary>
    /// Laddar om prenumerationer när tiden gått ut.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void timerElapsed(object sender, ElapsedEventArgs e)
    {
        timer.Enabled = false;
        LaddaOmPrenumerationerTimer();
        Console.WriteLine("Det gick bra");
        timer.Enabled = true;
    }

    /// <summary>
    /// Laddar om prenumerationer.
    /// </summary>
    private void LaddaOmPrenumerationerTimer()
    {
        reader.LaddaOmPrenumeration(url, samlingsBibliotek);
    }
}