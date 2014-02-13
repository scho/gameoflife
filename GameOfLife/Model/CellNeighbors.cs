using System.Collections.Generic;
using System.Linq;

namespace GameOfLife.Model
{
    public class CellNeighbors
    {
        private readonly IList<Cell> collection;

        public CellNeighbors()
        {
            collection = new List<Cell>();
        }

        public void AddCell(Cell cell)
        {
            collection.Add(cell);
        }

        public bool GetNextState(bool currentState)
        {
            if (StateCanChange())
            {
                return CountAlive() == 3;
            }
            return currentState;
        }

        private bool StateCanChange()
        {
            return CountAlive() != 2;
        }

        private int CountAlive()
        {
            return collection.Count(node => node.IsAlive());
        }
    }
}
