
using Moq;
using WinFormsApp1;

namespace TestProject1
{
    public class Tests
    {
        //public IFakeInterface fakeInterface { get; set; }

        [SetUp]
        public void Setup()
        {

        }



        [Test]

        public void CountButtonClick()
        {

            Form1 form = new Form1();
            form.btnCalculate_Click(null, null);
            Assert.That(() => form.Message == "You have to enter a name");
        }

        [Test]
        public void NumBalanceError()
        {
            Form1 form = new Form1("Must be between 10k and 1MM");

            Assert.That(() => form.Message == "Must be between 10k and 1MM");
        }

    }
}