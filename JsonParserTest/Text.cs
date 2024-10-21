using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonParserTest
{
    public class Text:IText
    {
        string[] lines;
        int lineNumber;
        int linePosition;
        /// <summary>
        /// 位置情報
        /// </summary>
        public PositionInfo PositionInfo
        {
            get
            {
                try
                {
                    return new(lines[lineNumber], lineNumber, linePosition);
                }
                catch (IndexOutOfRangeException e)
                {
                    throw new OutOfRageException();
                }
            }
        }

        public Text(string s)
        {
            const string nullChar = "\0";
            if (!s.EndsWith(nullChar))
            {
                s += nullChar;
            }
            lines = s.Split(
                new string[]
                {
                    Environment.NewLine 
                },
                StringSplitOptions.None).Select((elem) => elem + Environment.NewLine
                ).ToArray();
            lineNumber = 0;
            linePosition = 0;
        }


        /// <summary>
        /// 現在位置の文字を取得する
        /// </summary>
        /// <returns>現在の位置の文字</returns>
        public char Peek()
        {
            try
            {
                return lines[lineNumber][linePosition];
            }
            catch (IndexOutOfRangeException e)
            {
                throw new OutOfRageException();
            }
        }
        /// <summary>
        /// 1文字進める
        /// </summary>
        public void Advance()
        {
            try
            {
                if (linePosition == lines[lineNumber].Length - 1)
                {
                    lineNumber++;
                    linePosition = 0;
                    return;
                }
                linePosition++;
            }
            catch (IndexOutOfRangeException e)
            {
                throw new OutOfRageException();
            }
        }
    }
}
