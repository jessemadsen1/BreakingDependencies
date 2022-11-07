using Moq;
using WinFormsApp1;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]

        public void CountButtonClick()
        {
            Assert.That(() => form.Message == "You have to enter a name");
        }

        [Test]
        public void NumBalanceError()
        {
            Assert.That(() => form.Message == "Must be between 10k and 1MM");
        }
    }
}