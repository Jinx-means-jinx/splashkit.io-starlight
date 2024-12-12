using SplashKitSDK;
 
namespace HasFont
{
    public class Program
    {
        public static void Main()
        {  
            // Load a font
            SplashKit.LoadFont("my_font", "arial.ttf");
 
            // Check if the font exists
            bool fontCheck = SplashKit.HasFont("my_font");
 
            // Display the result
            if (fontCheck)
            {
                SplashKit.WriteLine("Font found!");
            }
            else
            {
                SplashKit.WriteLine("Font not found!");
            }
        }
    }
}