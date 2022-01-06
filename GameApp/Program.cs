using System;

namespace GameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameTable = new GameTable();
            //    var command1 = new GameCommand(gameTable, Operations.UP);
            //   command1.Execute();
            //   command1.Execute();
            //  command1.Unexecute();

            var gameFlow = new GameFlow(gameTable);
            gameFlow.ExecuteOperation(Operations.DOWN);
            gameFlow.ExecuteOperation(Operations.RIGHT);
            gameFlow.ExecuteOperation(Operations.LEFT);
            gameFlow.Redo();
            gameFlow.Undo();
            gameFlow.Redo();
            gameFlow.Redo();
            gameFlow.Redo();
            gameFlow.Redo();
            gameFlow.Redo();
            gameFlow.Redo();
            gameFlow.Redo();
        }
    }
}
