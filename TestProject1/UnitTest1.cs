using Triangle;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
             int[] a = { 3, 1, 2 };
             int[] b = { 4, 2, 3 };
             int[] c = { 5, 3, 4 };
             int n = 3;
    
             TriangleCalculator calculator = new TriangleCalculator();
             int count = calculator.Count(a, b, c, n);
    
             Assert.That(count, Is.EqualTo(2));
        }
        [Test]
        public void Test2()
        {
            int[] a = { 0, 0 };
            int[] b = { 0, 0 };
            int[] c = { 0, 0 }; 
            int n = 2;

            TriangleCalculator calculator = new TriangleCalculator();
            int count = calculator.Count(a, b, c, n);

            Assert.That(count, Is.EqualTo(0));
        }
        [Test]
        public void Test3()
        {
            int[] a = { 1, 10, 2 };
            int[] b = { 2, 2, 2 };
            int[] c = { 3, 3, 10 };
            int n = 3;

            TriangleCalculator calculator = new TriangleCalculator();
            int count = calculator.Count(a, b, c, n);

            Assert.That(count, Is.EqualTo(0));
        }
        [Test]
        public void Test4()
        {
            int[] a = { 3, 5, 6 };//равносторонний
            int[] b = { 3, 5, 5 };//рвб
            int[] c = { 3, 2, 4 };//разносторонний
            int n = 3;

            TriangleCalculator calculator = new TriangleCalculator();
            int count = calculator.Count(a, b, c, n);

            Assert.That(count, Is.EqualTo(3));
        }
        [Test]
        public void Test5()
        {
            int[] a = { 3, 0, -3, 5 };
            int[] b = { 4, 4, 4, 5 };
            int[] c = { 5, 5, 5, 5 };
            int n = 4;

            TriangleCalculator calculator = new TriangleCalculator();
            int count = calculator.Count(a, b, c, n);

            Assert.That(count, Is.EqualTo(2));
        }
    }
}
