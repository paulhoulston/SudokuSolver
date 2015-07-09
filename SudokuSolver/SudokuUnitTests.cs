using System.Linq;
using NUnit.Framework;

namespace SudokuSolver
{
    public class Given_I_have_a_1_by_1_grid
    {
        public class When_the_grid_is_not_populated
        {
            [Test]
            public void Then_the_sudoku_solver_enters_the_correct_value_for_me()
            {
                var singleGridValue = new Solver().Solve();
                Assert.AreEqual(1, singleGridValue[0].Value);
            }
        }
    }

    public class Given_I_have_a_2_by_2_grid
    {
        public class When_the_grid_is_empty
        {
            private readonly Solver.Cell[] _grid = new Solver().Solve();

            [Test]
            public void Then_a_non_empty_grid_is_returned()
            {
                var gridIsNotEmpty = _grid.All(cell => cell.Value.HasValue);
                Assert.True(gridIsNotEmpty);
            }

            [Test]
            public void And_the_grid_is_2_cells_deep()
            {
                Assert.AreEqual(2, _grid.Max(cell => cell.Y));
            }
        }
    }

    public class Solver
    {
        public class Cell
        {
            public readonly int X;
            public readonly int Y;
            public readonly int? Value;

            public Cell(int x, int y, int? value)
            {
                X = x;
                Y = y;
                Value = value;
            }
        }


        public Cell[] Solve()
        {
            return new[] {new Cell(1, 1, 1)};
        }
    }
}
