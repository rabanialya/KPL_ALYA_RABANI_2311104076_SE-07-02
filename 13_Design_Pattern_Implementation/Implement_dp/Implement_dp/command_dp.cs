using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_dp
{
    public interface ICommand
    {
        public void Execute();
    }
    public class Television
    {
        public void TurnOn()
        {
            Console.WriteLine("Television is on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Television is off");
        }
    }

    public class TelevisionTurnOn : ICommand
    {
        private readonly Television? _television;

        public TelevisionTurnOn(Television? television)
        {
            _television = television;
        }
        public void Execute()
        {
            _television!.TurnOn();
        }
    }

    public class TelevisionTurnOff : ICommand
    {
        private readonly Television? _television;

        public TelevisionTurnOff(Television? television)
        {
            _television = television;
        }
        public void Execute()
        {
            _television!.TurnOff();
        }
    }
    public class RemoteTV
    {
        private ICommand? turnOn;
        private ICommand? turnOff;

        public void setTurnOn(ICommand command)
        {
            turnOn = command;
        }
        public void setTurnOff(ICommand command)
        {
            turnOn = command;
        }
        public void TurnOnTV()
        {
            turnOn!.Execute();
        }
        public void turnOffTV()
        {
            //turnOff!.Execute();
        }
    }
}