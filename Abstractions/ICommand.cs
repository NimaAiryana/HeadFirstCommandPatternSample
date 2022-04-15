namespace HeadFirstCommandPatternSample.Abstractions
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
