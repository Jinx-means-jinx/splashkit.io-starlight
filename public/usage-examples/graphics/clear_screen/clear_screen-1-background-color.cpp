#include "splashkit.h"

#include "splashkit.h"

int main()
{
    open_window("Blue Background", 800, 600);
<<<<<<< HEAD:public/usage-examples/graphics/clear_screen/clear_screen-1-background-color.cpp
=======
    clear_screen();
    refresh_screen(60);
    delay(1000);
>>>>>>> ff3ab6b (change the title to blue background):src/assets/usage-examples-code/graphics/clear_screen/clear_screen-1-background-color.cpp
    
    clear_screen(COLOR_BLUE);
    refresh_screen(60);
    delay(4000);

    close_all_windows();

    return 0;
}