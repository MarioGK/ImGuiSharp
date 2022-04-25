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
	private string[] _files = {
		@"ImGuiStyleMod.gen.cs",
		@"ImGuiDockNode.gen.cs",
		@"ImGuiViewportP.gen.cs",
		@"ImGuiContext.gen.cs",
		@"ImGui.gen.cs",
		@"ImGuiDockNodeFlags.gen.cs"
	};

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
			
			
		_files = _files.Select(x => Path.Combine(rootPath, x)).ToArray();

		ProcessFileRemoveLines(_files[0], "union");
		ProcessFileReplaceText(_files[1], "RangeAccessor<ImGuiDockNode*", "RangeAccessor<ImGuiDockNode");
		ProcessFileReplaceText(_files[2], "RangeAccessor<ImDrawList*",    "RangeAccessor<ImDrawList");
		ProcessFileRemoveLines(_files[3], "ImChunkStream");
		ProcessFileRemoveLines(_files[3], "ImGuiItemFlagsPtr");
		ProcessFileRemoveLines(_files[3], "NativePtr->Tables");
		ProcessFileRemoveLines(_files[3], "NativePtr->TabBars");
		ProcessFileRemoveLines(_files[4], "Vector2 FindBestWindowPosForPopupEx", 8);
		ProcessFileReplaceText(_files[4], "IntPtr callback = null",             "IntPtr callback = IntPtr.Zero");
		ProcessFileReplaceText(_files[4], "ImGuiPopupFlags_None",               "ImGuiPopupFlags.None");
		ProcessFileReplaceText(_files[4], "ImGuiNavHighlightFlags_TypeDefault", "ImGuiNavHighlightFlags.TypeDefault");
		ProcessFileReplaceText(_files[4], "IntPtr custom_callback = null",      "IntPtr custom_callback = IntPtr.Zero");
		ProcessFileReplaceText(_files[4], "ImGuiContext* ctx = IntPtr.Zero;",   "ImGuiContext* ctx = null;");
		ProcessFileReplaceText(_files[5], "AutoHideTabBar = 1 << 6,", @" AutoHideTabBar = 1 << 6,
		DockSpace = 1 << 10,
		CentralNode = 1 << 11,
		NoTabBar = 1 << 12,
		HiddenTabBar = 1 << 13,
		NoWindowMenuButton = 1 << 14,
		NoCloseButton = 1 << 15,
		NoDocking = 1 << 16,
		NoDockingSplitMe = 1 << 17,
		NoDockingSplitOther = 1 << 18,
		NoDockingOverMe = 1 << 19,
		NoDockingOverOther = 1 << 20,
		NoResizeX = 1 << 21,
		NoResizeY = 1 << 22");

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
		string line;
		while ((line = sr.ReadLine()) != null)
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