namespace Part1
{
    abstract class Figure : IFigure
    {
        protected string color;
        protected bool isVisible;
        protected double x;
        protected double y;

        public Figure(string Color, bool IsVisible)
        {
            color = Color;
            isVisible = IsVisible;
            x = 0;
            y = 0;
        }
        public void ChangeColor(string Color)
        {
            color = Color;
        }
        public void MoveHorizontally(double distance)
        {
            x += distance;
        }
        public void MoveVertically(double distance)
        {
            y += distance;
        }
        public abstract void PrintVisibility();
        public abstract void PrintInfo();
    }
}
