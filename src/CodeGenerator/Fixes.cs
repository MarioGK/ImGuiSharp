using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeGenerator;

//TODO remove this
public class Fixes
{
	public static string AssemblyDirectory
	{
		get
		{
			var codeBase = Assembly.GetExecutingAssembly().CodeBase;
			var uri      = new UriBuilder(codeBase);
			var path     = Uri.UnescapeDataString(uri.Path);
			return Path.GetDirectoryName(path);
		}
	}
	public void FixShit(string rootPath)
	{
		ProcessFileRemoveLines(Path.Combine(rootPath, "ImGuiStyleMod.gen.cs"), "union");
		ProcessFileReplaceText(Path.Combine(rootPath, "ImGuiViewportP.gen.cs"), "RangeAccessor<ImDrawList*",    "RangeAccessor<ImDrawList");
		ProcessFileRemoveLines(Path.Combine(rootPath, "ImGuiContext.gen.cs"), "ImChunkStream");
		ProcessFileRemoveLines(Path.Combine(rootPath, "ImGuiContext.gen.cs"), "ImGuiItemFlagsPtr");
		ProcessFileRemoveLines(Path.Combine(rootPath, "ImGuiContext.gen.cs"), "NativePtr->Tables");
		ProcessFileRemoveLines(Path.Combine(rootPath, "ImGuiContext.gen.cs"), "NativePtr->TabBars");
		ProcessFileRemoveLines(Path.Combine(rootPath, "ImGui.gen.cs"), "Vector2 FindBestWindowPosForPopupEx", 8);
		ProcessFileReplaceText(Path.Combine(rootPath, "ImGui.gen.cs"), "IntPtr callback = null",             "IntPtr callback = IntPtr.Zero");
		ProcessFileReplaceText(Path.Combine(rootPath, "ImGui.gen.cs"), "ImGuiPopupFlags_None",               "ImGuiPopupFlags.None");
		ProcessFileReplaceText(Path.Combine(rootPath, "ImGui.gen.cs"), "ImGuiNavHighlightFlags_TypeDefault", "ImGuiNavHighlightFlags.TypeDefault");
		ProcessFileReplaceText(Path.Combine(rootPath, "ImGui.gen.cs"), "IntPtr custom_callback = null",      "IntPtr custom_callback = IntPtr.Zero");
		ProcessFileReplaceText(Path.Combine(rootPath, "ImGui.gen.cs"), "ImGuiContext* ctx = IntPtr.Zero;",   "ImGuiContext* ctx = null;");
		ProcessFileRemoveLines(Path.Combine(rootPath, "ImGuiInputEvent.gen.cs"), "union");
	}


	private void ProcessFileRemoveLines(string path, string remove, int nrLinesAfter)
	{
		var content   = File.ReadAllText(path);
		var processed = RemoveLines(content, remove, nrLinesAfter);
		File.WriteAllText(path, processed);
	}

	private void ProcessFileRemoveLines(string path, string remove)
	{
		var content   = File.ReadAllText(path);
		var processed = RemoveLines(content, remove);
		File.WriteAllText(path, processed);
	}

	private void ProcessFileReplaceText(string path, string replaceFrom, string replaceTo)
	{
		var content   = File.ReadAllText(path);
		var processed = content.Replace(replaceFrom, replaceTo);

		File.WriteAllText(path, processed);
	}

	private string RemoveLines(string s, string sRemove)
	{
		var sr = new StringReader(s);

		var    sb = new StringBuilder();
		while (sr.ReadLine() is { } line)
		{
			if (!line.Contains(sRemove))
			{
				sb.AppendLine(line);
			}
		}
		return sb.ToString();

	}


	private string RemoveLines(string s, string sRemove, int nrLinesAfter)
	{

		var dontAtFor = 0;
		var sr        = new StringReader(s);

		var    sb = new StringBuilder();
		string line;
		while ((line = sr.ReadLine()) != null)
		{


			if (line.Contains(sRemove))
			{
				dontAtFor = nrLinesAfter;
			}
			if (dontAtFor > 0)
			{
				dontAtFor--;
			}
			if (dontAtFor == 0)
			{
				sb.AppendLine(line);
			}
		}
		return sb.ToString();

	}



}