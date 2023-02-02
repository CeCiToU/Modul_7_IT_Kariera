using System;

namespace SkeletonTest
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            //Arrange
            Axe axe = new Axe(10,10);
            Dummy dummy = new Dummy(10,10);

            //Act
            axe.Attack(dummy);

            //Assert
            Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe durability does not change after attack!");

        }


        [Test]
        public void BrockenAxeCanAttack()
        {
            //Arrange
            Axe axe = new Axe(2,2);
            Dummy dummy = new Dummy(20,20);

            //Act
            axe.Attack(dummy);
            axe.Attack(dummy);

            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Axe is broken."));

        }
    }
}