using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    class GameFlow
    {
        private GameTable gameTable;
        private int Index = 0;

        private List<GameCommand> commandHistory = new List<GameCommand>();

        public GameFlow(GameTable gameTable)
        {
            this.gameTable = gameTable;
        }

        public void ExecuteOperation(Operations operation)
        {
            var gameCommand = new GameCommand(gameTable, operation);
            gameCommand.Execute();
            commandHistory.Add(gameCommand);
            Index = commandHistory.Count()- 1;
        }

        public void Undo()
        {
            Index--;
            commandHistory[Index].Unexecute();      
        }

        public void Redo()
        {
            commandHistory.Add(commandHistory[Index]);
            commandHistory[Index].Execute();
            Index++;
        }
        
        
    }
}
