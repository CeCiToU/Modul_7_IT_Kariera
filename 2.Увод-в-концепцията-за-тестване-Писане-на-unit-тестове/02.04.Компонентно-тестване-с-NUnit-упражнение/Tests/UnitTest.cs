namespace DummyTest
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }


        [Test]
        public void DummyLosesHealthWhenIsAttacked()
        {
            //Arrange
            Axe axe = new Axe(10,10);
            Dummy dummy = new Dummy(20,20);

            //Act
            axe.Attack(dummy);
            //Assert
            Assert.That(dummy.Health, Is.EqualTo(10), "Dummy does not losing health!");
        }


        [Test]
        public void DeadDummyThrowsException()
        {
            //Arrange
            Axe axe = new Axe(10,10);
            Dummy dummy = new Dummy(10,10);

            //Act
            axe.Attack(dummy);

            //Assert
            var ex = Assert.Throws< InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
        }


        [Test]
        public void DeadDummyGivesEXP()
        {
            //Arrange
            Axe axe =new Axe(10,10);
            Dummy dummy = new Dummy(10,10);

            //Act
            axe.Attack(dummy);
            var exp = dummy.GiveExperience();

            //Assert
            Assert.That(exp, Is.EqualTo(10), "Dead dummy does not give experience!");

        }

        [Test]
        public void AliveDummyCannotGiveEXP()
        {
            //Arrange
            Dummy dummy= new Dummy(20,20);

            //Act
            //NO ACTION!

            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
            Assert.That(ex.Message, Is.EqualTo("Target is not dead."));
        }
    }
}