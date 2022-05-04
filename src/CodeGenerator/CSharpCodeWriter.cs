﻿using System;
using System.IO;

namespace CodeGenerator;

internal class CSharpCodeWriter : IDisposable
{
    private readonly StreamWriter _sw;
    private int _indentLevel;

    public CSharpCodeWriter(string outputPath)
    {
        Console.WriteLine("Writing " + outputPath);
        _sw = File.CreateText(outputPath);
    }

    public void Dispose()
    {
        _sw.Dispose();
    }

    public void Using(string ns)
    {
        WriteIndented($"using {ns};");
    }

    public void PushBlock(string blockHeader)
    {
        WriteIndented(blockHeader);
        WriteIndented("{");
        _indentLevel += 4;
    }

    public void PopBlock()
    {
        _indentLevel -= 4;
        WriteIndented("}");
    }

    public void WriteLine(string text)
    {
        WriteIndented(text);
    }

    private void WriteIndented(string text)
    {
        for (var i = 0; i < _indentLevel; i++) _sw.Write(' ');
        _sw.WriteLine(text);
    }
}