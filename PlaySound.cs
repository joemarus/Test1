//-----------------------------------------------------------------------------
// PlaySound
// This program is an experiment to see how to use the SoundPlayer class.
// SoundPlayer can only play WAV files, so I picked a nice sound that happened
// to be in my C:\Windows\Media folder.  You might have to pick another file.
// I also put in some basic error handling with the "try...catch" statements.
// If there is a problem playing the sound file, you can catch the error and 
// display it before it crashes your program.
// You can also play the sound by hitting Alt-P and stop the sound with Alt-S.
//-----------------------------------------------------------------------------
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Media;

namespace JoeM.PlaySound
{
    class PlaySound : Window
    {
        SoundPlayer player = new SoundPlayer(@"c:\windows\media\alarm01.wav");

        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new PlaySound());
        }
        public PlaySound()
        {
            Title = "Play A Sound";

            // Create a StackPanel for our buttons
            StackPanel panel = new StackPanel();
            Content = panel;
            panel.Margin = new Thickness(50);
            SizeToContent = SizeToContent.WidthAndHeight;

            // Play button
            Button btn = new Button();
            btn.Margin = new Thickness(10);
            btn.Padding = new Thickness(6.5);
            btn.Content = "Click to _Play a Sound";
            btn.Click += ButtonOnClick;
            panel.Children.Add(btn);

            // Stop button
            btn = new Button();
            btn.Margin = new Thickness(10);
            btn.Padding = new Thickness(6.5);
            btn.Content = "Click to _Stop Playing";
            btn.Click += ButtonStopOnClick;
            panel.Children.Add(btn);
        }
        void ButtonOnClick(Object sender, RoutedEventArgs args)
        {
            try
            {
                player.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,Title);
            }
        }
        void ButtonStopOnClick(Object sender, RoutedEventArgs args)
        {
            player.Stop();
        }
    }
}
