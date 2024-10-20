using System;
using System.Collections.Generic;
using System.Text;

namespace JsonParserTest
{
    public class TextVisitor
    {
        protected TextBuffer _buffer;

        public string Visit { get; protected set; } = string.Empty;

        public char Current { get; protected set; }
        public TextVisitor(TextBuffer buffer)
        {
            _buffer = buffer;
        }

        public void ClearVisit()=>Visit = string.Empty;

        public bool Check(Func<char, bool> predicate)=>predicate(Current);

        public void Add(string addBuffer) => Visit += addBuffer;


    }
}
