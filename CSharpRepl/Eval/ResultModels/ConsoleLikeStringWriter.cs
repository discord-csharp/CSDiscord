﻿using System;
using System.IO;
using System.Text;

#pragma warning disable IDE0060 // Remove unused parameter
namespace CSDiscordService.Eval.ResultModels
{
    public class ConsoleLikeStringWriter : StringWriter
    {
        public ConsoleLikeStringWriter(StringBuilder builder) : base(builder) { }

        public void Beep() { }

        public void Beep(int a, int b) { }

        public void Clear() { }

        public void MoveBufferArea(int a, int b, int c, int d, int e) { }

        public void MoveBufferArea(int a, int b, int c, int d, int e, char f, ConsoleColor g, ConsoleColor h) { }

        public Stream OpenStandardError() => new MemoryStream();

        public Stream OpenStandardError(int a) => new MemoryStream(a);

        public Stream OpenStandardInput() => new MemoryStream();

        public Stream OpenStandardInput(int a) => new MemoryStream(a);

        public Stream OpenStandardOutput() => new MemoryStream();

        public Stream OpenStandardOutput(int a) => new MemoryStream(a);

        public int Read() => 0;

        public ConsoleKeyInfo ReadKey() => new ConsoleKeyInfo('a', ConsoleKey.A, false, false, false);

        public ConsoleKeyInfo ReadKey(bool a)
        {
            if (a)
            {
                Write("a");
            }
            return ReadKey();
        }

        public string ReadLine() => $"a{Environment.NewLine}";

        public void ResetColor() { }

        public void SetBufferSize(int a, int b) { }

        public void SetCursorPosition(int a, int b) { }

        public void SetError(TextWriter wr) { }

        public void SetIn(TextWriter wr) { }
        
        public void SetOut(TextWriter wr) { }

        public void SetWindowPosition(int a, int b) { }
        
        public void SetWindowSize(int a, int b) { }
    }
}

#pragma warning restore IDE0060 // Remove unused parameter