using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    abstract class Command
    {
        abstract public void Execute();
    }

    class FileOpenCommand : Command
    {
        protected FileViewer fileViewer;
        public FileOpenCommand(FileViewer viewer)
        {
            this.fileViewer = viewer;
        }
        public override void Execute()
        {
            fileViewer.ShowFile();
        }
    }

    class FileViewer
    {
        public void ShowFile()
        {
            Console.WriteLine("FileViewer ShowFile");
        }
    }

    class InvokeCommand
    {
        private Command command;

        public InvokeCommand(Command command)
        {
            this.command = command;
        }
        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
