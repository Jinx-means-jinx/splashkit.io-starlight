using SplashKitSDK;

namespace CircleRadius
{
    public class Program
    {
        public static void Main()
        {
        SplashKit.OpenWindow("Circle Radius", 800, 600);
        SplashKit.ClearScreen();

        // Set position for the circle
        double x_position = 400;
        double y_position = 300;

         //Create a circle A at the position (x_position, y_position)
        Circle A = SplashKit.CircleAt(x_position, y_position, 200);
        
        // Find the radius of the circle A
        double radius = SplashKit.CircleRadius(A);

        //Draw the Circle
        SplashKit.DrawCircle(Color.Red, x_position, y_position, radius);
    
        string text = "Radius: " + radius.ToString();
        // Print result on window
        SplashKit.DrawText(text, Color.Black, "NORMAL_FONT", 20, 100, 100);

        SplashKit.RefreshScreen();
        SplashKit.Delay(4000);
        SplashKit.CloseAllWindows();
        }
    }
}