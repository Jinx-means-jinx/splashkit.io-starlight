#include "splashkit.h"

int main()
{
    open_window("Fill Ellipse", 800, 600);
    clear_screen();
    fill_ellipse(COLOR_BLUE, 200, 200, 100, 200);
    refresh_screen(60);
    delay(4000);

    close_all_windows();

    return 0;
}