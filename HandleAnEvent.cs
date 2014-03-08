//--------------------------------------------------------
// HandleAnEvent
// This WPF program is a short exmaple of how to create
// a one-file WPF program all in c# with no XAML.
// It also shows how events are handled.
// The program will respond to a mouse click in the window by
// changing the background color to a random color.
//--------------------------------------------------------
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

class HandleAnEvent
{
    [STAThread] // This is needed to make the compiler happy.
    public static void Main()
    {
        // For WPF, we need to create two important objects.
        // You use the "new" keyword to create an object.
        // First, the application object:
        Application app = new Application();
        // Then, the window object.
        Window win = new Window();
        // The window object, which I called "win" in my program,
        // represents the main window of our program.
        // We can set some properties of our object, which make changes
        // to the real window on the screen.
        // The Title property sets the text that you see in the title bar.
        win.Title = "Handle An Event";
        // In WPF, the Content property represents what you want to see in
        // the window.  We are going to keep it simple and just put in some text.
        win.Content = "Coding 101";
        // The Width and Height set the size of the window.
        win.Width = 500;
        win.Height = 500;
        // We can change the font of the text by using the FontFamily and
        // FontSize properties.
        win.FontFamily = new FontFamily("Comic Sans MS");
        win.FontSize = 100;
        // In WPF, you use Brush objects to paint with color.  We will create a special
        // brush object that is a gradient fill and use that for the Foreground property
        // which sets the text color.
        Brush brush = new LinearGradientBrush(Colors.Black, Colors.LightGreen, new Point(0.5, 0), new Point(0.5, 1));
        win.Foreground = brush;
        // The background of the window we will just use a solid brush.
        win.Background = Brushes.Black;
        // Windows programs use "events" to let your code know something has
        // changed or the user took some action.  The window class defines lots of
        // events, but we are just going to use the MouseDown event which represents
        // a mouse click in the window.
        // In order to tell our program what to do when the event happens, we
        // have to "handle" the event.  We do that by matching up a function that 
        // we write with the event.  In C#, the += operator does the work of tying
        // the event to the handler.
        win.MouseDown += WindowOnMouseDown;
        // The last step we need to do is call the Run() method of the application
        // object we created.  We pass it the window object we created.  The Run()
        // method makes the window visible, and it keeps the program running 
        // until the main window is closed.
        app.Run(win);
    }
    // WindowOnMouseDown
    // This function is an event handler that we tied to the MouseDown event
    // of our main window in the code above.  We get two arguments sent to
    // this event handler: an object that sent the event, and an object that
    // has a bunch of arguments that describe the event.
    static void WindowOnMouseDown(Object sender, MouseButtonEventArgs args)
    {
        // First, we need to tell our code that this plain object called
        // "sender" is really a Window-type object.
        Window win = sender as Window;
        // We want to change the background color to a random color.
        // To do that we first need a special object of type Random.
        Random rnd = new Random();
        // We are going to make a Color object, but it needs three
        // byte variables, one that represents red, one that represents
        // green, and one that represents blue.  We use the handy class
        // called Convert to convert integers into bytes.
        byte r = Convert.ToByte(rnd.Next(255));
        byte g = Convert.ToByte(rnd.Next(255));
        byte b = Convert.ToByte(rnd.Next(255));
        // We need a brush-type object to paint with, and I just want
        // solid colors, so I use the SolidColorBrush type.
        SolidColorBrush scb = new SolidColorBrush();
        // We set the Color property of the brush using the three bytes
        // we created above.
        scb.Color = Color.FromRgb(r, b, g);
        // And now we set the background color of the window using its
        // Background property.
        win.Background = scb;
    }
}
