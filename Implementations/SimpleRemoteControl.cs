using HeadFirstCommandPatternSample.Abstractions;

namespace HeadFirstCommandPatternSample.Implementations
{
    public class SimpleRemoteControl : IRemoteControl
    {
        private ICommand _slot;

        public SimpleRemoteControl(ICommand slot) => _slot = slot;

        public void SetCommand(ICommand command)
        {
            _slot = command;
        }

        public void ButtonWasPressed()
        {
            _slot.Execute();
        }

        public void UndoButtonWasPressed()
        {
            _slot.Undo();
        }
    }
}
