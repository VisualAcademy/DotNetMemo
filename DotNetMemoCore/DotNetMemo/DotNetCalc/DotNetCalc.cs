using System;
using System.Windows.Forms;

namespace DotNetCalc
{
    public partial class DotNetCalc : Form
    {
        private string buffer; 

        public DotNetCalc()
        {
            InitializeComponent();
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            #region 각각의 버튼 클릭시 해당 문자열을 buffer에 담기
            if (btn == btnOne)
            {
                buffer += "1"; 
            }
            else if (btn == btnTwo)
            {
                buffer += "2";
            }
            else if (btn == btnThree)
            {
                buffer += "3";
            }
            else if (btn == btnFour)
            {
                buffer += "4";
            }
            else if (btn == btnFive)
            {
                buffer += "5";
            }
            else if (btn == btnSix)
            {
                buffer += "6";
            }
            else if (btn == btnSeven)
            {
                buffer += "7";
            }
            else if (btn == btnEight)
            {
                buffer += "8";
            }
            else if (btn == btnNine)
            {
                buffer += "9";
            }
            else if (btn == btnZero)
            {
                buffer += "0";
            }
            else if (btn == btnLeft)
            {
                buffer += "(";
            }
            else if (btn == btnRight)
            {
                buffer += ")";
            }
            else if (btn == btnPlus)
            {
                buffer += " + ";
            }
            else if (btn == btnMinus)
            {
                buffer += " - ";
            }
            else if (btn == btnMultiply)
            {
                buffer += " * ";
            }
            else if (btn == btnDivide)
            {
                buffer += " / ";
            }
            else if (btn == btnPoint)
            {
                buffer += ".";
            }
            #endregion
            txtExpression.Text = buffer; 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            buffer = String.Empty;
            txtExpression.Text = ""; 
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (buffer.Length > 0)
            {
                // 마지막 한자리 삭제
                buffer = buffer.Substring(0, buffer.Length - 1);
                txtExpression.Text = buffer;  
            }
        }

        // 문자열로 지정된 수식을 실제 수식으로 변환 후 계산
        private void btnEnter_Click(object sender, EventArgs e)
        {
            // 문자열 수식에서 공백 제거
            string temp = txtExpression.Text.Replace(" ", "");
            if (String.IsNullOrEmpty(temp))
            {
                MessageBox.Show("수식을 입력하시오.");
                return;
            }
            this.txtExpression.Text += 
                " = \r\n\r\n" + MakeExpression(ref temp).ToString();
            buffer = ""; // 버퍼 초기화 
        }

        /// <summary>
        /// [4] 문자열로 지정된 계산식을 실제 계산식으로 변경
        /// </summary>
        /// <param name="str">3 * (2 + 3)</param>
        /// <returns>15</returns>
        public double MakeExpression(ref string str) {
            int index = 0; // 문자 위치
            // 구문 결과값 가져오기
            double value = Sentence(ref str, ref index); 
            while (index < str.Length) {
                switch (str[index]) {
                    case '+':
                        ++(index);
                        value += Sentence(ref str, ref index);
                        break;
                    case '-':
                        ++(index);
                        value -= Sentence(ref str, ref index);
                        break;
                    default: // 엉뚱한 값이 들어오는 경우                        
                        MessageBox.Show("잘못된 구문입니다.");
                        break;
                }
            }
            return value;
        }

        /// <summary>
        /// [3] 하나의 완성된 수식을 계산하는 메서드
        ///     (3 * 5) = 15
        /// </summary>
        /// <param name="str">(3 * 5)</param>
        /// <param name="index">0</param>
        /// <returns>15</returns>
        public double Sentence(ref string str, ref int index) {
            double value = GetNumber(ref str, ref index); // 첫번째 숫자  
            while (index < str.Length) {
                if (str[index] == '*') {
                    ++(index);
                    value *= GetNumber(ref str, ref index);
                }
                else if (str[index] == '/') {
                    ++(index);
                    value /= GetNumber(ref str, ref index);
                }
                else
                    break;
            } 
            return value;
        }

        /// <summary>
        /// [2] 문자열에서 첫번째 나오는 숫자형을 
        ///     실제 숫자형으로 변환시켜주는 함수
        /// </summary>
        /// <param name="str">(12.34+3)</param>
        /// <param name="index">1</param>
        /// <returns>12.34(숫자형)</returns>
        public double GetNumber(ref string str, ref int index) {
            double value = 0.0;
            // GetSubstring함수 호출해서 괄호안에 있는 문자열만 가져오기               
            if (str[index] == '(') {
                ++(index);
                string substr = GetSubstring(ref str, ref index);
                return MakeExpression(ref substr); // 괄호안의수식만 먼저 계산
            }
            while ((index < str.Length) && Char.IsDigit(str, index)) {
                value = 10.0 * value + Char.GetNumericValue(str[(index)]);
                ++(index);
            }
            if ((index == str.Length) || str[index] != '.') return value;
            double factor = 1.0;
            ++(index);
            while ((index < str.Length) && Char.IsDigit(str, index)) {
                factor *= 0.1;
                value = value + Char.GetNumericValue(str[index]) * factor;
                ++(index);
            }
            return value;
        }

        //[1] 괄호안에 있는 하위 문자열 추출 : (123+5) => 123+5만 추출
        public string GetSubstring(ref string str, ref int index) {
            string substr = ""; // 하위 문자열 저장                      
            int numL = 0; // 왼쪽 괄호의 개수
            int bufindex = index; // 인덱스의 시작 값 
            while (index < str.Length) {
                switch (str[index]) {
                    case ')':
                        if (numL == 0) {
                            char[] substrChars = new char[index - bufindex];
                            str.CopyTo(bufindex, substrChars, 0, substrChars.Length);
                            substr = new String(substrChars);
                            ++(index);
                            return substr;
                        }
                        else
                            numL--; // 왼쪽 괄호와 일치하는 오른쪽 괄호가 나타날 시 감소                      
                        break;
                    case '(':
                        numL++;
                        break;
                }
                ++(index);
            }
            MessageBox.Show("잘못된 구문입니다.");
            return substr;
        }
    }
}
