#include "splashkit.h"

int main()
{
    open_window("Circle Y", 800, 600);
    clear_screen();

    //Set position for the circle
    double x_position = 400;
    //Give random  y_position value bewteen 200 - 400
    double y_position = rnd(200) + 200;

    //Create a circle A at the position (x_position, y_position)
    circle A = circle_at(x_position, y_position, 200);
    //Find the Y position of the circle
    double circleY = circle_y(A);

    //Draw the Circle
    draw_circle(COLOR_RED, x_position, circleY, 200);

    //Draw a line to show the circle Y coordinate
    draw_line(COLOR_BLACK, 0, circleY, 800, circleY);
    
    string text = "Circle Y: " + std::to_string(circleY);
    //Print result on window
    draw_text(text, COLOR_BLACK, 100, 100);

    //Draw 10 circles with radient 50 and the same circle y coordinate
    for (int i = 0; i < 10; i++)
    {
        int x = i * 60 + 100;
        int radiant = 50;

        draw_circle(COLOR_BLUE, x, circleY, radiant);
    }
    
    refresh_screen();
    delay(4000);
    close_all_windows();
}