using System.Collections.Generic;
using System.Linq;

namespace GameOfLife.Model
{
    public class NieghborhoodInitializer
    {
        private readonly IList<IList<Cell>> field;
        private readonly Cell cell;

        public NieghborhoodInitializer(IList<IList<Cell>> field, Cell cell)
        {
            this.field = field;
            this.cell = cell;
        }

        public void Initialize()
        {
            SetNeighborsForPreviousRow();
            SetNeighborsForCurrentRow();
        }

        private void SetNeighborsForPreviousRow()
        {
            if (field.Count <= 1)
            {
                return;
            }

            var previousRow = field[field.Count - 2];
            var currentRow = field.Last();
            var currentIndex = currentRow.IndexOf(cell);

            SetNeighborForRow(previousRow, currentIndex - 1);
            SetNeighborForRow(previousRow, currentIndex);
            SetNeighborForRow(previousRow, currentIndex + 1);
        }

        private void SetNeighborsForCurrentRow()
        {
            var currentRow = field.Last();

            SetNeighborForRow(currentRow, currentRow.Count - 2);
        }

        private void SetNeighborForRow(IList<Cell> row, int index)
        {
            if (row.Count > index && index >= 0)
            {
                SetNeighborhood(row[index]);
            }
        }

        private void SetNeighborhood(Cell neighborCell)
        {
            cell.AddNeighbor(neighborCell);
            neighborCell.AddNeighbor(cell);
        }
    }
}