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
                Assert.AreEqual(1, singleGridValue);
            }
        }
    }

    public class Solver
    {
        public int Solve()
        {
            return 1;
        }
    }
}
