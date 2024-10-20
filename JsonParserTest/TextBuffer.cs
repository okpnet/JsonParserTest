using System;

namespace JsonParserTest
{
    public class TextBuffer
    {
        char[] linefeed =[ '\n','\r' ];
        public string Buffer { get; }

        public int Length => Buffer.Length;

        public int CurrentPosition { get; protected set; }

        public int LinrCount {  get; protected set; }
        public bool IsEmdOfBlock => CurrentPosition == Length;

        public char Peek()
        {
            try
            {
                return Buffer[CurrentPosition];
            }
            catch (Exception)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void Next()
        {
            if (CurrentPosition == Length)
            {
                return;
            }
            CurrentPosition++;
        }
    }
}
