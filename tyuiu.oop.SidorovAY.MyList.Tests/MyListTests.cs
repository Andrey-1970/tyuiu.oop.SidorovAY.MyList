namespace tyuiu.oop.SidorovAY.MyList.Tests
{
    [TestClass]
    public class MyListTests
    {
        [TestMethod]
        public void CreateMyListValid()
        {
            MyList<int> list = new MyList<int>();
            Assert.IsNotNull(list);
            Assert.AreEqual(0, list.Count);
        }
        [TestMethod]
        public void MyListAddValid()
        {
            var list = new MyList<int>();
            Assert.IsNotNull(list);
            list.Add(1);
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(1, list[0]);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MyListGetInvalid()
        {
            var list = new MyList<int>();
            Assert.IsNotNull(list);
            Assert.AreEqual(0, list.Count);
            Assert.AreEqual(1, list[0]);
        }
        [TestMethod]
        public void MyListAddItemMoreThenSizeValid()
        {
            var list = new MyList<int>();
            Assert.IsNotNull(list);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Assert.AreEqual(5, list.Count);
        }
    }
}