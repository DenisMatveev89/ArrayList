using NUnit.Framework;


namespace ArrayList.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0 })]
        public void ReverseTest(int[] array, int[] ex)
        {
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            int[] actual = al.Reverse();
            Assert.AreEqual(ex, actual);

        }

        [TestCase(1, new int[] { 1 })]
        [TestCase(0, new int[] { 0 })]
        [TestCase(10, new int[] { 10 })]
        [TestCase(-10, new int[] { -10 })]
        public void AddLastTest(int a, int[] ex)
        {
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList();
            al.AddLast(a);
            int[] actual = al.ToArray();
            Assert.AreEqual(ex, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        [TestCase(new int[] { }, new int[] { })]
        public void AddLastTest(int[] a, int[] ex)
        {
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList();
            al.AddLast(a);
            int[] actual = al.ToArray();
            Assert.AreEqual(ex, actual);

        }
        [TestCase(5, new int[] { 5, 2, 2, 2 })]
        [TestCase(0, new int[] { 0, 2, 2, 2 })]
        [TestCase(100, new int[] { 100, 2, 2, 2 })]
        public void AddFirstTest(int a, int[] ex)
        {
            int[] array = new int[] { 2, 2, 2 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            al.AddFirst(a);
            int[] actual = al.ToArray();
            Assert.AreEqual(ex, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5, 2, 2, 2 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 2, 2, 2 })]
        [TestCase(new int[] { 0, 0 }, new int[] { 0, 0, 2, 2, 2 })]
        public void AddFirstTest(int[] a, int[] ex)
        {
            int[] array = new int[] { 2, 2, 2 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            al.AddFirst(a);
            int[] actual = al.ToArray();
            Assert.AreEqual(ex, actual);
        }
        [TestCase(3, 25, new int[] { 2, 2, 2, 25, 5, 8 })]
        [TestCase(7, 25, new int[] { 2, 2, 2, 5, 8 })]
        [TestCase(2, 0, new int[] { 2, 2, 0, 2, 5, 8 })]
        [TestCase(0, 0, new int[] { 0, 2, 2, 2, 5, 8 })]
        [TestCase(1, 0, new int[] { 2, 0, 2, 2, 5, 8 })]
        public void AddAtTest(int a, int b, int[] ex)
        {
            int[] array = new int[] { 2, 2, 2, 5, 8 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            al.AddAt(a, b);
            int[] actual = al.ToArray();
            Assert.AreEqual(ex, actual);
        }
        [TestCase(1, new int[] { 3, 0, 2, 7 }, new int[] { 2, 3, 0, 2, 7, 2, 2, 5, 8 })]
        [TestCase(0, new int[] { 3, 0, 2, 7 }, new int[] { 3, 0, 2, 7, 2, 2, 2, 5, 8 })]
        [TestCase(5, new int[] { 3, 0, 2, 7 }, new int[] { 2, 2, 2, 5, 8, 3, 0, 2, 7 })]
        [TestCase(4, new int[] { 3, 0, 2, 7 }, new int[] { 2, 2, 2, 5, 3, 0, 2, 7, 8 })]
        public void AddAtTest(int a, int[] b, int[] ex)
        {
            int[] array = new int[] { 2, 2, 2, 5, 8 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            al.AddAt(a, b);
            int[] actual = al.ToArray();
            Assert.AreEqual(ex, actual);
        }
        [TestCase(2, 45, new int[] { 2, 2, 45, 5, 8 })]
        [TestCase(1, 45, new int[] { 2, 45, 2, 5, 8 })]
        [TestCase(0, 45, new int[] { 45, 2, 2, 5, 8 })]
        [TestCase(2, 45, new int[] { 2, 2, 45, 5, 8 })]
        [TestCase(6, 45, new int[] { 2, 2, 2, 5, 8 })]
        public void SetTest(int a, int b, int[] ex)
        {
            int[] array = new int[] { 2, 2, 2, 5, 8 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            al.Set(a, b);
            int[] actual = al.ToArray();
            Assert.AreEqual(ex, actual);
        }

        [TestCase(new int[] { 2, 2, 5, 8 })]
        public void RemoveFirstTest(int[] ex)
        {
            int[] array = new int[] { 2, 2, 2, 5, 8 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            al.RemoveFirst();
            int[] actual = al.ToArray();
            Assert.AreEqual(ex, actual);
        }

        [TestCase(new int[] { 2, 2, 2, 5 })]
        public void RemoveLastTest(int[] ex)
        {
            int[] array = new int[] { 2, 2, 2, 5, 8 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            al.RemoveLast();
            int[] actual = al.ToArray();
            Assert.AreEqual(ex, actual);
        }
        [TestCase(1, new int[] { 1, 2, 2, 5, 8 })]
        [TestCase(3, new int[] { 1, 2, 2, 5, 8 })]
        [TestCase(0, new int[] { 2, 2, 2, 5, 8 })]
        [TestCase(5, new int[] { 1, 2, 2, 2, 5 })]
        [TestCase(6, new int[] { 1, 2, 2, 2, 5, 8 })]

        public void RemoveAtTest(int a, int[] ex)
        {
            int[] array = new int[] { 1, 2, 2, 2, 5, 8 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            al.RemoveAt(a);
            int[] actual = al.ToArray();
            Assert.AreEqual(ex, actual);
        }

         [TestCase(2, new int[] { 1, 5, 8, 5 })]
         [TestCase(0, new int[] { 1, 2, 2, 2, 5, 8, 5, 2 })]
         [TestCase(8, new int[] { 1, 2, 2, 2, 5, 5, 2 })]
         [TestCase(5, new int[] { 1, 2, 2, 2, 8, 2 })]
         [TestCase(1, new int[] { 2, 2, 2, 5, 8, 5, 2 })]

         public void RemoveAllTest(int a, int[] ex)
         {
             int[] array = new int[] { 1, 2, 2, 2, 5, 8, 5, 2 };
             ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
             al.RemoveAll(a);
             int[] actual = al.ToArray();
             Assert.AreEqual(ex, actual);
         }

        [TestCase(0, false)]
        [TestCase(2, true)]
        [TestCase(5, true)]
        [TestCase(8, true)]
        [TestCase(88, false)]
        public void ContainsTest(int a, bool ex)
        {
            int[] array = new int[] { 2, 2, 2, 5, 8 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            bool actual = al.Contains(a);
            Assert.AreEqual(ex, actual);
        }

        [TestCase(88, -1)]
        [TestCase(2, 0)]
        [TestCase(5, 3)]
        [TestCase(8, 4)]
        public void IndexOfTest(int a, int ex)
        {
            int[] array = new int[] { 2, 2, 2, 5, 8 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            int actual = al.IndexOf(a);
            Assert.AreEqual(ex, actual);
        }
        [TestCase(2)]
        public void GetFirstTest(int ex)
        {
            int[] array = new int[] { 2, 2, 2, 5, 8 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            int actual = al.GetFirst();
            Assert.AreEqual(ex, actual);
        }

        [TestCase(8)]
        public void GetLastTest(int ex)
        {
            int[] array = new int[] { 2, 2, 2, 5, 8 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            int actual = al.GetLast();
            Assert.AreEqual(ex, actual);
        }

        [TestCase(1, 2)]
        [TestCase(0, 2)]
        [TestCase(2, 2)]
        [TestCase(3, 5)]
        [TestCase(4, 8)]
        [TestCase(4, 8)]
        [TestCase(5, 0)]
        public void GetTest(int a, int ex)
        {
            int[] array = new int[] { 2, 2, 2, 5, 8 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            int actual = al.Get(a);
            Assert.AreEqual(ex, actual);
        }

        [TestCase(8)]
        public void MaxTest(int ex)
        {
            int[] array = new int[] { 2, 2, 2, 5, 8 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            int actual = al.Max();
            Assert.AreEqual(ex, actual);
        }

        [TestCase(2)]
        public void MinTest(int ex)
        {
            int[] array = new int[] { 2, 2, 2, 5, 8 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            int actual = al.Min();
            Assert.AreEqual(ex, actual);
        }

        [TestCase(4)]
        public void IndexOfMaxTest(int ex)
        {
            int[] array = new int[] { 2, 2, 2, 5, 8 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            int actual = al.IndexOfMax();
            Assert.AreEqual(ex, actual);
        }

        [TestCase(0)]
        public void IndexOfMinTest(int ex)
        {
            int[] array = new int[] { 2, 2, 2, 5, 8 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            int actual = al.IndexOfMin();
            Assert.AreEqual(ex, actual);
        }

        [TestCase(new int[] { 1, 2, 6, 7, 8 })]
        public void SortTest(int[] ex)
        {
            int[] array = new int[] { 6, 7, 8, 1, 2 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            al.Sort();
            int[] actual = al.ToArray();
            Assert.AreEqual(ex, actual);
        }

        [TestCase(new int[] { 8, 7, 6, 2, 1 })]
        public void SortDescTest(int[] ex)
        {
            int[] array = new int[] { 6, 7, 8, 1, 2 };
            ArrayListProject.ArrayList al = new ArrayListProject.ArrayList(array);
            al.SortDesc();
            int[] actual = al.ToArray();
            Assert.AreEqual(ex, actual);
        }
    }
}