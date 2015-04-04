using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptchaLibrary {
    public class Captcha {
        private int pattern;
        private int leftOperand;
        private int rightOperand;
        private int oper;
        Dictionary<int, string> numberStringMapping = new Dictionary<int, string> 
        {
                {1, "One"}, 
                {2, "Two"},
                {3, "Three"},
                {4, "Four"},
                {5, "Five"},
                {6, "Six"},
                {7, "Seven"},
                {8, "Eight"},
                {9, "Nine"},
       };
       

        public Captcha(int pattern, int leftOperand, int oper, int rightOperand) {
            this.pattern = pattern;
            this.leftOperand = leftOperand;
            this.oper = oper;
            this.rightOperand = rightOperand;
        }

        public string LeftOperand() {
            if (isNumberStringPattern()) {
                return this.leftOperand.ToString();
            }
            return numberStringMapping[this.leftOperand];
        }

        private bool isNumberStringPattern() {
            return this.pattern == 1;
        }

        public string RightOperand() {
            if (isNumberStringPattern()) {
                return numberStringMapping[this.rightOperand];
            }
            return this.rightOperand.ToString();
        }

        public string Operator() {
            Dictionary<int, string> oper = new Dictionary<int, string> {
                {1, "+"},
                {2, "*"},
                {3, "-"},
            };
            return oper[this.oper];
        }
    }
}
