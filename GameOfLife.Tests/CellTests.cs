using GameOfLife.Model;
using NUnit.Framework;

namespace GameOfLife.Tests
{
    [TestFixture]
    public class CellTests
    {
        public class State
        {
            [Test]
            public void NoNeighborsDies()
            {
                var cell = Cell.CreateAlive();
                cell.StoreNextState();
                cell.ApplyNextState();
                Assert.That(cell.IsAlive(), Is.False);
            }

            [Test]
            public void OneNeighborDies()
            {
                var cell = Cell.CreateAlive();
                cell.AddNeighbor(Cell.CreateAlive());
                cell.StoreNextState();
                cell.ApplyNextState();
                Assert.That(cell.IsAlive(), Is.False);
            }

            [Test]
            public void TwoNeighborsStaysAlive()
            {
                var cell = Cell.CreateAlive();
                cell.AddNeighbor(Cell.CreateAlive());
                cell.AddNeighbor(Cell.CreateAlive());
                cell.StoreNextState();
                cell.ApplyNextState();
                Assert.That(cell.IsAlive(), Is.True);
            }

            [Test]
            public void TwoNeighborsStaysDead()
            {
                var cell = Cell.CreateDead();
                cell.AddNeighbor(Cell.CreateAlive());
                cell.AddNeighbor(Cell.CreateAlive());
                cell.StoreNextState();
                cell.ApplyNextState();
                Assert.That(cell.IsAlive(), Is.False);
            }

            [Test]
            public void ThreeNeighborsBecomesAlive()
            {
                var cell = Cell.CreateDead();
                cell.AddNeighbor(Cell.CreateAlive());
                cell.AddNeighbor(Cell.CreateAlive());
                cell.AddNeighbor(Cell.CreateAlive());
                cell.StoreNextState();
                cell.ApplyNextState();
                Assert.That(cell.IsAlive(), Is.True);
            }

            [Test]
            public void FourNeighborsDies()
            {
                var cell = Cell.CreateAlive();
                cell.AddNeighbor(Cell.CreateAlive());
                cell.AddNeighbor(Cell.CreateAlive());
                cell.AddNeighbor(Cell.CreateAlive());
                cell.AddNeighbor(Cell.CreateAlive());
                cell.StoreNextState();
                cell.ApplyNextState();
                Assert.That(cell.IsAlive(), Is.False);
            }

            [Test]
            public void FourNeighborsStaysDies()
            {
                var cell = Cell.CreateDead();
                cell.AddNeighbor(Cell.CreateAlive());
                cell.AddNeighbor(Cell.CreateAlive());
                cell.AddNeighbor(Cell.CreateAlive());
                cell.AddNeighbor(Cell.CreateAlive());
                cell.StoreNextState();
                cell.ApplyNextState();
                Assert.That(cell.IsAlive(), Is.False);
            }
        }
    }
}