namespace Part1
{
    public interface IFigure
    {
        void ChangeColor(string Color);
        void MoveHorizontally(double distance);
        void MoveVertically(double distance);
        void PrintVisibility();
        void PrintInfo();
    }
}
