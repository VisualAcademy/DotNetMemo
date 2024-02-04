using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetNote
{
    class Library
    {
        /// <summary>
        /// 현재 텍스트박스의 행과 열 값을 반환
        /// </summary>
        /// <param name="objTextBox">텍스트박스</param>
        /// <returns>LineAndColumn 타입</returns>
        public static LineAndColumn GetLineAndColumn(
            System.Windows.Forms.TextBox objTextBox)
        { 
            // 현재 커서의 위치
            int intCursorPosition = objTextBox.SelectionStart;
            // 시작 위치 변수
            int intStartIndex = 0;
            // 반환형 변수
            LineAndColumn returnValue;
            returnValue.Line = 1;
            if (intCursorPosition == 0)
            {
                returnValue.Column = 1;
                return returnValue;
            }
            while (true)
            {
                intStartIndex = 
                    objTextBox.Text.IndexOf('\n', intStartIndex + 1);
                if ((intStartIndex > intCursorPosition) ||
                    intStartIndex == -1)
                {
                    break;
                }
                else
                {
                    returnValue.Line++;
                }
            }
            if (returnValue.Line == 1)
            {
                returnValue.Column = intCursorPosition + 1;
            }
            else
            {
                for (int i = 0; i < returnValue.Line - 1; i++)
                {
                    intCursorPosition -= objTextBox.Lines[i].Length + 2;
                }
                returnValue.Column = intCursorPosition + 1;
            }
            return returnValue;
        }
    }
    
    // 행과 열을 묶어서 관리하는 구조체
    public struct LineAndColumn
    {
        public int Line;    // 행
        public int Column;  // 열
    }
}
