
namespace ABCs
{
    internal class ABCButton : Button
    {
        public ABCButton(string text, Color color, Font font,
                         Size size, Point location,
                         MouseEventHandler pushHandler, MouseEventHandler releaseHandler)
        {
            Text = text;
            BackColor = color;
            Font = font;
            Size = size;
            Location = location;
            MouseDown += pushHandler;
            MouseUp += releaseHandler;
        }
    }
}
