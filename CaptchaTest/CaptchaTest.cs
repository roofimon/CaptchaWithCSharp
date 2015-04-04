using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaptchaLibrary;

namespace CaptchaTest {
    [TestClass]
    public class CaptchaTest {
        [TestMethod]
        public void Operator_WhenInputIs2118_ShouldBePlus() {
            Captcha captcha = new Captcha(2, 1, 1, 8);
            String oper = captcha.Operator();
            Assert.AreEqual("+", oper);
        }

        [TestMethod]
        public void Operator_WhenInputIs2128_ShouldBeMultiply() {
            Captcha captcha = new Captcha(2, 1, 2, 8);
            String oper = captcha.Operator();
            Assert.AreEqual("*", oper);
        }

        [TestMethod]
        public void Operator_WhenInputIs2138_ShouldBeMultiply() {
            Captcha captcha = new Captcha(2, 1, 3, 8);
            String oper = captcha.Operator();
            Assert.AreEqual("-", oper);
        }

        [TestMethod]
        public void RightOperand_WhenInputIs2118_ShouldBe8() {
            Captcha captcha = new Captcha(2, 1, 1, 8);
            String operand = captcha.RightOperand();
            Assert.AreEqual("8", operand);
        }

        [TestMethod]
        public void RightOperand_WhenInputIs1118_ShouldBeEight() {
            Captcha captcha = new Captcha(1, 1, 1, 8);
            String operand = captcha.RightOperand();
            Assert.AreEqual("Eight", operand);
        }

        [TestMethod]
        public void RightOperand_WhenInputIs1119_ShouldBeNine() {
            Captcha captcha = new Captcha(1, 1, 1, 9);
            String operand = captcha.RightOperand();
            Assert.AreEqual("Nine", operand);
        }

        [TestMethod]
        public void LeftOperand_WhenInputIs2199_ShouldBeOne() {
            Captcha captcha = new Captcha(2, 1, 9, 9);
            String operand = captcha.LeftOperand();
            Assert.AreEqual("One", operand);
        }

        [TestMethod]
        public void LeftOperand_WhenInputIs2911_ShouldBeOne() {
            Captcha captcha = new Captcha(2, 9, 1, 1);
            String operand = captcha.LeftOperand();
            Assert.AreEqual("Nine", operand);
        }

        [TestMethod]
        public void LeftOperand_WhenInputIs1199_ShouldBe1() {
            Captcha captcha = new Captcha(1, 1, 9, 9);
            String operand = captcha.LeftOperand();
            Assert.AreEqual("1", operand);
        }

        [TestMethod]
        public void LeftOperand_WhenInputIs1299_ShouldBe2() {
            Captcha captcha = new Captcha(1, 2, 9, 9);
            String operand = captcha.LeftOperand();
            Assert.AreEqual("2", operand);
        }

        [TestMethod]
        public void LeftOperand_WhenInputIs1999_ShouldBe9() {
            Captcha captcha = new Captcha(1, 9, 1, 1);
            String operand = captcha.LeftOperand();
            Assert.AreEqual("9", operand);
        }
    }
}
