using CaptchaLibrary;
using NUnit.Framework;

namespace CaptchaTest
{
    [TestFixture]
    public class FirstPatternLeftOperandShouldBeString
    {
        [Test]
        public void LeftOperandIs1()
        {
            Captcha captcha = new Captcha(1, 1, 1, 1);
            Assert.AreEqual("ONE", captcha.GetLeftOperand());
        }
        [Test]
        public void LeftOperandIs2()
        {
            Captcha captcha = new Captcha(1, 2, 1, 1);
            Assert.AreEqual("TWO", captcha.GetLeftOperand());
        }
        [Test]
        public void LeftOperand_ShouldBeTHREE_WhenInputIs3()
        {
            Captcha captcha = new Captcha(1, 3, 1, 1);
            Assert.AreEqual("THREE", captcha.GetLeftOperand());
        }
        [Test]
        public void LeftOperand_ShouldBeFOUR_WhenInputIs4()
        {
            Captcha captcha = new Captcha(1, 4, 1, 1);
            Assert.AreEqual("FOUR", captcha.GetLeftOperand());
        }
        [Test]
        public void LeftOperand_ShouldBeNINE_WhenInputIs9()
        {
            Captcha captcha = new Captcha(1, 9, 1, 1);
            Assert.AreEqual("NINE", captcha.GetLeftOperand());
        }
    }

    [TestFixture]
    public class FirstPatternRightOperandShouldBeNumber
    {
        [Test]
        public void RightOperand_ShouldBe1_WhenInputIs1()
        {
            Captcha captcha = new Captcha(1, 1, 1, 1);
            Assert.AreEqual("1", captcha.GetRightOperand());
        }

        [Test]
        public void RightOperand_ShouldBe2_WhenInputIs2()
        {
            Captcha captcha = new Captcha(1, 1, 1, 2);
            Assert.AreEqual("2", captcha.GetRightOperand());
        }
    }

    [TestFixture]
    public class SecondPatternLeftOperandShouldBeNumber
    {
        [Test]
        public void LeftOperandIs1()
        {
            Captcha captcha = new Captcha(2, 1, 1, 1);
            Assert.AreEqual("1", captcha.GetLeftOperand());
        }
        [Test]
        public void LeftOperand_ShouldBe2_WhenInputIs2()
        {
            Captcha captcha = new Captcha(2, 2, 1, 1);
            Assert.AreEqual("2", captcha.GetLeftOperand());
        }
    }

    [TestFixture]
    public class SecondPatterRightOperandShouldBeString
    {
        [Test]
        public void RightOperand_ShouldBeONE_WhenInputIs1()
        {
            Captcha captcha = new Captcha(2, 1, 1, 1);
            Assert.AreEqual("ONE", captcha.GetRightOperand());
        }
        [Test]
        public void RightOperand_ShouldBeNINE_WhenInputIs9()
        {
            Captcha captcha = new Captcha(2, 1, 1, 9);
            Assert.AreEqual("NINE", captcha.GetRightOperand());
        }
    }

    [TestFixture]
    public class ShouldThrowExceptionWhenLeftOperandValueIsLessThanOneAndMoreThanNine
    {
        [Test]
        public void LeftOperand_ShouldThrowInvalidRangeException_WhenInputIs0()
        {
            Captcha captcha = new Captcha(2, 0, 1, 1);
            Assert.Throws(typeof(InvalidRangeException),
                delegate { captcha.GetLeftOperand(); });
        }


        [Test]
        public void LeftOperand_ShouldThrowException_WhenInputInvalidMaxLeftOperand()
        {
            Captcha captcha = new Captcha(1, 10, 1, 1);
            Assert.Throws(typeof(InvalidRangeException),
                delegate { captcha.GetLeftOperand(); });
        }

        [Test]
        public void LeftOperand_ShouldThrowException_WhenInputInvalidMinLeftOperand()
        {
            Captcha captcha = new Captcha(1, 0, 1, 1);
            Assert.Throws(typeof(InvalidRangeException),
                delegate { captcha.GetLeftOperand(); });
        }
    }

    [TestFixture]
    public class ShouldThrowExceptionWhenRightOperandValueIsLessThanOneAndMoreThanNine
    {
        [Test]
        public void RightOperand_ShouldThrowException_WhenInputInvalidMinRightOperand()
        {
            Captcha captcha = new Captcha(1, 1, 1, 0);
            Assert.Throws(typeof(InvalidRangeException),
                delegate { captcha.GetRightOperand(); });
        }

        [Test]
        public void RightOperand_ShouldThrowException_WhenInputInvalidMaxRightOperand()
        {
            Captcha captcha = new Captcha(1, 1, 1, 10);
            Assert.Throws(typeof(InvalidRangeException),
                delegate { captcha.GetRightOperand(); });
        }
    }

    [TestFixture]
    public class OperatorShouldBePlusMultiplyAndMinus
    {
        [Test]
        public void Operator_ShouldBePlus_WhenInputIs1()
        {
            Captcha captcha = new Captcha(1, 1, 1, 1);
            Assert.AreEqual("+", captcha.GetOperator());
        }

        [Test]
        public void Operator_ShouldBeMinus_WhenInputIs3()
        {
            Captcha captcha = new Captcha(1, 1, 3, 1);
            Assert.AreEqual("-", captcha.GetOperator());
        }

        [Test]
        public void Operator_ShouldBeMultiply_WhenInputIs2()
        {
            Captcha captcha = new Captcha(1, 1, 2, 1);
            Assert.AreEqual("*", captcha.GetOperator());
        }
    }

    [TestFixture]
    public class ShouldThrowExceptionWhenOperatorValueIsMoreThanThree
    {
        [Test]
        public void Operator_ShouldThrowException_WhenInputInvalidOperator()
        {
            Captcha captcha = new Captcha(1, 1, 4, 1);
            Assert.Throws(typeof(InvalidFormatOperatorException),
                delegate { captcha.GetOperator(); });
        }
    }

    [TestFixture]
    public class CaptchaTest
    {
        [Test]
        public void Pattern_ShouldBeONEPlus1_WhenPatternIs1()
        {
            Captcha captcha = new Captcha(1, 1, 1, 1);
            Assert.AreEqual("ONE+1", captcha.ToString());
        }

        [Test]
        public void Pattern_ShouldBeONEPlus2_WhenPatternIs1()
        {
            Captcha captcha = new Captcha(1, 1, 1, 2);
            Assert.AreEqual("ONE+2", captcha.ToString());
        }
        [Test]
        public void Pattern_ShouldBeTWOPlus1_WhenPatternIs1()
        {
            Captcha captcha = new Captcha(1, 2, 1, 1);
            Assert.AreEqual("TWO+1", captcha.ToString());
        }

        [Test]
        public void Pattern_ShouldBe2PlusOne_WhenPatternIs2()
        {
            Captcha captcha = new Captcha(2, 2, 1, 1);
            Assert.AreEqual("2+ONE", captcha.ToString());
        }
    }
}
