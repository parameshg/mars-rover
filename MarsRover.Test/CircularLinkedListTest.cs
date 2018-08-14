using MarsRover.Server.Tools;
using NUnit.Framework;

namespace MarsRover.Test
{
    [TestFixture]
    public class CircularLinkedListTest
    {
        [Test]
        public void TestAddingItem()
        {
            var list = new CircularLinkedList<int>();

            for (var i = 0; i < 10; i++)
                list.Add(i);

            Assert.AreEqual(list.Head.Value, 0);
            Assert.AreEqual(list.Tail.Value, 9);
            Assert.AreEqual(list.Current.Value, 0);
        }

        [Test]
        public void TestMovingToNextItem()
        {
            var list = new CircularLinkedList<int>();

            for (var i = 0; i < 10; i++)
                list.Add(i);

            Assert.AreEqual(list.Head.Value, 0);
            Assert.AreEqual(list.Tail.Value, 9);

            Assert.AreEqual(list.Current.Value, 0);

            list.Next();

            Assert.AreEqual(list.Current.Value, 1);
        }

        [Test]
        public void TestMovingToPreviousItem()
        {
            var list = new CircularLinkedList<int>();

            for (var i = 0; i < 10; i++)
                list.Add(i);

            Assert.AreEqual(list.Head.Value, 0);
            Assert.AreEqual(list.Tail.Value, 9);

            Assert.AreEqual(list.Current.Value, 0);

            list.Previous();

            Assert.AreEqual(list.Current.Value, 9);
        }

        [Test]
        public void TestMovingToSpecificItem()
        {
            var list = new CircularLinkedList<int>();

            for (var i = 0; i < 10; i++)
                list.Add(i);

            Assert.AreEqual(list.Head.Value, 0);
            Assert.AreEqual(list.Tail.Value, 9);

            Assert.AreEqual(list.Current.Value, 0);

            list.GoTo(5);

            Assert.AreEqual(list.Current.Value, 5);
        }
    }
}