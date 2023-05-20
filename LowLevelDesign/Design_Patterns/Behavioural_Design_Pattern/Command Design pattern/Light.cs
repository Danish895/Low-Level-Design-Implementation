using System.Dynamic;
using System;

namespace LowLevelDesign.Design_Patterns.Behavioural_Design_Pattern.Command_Design_pattern
{
    // Receiver: Represents a device in the home automation system
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is off");
        }
    }

    // Command: Declares the execution methods for commands
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    // Concrete Command: Implements the ICommand interface for turning the light on
    public class TurnOnLightCommand : ICommand
    {
        private Light _light;

        public TurnOnLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }

        public void Undo()
        {
            _light.TurnOff();
        }
    }

    // Concrete Command: Implements the ICommand interface for turning the light off
    public class TurnOffLightCommand : ICommand
    {
        private Light _light;

        public TurnOffLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }

        public void Undo()
        {
            _light.TurnOn();
        }
    }

    // Invoker: Responsible for executing commands
    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }

        public void PressUndo()
        {
            _command.Undo();
        }
    }
}
//    Now, let's see how we can use this implementation:

//csharp
//Copy code
/*
// Create receiver objects
Light livingRoomLight = new Light();
    Light kitchenLight = new Light();

    // Create concrete commands and associate them with the receivers
    ICommand livingRoomLightOn = new TurnOnLightCommand(livingRoomLight);
    ICommand livingRoomLightOff = new TurnOffLightCommand(livingRoomLight);
    ICommand kitchenLightOn = new TurnOnLightCommand(kitchenLight);
    ICommand kitchenLightOff = new TurnOffLightCommand(kitchenLight);

    // Create invoker and associate it with the commands
    RemoteControl remoteControl = new RemoteControl();
    remoteControl.SetCommand(livingRoomLightOn);

// Press the button to turn on the living room light
remoteControl.PressButton();  // Output: "Light is on"

// Press the button to turn off the living room light
remoteControl.SetCommand(livingRoomLightOff);
remoteControl.PressButton();  // Output: "Light is off"

// Press the undo button to undo the last command (turn off the living room light)
remoteControl.PressUndo();    // Output: "Light is on"

// Set a new command to turn on the kitchen light
remoteControl.SetCommand(kitchenLightOn);

// Press the button to turn on the kitchen light
remoteControl.PressButton();  // Output: "Light is on"
In this example, we have a Light class representing a device, and we create concrete commands(TurnOnLightCommand and TurnOffLightCommand) that encapsulate the actions of turning the light on and off, respectively.The RemoteControl class acts as the invoker, associating commands and executing them when a button is pressed.The invoker can also support undo functionality by calling the Undo() method on the command.
}
*/
