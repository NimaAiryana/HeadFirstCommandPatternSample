using HeadFirstCommandPatternSample;
using HeadFirstCommandPatternSample.Abstractions;
using HeadFirstCommandPatternSample.Implementations;

Console.WriteLine("Hello, Command Pattern :D");

Light light = new();
ICommand lightOnCommand = new LightOnCommand(light);
IRemoteControl remote = new SimpleRemoteControl(lightOnCommand);

remote.ButtonWasPressed();

remote.UndoButtonWasPressed();

Console.WriteLine("-----------------------");

Stereo stereo = new();
ICommand stereoOnCommand = new StereoOnWithCDCommand(stereo);

remote.SetCommand(stereoOnCommand);

remote.ButtonWasPressed();

remote.UndoButtonWasPressed();
