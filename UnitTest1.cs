namespace env {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void Test1() {
            System.Console.WriteLine("yep");
            Assert.Pass();
        }
    }
}