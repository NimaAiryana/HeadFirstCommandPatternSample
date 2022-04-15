namespace HeadFirstCommandPatternSample.Abstractions
{
    public interface IRemoteControl
    {
        void SetCommand(ICommand command);
        void ButtonWasPressed();
        void UndoButtonWasPressed();
    }
}
