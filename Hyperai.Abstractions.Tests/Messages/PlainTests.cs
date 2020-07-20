using Hyperai.Messages.ConcreteModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hyperai.Abstractions.Tests.Messages
{
    [TestClass]
    public class PlainTests
    {
        [TestMethod]
        public void Equals_WithNull_ReturnsFalse()
        {
            // Arrange
            Plain p1 = new Plain("a dog");
            // Act
            bool assert = p1.Equals(null);
            // Assert
            Assert.IsFalse(assert);
        }

        [TestMethod]
        public void Equals_WithOther_ReturnsFalse()
        {
            // Arrange
            Plain p1 = new Plain("a dog");
            Plain p2 = new Plain("a cat");
            // Act
            bool assert = p1.Equals(p2);
            // Assert
            Assert.IsFalse(assert);
        }

        [TestMethod]
        public void Equals_WithSelf_ReturnsTrue()
        {
            // Arrange
            Plain p1 = new Plain("a dog");
            // Act
            bool assert = p1.Equals(p1);
            // Assert
            Assert.IsTrue(assert);
        }

        [TestMethod]
        public void Equals_WithSame_ReturnsTrue()
        {
            // Arrange
            Plain p1 = new Plain("a dog");
            Plain p2 = new Plain("a dog");
            // Act
            bool assert = p1.Equals(p2);
            // Assert
            Assert.IsTrue(assert);
        }

        [TestMethod]
        public void EqualsOperator_AnyAndNull_ReturnsFalse()
        {
            // Arrange
            Plain p1 = new Plain("a dog");
            // Act
            bool assert = p1 == null;
            // Assert
            Assert.IsFalse(assert);
        }

        [TestMethod]
        public void EqualsOperator_NullAndAny_ReturnsFalse()
        {
            // Arrange
            Plain p1 = new Plain("a dog");
            // Act
            bool assert = null == p1;
            // Assert
            Assert.IsFalse(assert);
        }

        [TestMethod]
        public void EqualsOperator_OneAndOne_ReturnsTrue()
        {
            // Arrange
            Plain p1 = new Plain("a dog");
            Plain p2 = new Plain("a dog");
            // Act
            bool assert = p1 == p2;
            // Assert
            Assert.IsTrue(assert);
        }

        [TestMethod]
        public void EqualsOperator_OneAndOther_ReturnsFalse()
        {
            // Arrange
            Plain p1 = new Plain("a dog");
            Plain p2 = new Plain("a cat");
            // Act
            bool assert = p1 == p2;
            // Assert
            Assert.IsFalse(assert);
        }
    }
}
