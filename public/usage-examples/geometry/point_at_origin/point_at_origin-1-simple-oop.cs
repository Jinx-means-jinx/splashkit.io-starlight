using SplashKitSDK;

namespace PointAtExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Point At Origin", 800, 600);
            window.Clear(Color.White);

            // Create a point at origin
            Point2D Point = SplashKit.PointAtOrigin();

            // Create circle at the origin point
            SplashKit.FillCircle(Color.Red, Point.X, Point.Y, 4);

            window.Refresh();
            SplashKit.Delay(4000);
            window.Close();
        }
    }
}

