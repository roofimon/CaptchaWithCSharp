using System;

namespace CaptchaLibrary
{
    public class Captcha
    {
        private int pattern;
        private int leftOperand;
        private int rightOperand;
        private int operatorType;

        private static readonly string[] arrayOperandToString = { "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE" };

        private const int MaxOperand = 9;
        private const int MinOperand = 1;

        private const int MinusOperator = 3;
        private const int MultiplyOperator = 2;
        private const int PlusOperator = 1;


        public Captcha(int pattern, int leftOperand, int operatorType, int rightOperand)
        {
            this.pattern = pattern;
            this.leftOperand = leftOperand;
            this.operatorType = operatorType;
            this.rightOperand = rightOperand;
        }

        public string GetLeftOperand()
        {
            ValidateMinMaxOperand(leftOperand);
            if (isTextNumberPattern())
            {
                return leftOperand.ToString();
            }

            return arrayOperandToString[leftOperand - 1];
        }

        public string GetOperator()
        {
            string operatorSymbol = string.Empty;
            if (operatorType == PlusOperator)
            {
                operatorSymbol = "+";
            }
            else if (operatorType == MinusOperator)
            {
                operatorSymbol = "-";
            }
            else if (operatorType == MultiplyOperator)
            {
                operatorSymbol = "*";
            }
            else
            {
                throw new InvalidFormatOperatorException();
            }
            return operatorSymbol;
        }

        public string GetRightOperand()
        {
            ValidateMinMaxOperand(rightOperand);
            if (isTextNumberPattern())
            {
                return arrayOperandToString[rightOperand - 1];
            }
            return rightOperand.ToString();
        }

        private bool isTextNumberPattern()
        {
            return pattern == 2;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}", GetLeftOperand(), GetOperator(), GetRightOperand());
        }

        private static void ValidateMinMaxOperand(int operand)
        {
            if (operand > MaxOperand || operand < MinOperand)
            {
                throw new InvalidRangeException();
            }
        }
    }
}
