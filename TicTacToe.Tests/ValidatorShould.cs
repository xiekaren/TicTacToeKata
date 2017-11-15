using System;
using NUnit.Framework;

namespace TicTacToe.Tests
{
    public class ValidatorShould
    {
        private Validator _validator;

        [SetUp]
        public void SetUp()
        {
            _validator = new Validator();
        }

        [Test]
        [TestCase("X        ", "X", 0)]
        [TestCase("X        ", "X", -1)]
        [TestCase("X        ", "X", 9)]
        public void CheckForInvalidPlays(string board, string token, int position)
        {
            Assert.Throws<ArgumentException>(() => _validator.ValidatePlay(board, position));
        }
    }
}
