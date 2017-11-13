using System;
using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class ValidatorShould
    {
        private Validator _validator;

        [SetUp]
        public void SetUp()
        {
            _validator = new Validator();
        }

        [Test]
        [TestCase("X        ", 0)]
        [TestCase("X        ", -1)]
        [TestCase("X        ", 9)]
        public void CheckForInvalidInputs(string board, int position)
        {
            Assert.Throws<ArgumentException>(() => _validator.IsValid(board, position));
        }
    }
}
