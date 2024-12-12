using SplashKitSDK;

namespace CircleIntersectExample
{
    public class Program
    {
        public static void Main()
        {
            // Read the data for Circle A
            SplashKit.WriteLine("X coordinate for circle A: ");
            int X_A = SplashKit.ConvertToInteger(SplashKit.ReadLine());
            SplashKit.WriteLine("Y coordinate for circle A: ");
            int Y_A = SplashKit.ConvertToInteger(SplashKit.ReadLine());
            SplashKit.WriteLine("Radient for circle A: ");
            int R_A = SplashKit.ConvertToInteger(SplashKit.ReadLine());

            // Create circle A based on the user's data
            Circle A = SplashKit.CircleAt(X_A, Y_A, R_A);

            //Read the data for Circle B
            SplashKit.WriteLine("X coordinate for circle B: ");
            int X_B = SplashKit.ConvertToInteger(SplashKit.ReadLine());
            SplashKit.WriteLine("Y coordinate for circle B: ");
            int Y_B = SplashKit.ConvertToInteger(SplashKit.ReadLine());
            SplashKit.WriteLine("Radient for circle B: ");
            int R_B = SplashKit.ConvertToInteger(SplashKit.ReadLine());

            // Create circle B based on the user's data
            Circle B = SplashKit.CircleAt(X_B, Y_B, R_B);

            // Detect if the circles intersect
            if (SplashKit.CirclesIntersect(A, B))
            {
                SplashKit.WriteLine("The circles intersect!");
            }
            else
            {
                SplashKit.WriteLine("The circles do not intersect!");
            }

            // Create a window 
            SplashKit.OpenWindow("Circle Intersect", 800, 600);
            SplashKit.ClearScreen();

            // Draw the circles based on the data given by user
            SplashKit.DrawCircle(Color.Red, X_A, Y_A, R_A);
            SplashKit.DrawCircle(Color.Red, X_B, Y_B, R_B);

            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }
    }
}

