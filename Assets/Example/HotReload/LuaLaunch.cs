using System.Collections;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

public class LuaLaunch : MonoBehaviour
{
    private LuaState lua = null;

    void Start()
    {
        lua = new LuaState();
        lua.Start();
        
        //添加搜索路径
        string fullPath = Application.dataPath + "/Example/HotReload/Lua";
        lua.AddSearchPath(fullPath);

        lua.Require("GameMain");
//        lua.DoString("GameMain.start()");
        
        //创建lua 文件监听器
        LuaFileWatcher.CreateLuaFileWatcher(lua, fullPath);
    }
    
    void OnGUI()
    {
        if (GUI.Button(new Rect(50, 100, 100, 50), "DoTestFunc"))
        {
            lua.DoString("GameMain.testFunc()");
        }
    }
    
    void OnApplicationQuit()
    {
        lua.Dispose();
        lua = null;
    }
}
