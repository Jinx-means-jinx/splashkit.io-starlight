using static SplashKitSDK.SplashKit;

OpenWindow("Blue Background", 800, 600);
<<<<<<< HEAD:public/usage-examples/graphics/clear_screen/clear_screen-1-simple.cs
=======

ClearScreen();
RefreshScreen(60);
Delay(1000);
>>>>>>> ff3ab6b (change the title to blue background):src/assets/usage-examples-code/graphics/clear_screen/clear_screen-1-background-color.cs

ClearScreen(ColorBlue());
RefreshScreen(60);
Delay(4000);

CloseAllWindows();