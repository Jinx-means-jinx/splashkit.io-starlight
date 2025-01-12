using SplashKitSDK;

<<<<<<< HEAD
namespace PointAtExample
=======
namespace PointAtOriginExample
>>>>>>> 5163b4e104893852aa36c4b37e4e62f72397b0bb
{
    public class Program
    {
        public static void Main()
        {
<<<<<<< HEAD
            Window window = new Window("Point At Origin", 800, 600);
            window.Clear(Color.White);

            // Create a point at origin
            Point2D Point = SplashKit.PointAtOrigin();

            // Create circle at the origin point
            SplashKit.FillCircle(Color.Red, Point.X, Point.Y, 4);

            window.Refresh();
            SplashKit.Delay(4000);
            window.Close();
=======
            SplashKit.OpenWindow("Point At Origin", 800, 600);

            // Create a point at origin
            Point2D point = SplashKit.PointAtOrigin();

            // Create red circle at the origin point
            SplashKit.ClearScreen();
            SplashKit.FillCircle(Color.Red, point.X, point.Y, 4);
            SplashKit.RefreshScreen();

            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
>>>>>>> 5163b4e104893852aa36c4b37e4e62f72397b0bb
        }
    }
}