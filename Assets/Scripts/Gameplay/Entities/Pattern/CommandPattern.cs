using System.Collections.Generic;

namespace Shark.Gameplay.Entities.Pattern
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }

    public class CommandInvoker
    {
        private static readonly Stack<ICommand> _undoStack = new();

        public static void Execute(ICommand command)
        {
            command.Execute();
            _undoStack.Push(command);
        }

        public static void Undo()
        {
            if (_undoStack.Count > 0)
            {
                ICommand active = _undoStack.Pop();
                active.Undo();
            }
        }
    }
}