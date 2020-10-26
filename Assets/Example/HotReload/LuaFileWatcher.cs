using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using LuaInterface;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class LuaFileWatcher
{
    private static LuaFunction reloadFunc;
    
    private static readonly HashSet<string> changedFiles = new HashSet<string>();

    public static void CreateLuaFileWatcher(LuaState luaState, string scriptPath)
    {
        var directoryWatcher = new DirectoryWatcher(scriptPath, new FileSystemEventHandler(LuaFileOnChanged));
        reloadFunc = luaState.GetFunction("HotReload");
        EditorApplication.update -= Reload;
        EditorApplication.update += Reload;
    }

    private static void LuaFileOnChanged(object obj, FileSystemEventArgs args)
    {
        var fullPath = args.FullPath;
        var luaFolderName = "Lua";
        var requirePath = fullPath.Replace(".lua", "");
        var startIdx = requirePath.IndexOf("Lua") + luaFolderName.Length + 1;
        requirePath = requirePath.Substring(startIdx);
        changedFiles.Add(requirePath);
    }

    private static void Reload()
    {
        if (EditorApplication.isPlaying == false)
        {
            return;
        }
        if (changedFiles.Count == 0)
        {
            return;
        }

        foreach (var file in changedFiles)
        {
            reloadFunc.Call(file);
            Debug.Log("Reload:" + file);
        }
        changedFiles.Clear();
    }
}