﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_AssetBundleWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.AssetBundle), typeof(UnityEngine.Object));
		L.RegFunction("UnloadAllAssetBundles", UnloadAllAssetBundles);
		L.RegFunction("GetAllLoadedAssetBundles", GetAllLoadedAssetBundles);
		L.RegFunction("LoadFromFileAsync", LoadFromFileAsync);
		L.RegFunction("LoadFromFile", LoadFromFile);
		L.RegFunction("LoadFromMemoryAsync", LoadFromMemoryAsync);
		L.RegFunction("LoadFromMemory", LoadFromMemory);
		L.RegFunction("LoadFromStreamAsync", LoadFromStreamAsync);
		L.RegFunction("LoadFromStream", LoadFromStream);
		L.RegFunction("SetAssetBundleDecryptKey", SetAssetBundleDecryptKey);
		L.RegFunction("Contains", Contains);
		L.RegFunction("LoadAsset", LoadAsset);
		L.RegFunction("LoadAssetAsync", LoadAssetAsync);
		L.RegFunction("LoadAssetWithSubAssets", LoadAssetWithSubAssets);
		L.RegFunction("LoadAssetWithSubAssetsAsync", LoadAssetWithSubAssetsAsync);
		L.RegFunction("LoadAllAssets", LoadAllAssets);
		L.RegFunction("LoadAllAssetsAsync", LoadAllAssetsAsync);
		L.RegFunction("Unload", Unload);
		L.RegFunction("GetAllAssetNames", GetAllAssetNames);
		L.RegFunction("GetAllScenePaths", GetAllScenePaths);
		L.RegFunction("RecompressAssetBundleAsync", RecompressAssetBundleAsync);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("isStreamedSceneAssetBundle", get_isStreamedSceneAssetBundle, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnloadAllAssetBundles(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
			UnityEngine.AssetBundle.UnloadAllAssetBundles(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAllLoadedAssetBundles(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			System.Collections.Generic.IEnumerable<UnityEngine.AssetBundle> o = UnityEngine.AssetBundle.GetAllLoadedAssetBundles();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadFromFileAsync(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				UnityEngine.AssetBundleCreateRequest o = UnityEngine.AssetBundle.LoadFromFileAsync(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2)
			{
				string arg0 = ToLua.CheckString(L, 1);
				uint arg1 = (uint)LuaDLL.luaL_checknumber(L, 2);
				UnityEngine.AssetBundleCreateRequest o = UnityEngine.AssetBundle.LoadFromFileAsync(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3)
			{
				string arg0 = ToLua.CheckString(L, 1);
				uint arg1 = (uint)LuaDLL.luaL_checknumber(L, 2);
				ulong arg2 = LuaDLL.tolua_checkuint64(L, 3);
				UnityEngine.AssetBundleCreateRequest o = UnityEngine.AssetBundle.LoadFromFileAsync(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.AssetBundle.LoadFromFileAsync");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadFromFile(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				UnityEngine.AssetBundle o = UnityEngine.AssetBundle.LoadFromFile(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2)
			{
				string arg0 = ToLua.CheckString(L, 1);
				uint arg1 = (uint)LuaDLL.luaL_checknumber(L, 2);
				UnityEngine.AssetBundle o = UnityEngine.AssetBundle.LoadFromFile(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				string arg0 = ToLua.CheckString(L, 1);
				uint arg1 = (uint)LuaDLL.luaL_checknumber(L, 2);
				ulong arg2 = LuaDLL.tolua_checkuint64(L, 3);
				UnityEngine.AssetBundle o = UnityEngine.AssetBundle.LoadFromFile(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.AssetBundle.LoadFromFile");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadFromMemoryAsync(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				byte[] arg0 = ToLua.CheckByteBuffer(L, 1);
				UnityEngine.AssetBundleCreateRequest o = UnityEngine.AssetBundle.LoadFromMemoryAsync(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2)
			{
				byte[] arg0 = ToLua.CheckByteBuffer(L, 1);
				uint arg1 = (uint)LuaDLL.luaL_checknumber(L, 2);
				UnityEngine.AssetBundleCreateRequest o = UnityEngine.AssetBundle.LoadFromMemoryAsync(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.AssetBundle.LoadFromMemoryAsync");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadFromMemory(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				byte[] arg0 = ToLua.CheckByteBuffer(L, 1);
				UnityEngine.AssetBundle o = UnityEngine.AssetBundle.LoadFromMemory(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2)
			{
				byte[] arg0 = ToLua.CheckByteBuffer(L, 1);
				uint arg1 = (uint)LuaDLL.luaL_checknumber(L, 2);
				UnityEngine.AssetBundle o = UnityEngine.AssetBundle.LoadFromMemory(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.AssetBundle.LoadFromMemory");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadFromStreamAsync(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				System.IO.Stream arg0 = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
				UnityEngine.AssetBundleCreateRequest o = UnityEngine.AssetBundle.LoadFromStreamAsync(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2)
			{
				System.IO.Stream arg0 = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
				uint arg1 = (uint)LuaDLL.luaL_checknumber(L, 2);
				UnityEngine.AssetBundleCreateRequest o = UnityEngine.AssetBundle.LoadFromStreamAsync(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3)
			{
				System.IO.Stream arg0 = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
				uint arg1 = (uint)LuaDLL.luaL_checknumber(L, 2);
				uint arg2 = (uint)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.AssetBundleCreateRequest o = UnityEngine.AssetBundle.LoadFromStreamAsync(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.AssetBundle.LoadFromStreamAsync");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadFromStream(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				System.IO.Stream arg0 = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
				UnityEngine.AssetBundle o = UnityEngine.AssetBundle.LoadFromStream(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2)
			{
				System.IO.Stream arg0 = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
				uint arg1 = (uint)LuaDLL.luaL_checknumber(L, 2);
				UnityEngine.AssetBundle o = UnityEngine.AssetBundle.LoadFromStream(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				System.IO.Stream arg0 = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
				uint arg1 = (uint)LuaDLL.luaL_checknumber(L, 2);
				uint arg2 = (uint)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.AssetBundle o = UnityEngine.AssetBundle.LoadFromStream(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.AssetBundle.LoadFromStream");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAssetBundleDecryptKey(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			UnityEngine.AssetBundle.SetAssetBundleDecryptKey(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Contains(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.AssetBundle obj = (UnityEngine.AssetBundle)ToLua.CheckObject<UnityEngine.AssetBundle>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.Contains(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAsset(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.AssetBundle obj = (UnityEngine.AssetBundle)ToLua.CheckObject<UnityEngine.AssetBundle>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				UnityEngine.Object o = obj.LoadAsset(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				UnityEngine.AssetBundle obj = (UnityEngine.AssetBundle)ToLua.CheckObject<UnityEngine.AssetBundle>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				System.Type arg1 = ToLua.CheckMonoType(L, 3);
				UnityEngine.Object o = obj.LoadAsset(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.AssetBundle.LoadAsset");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAssetAsync(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.AssetBundle obj = (UnityEngine.AssetBundle)ToLua.CheckObject<UnityEngine.AssetBundle>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				UnityEngine.AssetBundleRequest o = obj.LoadAssetAsync(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3)
			{
				UnityEngine.AssetBundle obj = (UnityEngine.AssetBundle)ToLua.CheckObject<UnityEngine.AssetBundle>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				System.Type arg1 = ToLua.CheckMonoType(L, 3);
				UnityEngine.AssetBundleRequest o = obj.LoadAssetAsync(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.AssetBundle.LoadAssetAsync");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAssetWithSubAssets(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.AssetBundle obj = (UnityEngine.AssetBundle)ToLua.CheckObject<UnityEngine.AssetBundle>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				UnityEngine.Object[] o = obj.LoadAssetWithSubAssets(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				UnityEngine.AssetBundle obj = (UnityEngine.AssetBundle)ToLua.CheckObject<UnityEngine.AssetBundle>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				System.Type arg1 = ToLua.CheckMonoType(L, 3);
				UnityEngine.Object[] o = obj.LoadAssetWithSubAssets(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.AssetBundle.LoadAssetWithSubAssets");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAssetWithSubAssetsAsync(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.AssetBundle obj = (UnityEngine.AssetBundle)ToLua.CheckObject<UnityEngine.AssetBundle>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				UnityEngine.AssetBundleRequest o = obj.LoadAssetWithSubAssetsAsync(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3)
			{
				UnityEngine.AssetBundle obj = (UnityEngine.AssetBundle)ToLua.CheckObject<UnityEngine.AssetBundle>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				System.Type arg1 = ToLua.CheckMonoType(L, 3);
				UnityEngine.AssetBundleRequest o = obj.LoadAssetWithSubAssetsAsync(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.AssetBundle.LoadAssetWithSubAssetsAsync");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAllAssets(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.AssetBundle obj = (UnityEngine.AssetBundle)ToLua.CheckObject<UnityEngine.AssetBundle>(L, 1);
				UnityEngine.Object[] o = obj.LoadAllAssets();
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2)
			{
				UnityEngine.AssetBundle obj = (UnityEngine.AssetBundle)ToLua.CheckObject<UnityEngine.AssetBundle>(L, 1);
				System.Type arg0 = ToLua.CheckMonoType(L, 2);
				UnityEngine.Object[] o = obj.LoadAllAssets(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.AssetBundle.LoadAllAssets");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAllAssetsAsync(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.AssetBundle obj = (UnityEngine.AssetBundle)ToLua.CheckObject<UnityEngine.AssetBundle>(L, 1);
				UnityEngine.AssetBundleRequest o = obj.LoadAllAssetsAsync();
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2)
			{
				UnityEngine.AssetBundle obj = (UnityEngine.AssetBundle)ToLua.CheckObject<UnityEngine.AssetBundle>(L, 1);
				System.Type arg0 = ToLua.CheckMonoType(L, 2);
				UnityEngine.AssetBundleRequest o = obj.LoadAllAssetsAsync(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.AssetBundle.LoadAllAssetsAsync");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Unload(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.AssetBundle obj = (UnityEngine.AssetBundle)ToLua.CheckObject<UnityEngine.AssetBundle>(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.Unload(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAllAssetNames(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.AssetBundle obj = (UnityEngine.AssetBundle)ToLua.CheckObject<UnityEngine.AssetBundle>(L, 1);
			string[] o = obj.GetAllAssetNames();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAllScenePaths(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.AssetBundle obj = (UnityEngine.AssetBundle)ToLua.CheckObject<UnityEngine.AssetBundle>(L, 1);
			string[] o = obj.GetAllScenePaths();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RecompressAssetBundleAsync(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				string arg0 = ToLua.CheckString(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				UnityEngine.BuildCompression arg2 = StackTraits<UnityEngine.BuildCompression>.Check(L, 3);
				UnityEngine.AssetBundleRecompressOperation o = UnityEngine.AssetBundle.RecompressAssetBundleAsync(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 4)
			{
				string arg0 = ToLua.CheckString(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				UnityEngine.BuildCompression arg2 = StackTraits<UnityEngine.BuildCompression>.Check(L, 3);
				uint arg3 = (uint)LuaDLL.luaL_checknumber(L, 4);
				UnityEngine.AssetBundleRecompressOperation o = UnityEngine.AssetBundle.RecompressAssetBundleAsync(arg0, arg1, arg2, arg3);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 5)
			{
				string arg0 = ToLua.CheckString(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				UnityEngine.BuildCompression arg2 = StackTraits<UnityEngine.BuildCompression>.Check(L, 3);
				uint arg3 = (uint)LuaDLL.luaL_checknumber(L, 4);
				UnityEngine.ThreadPriority arg4 = (UnityEngine.ThreadPriority)ToLua.CheckObject(L, 5, typeof(UnityEngine.ThreadPriority));
				UnityEngine.AssetBundleRecompressOperation o = UnityEngine.AssetBundle.RecompressAssetBundleAsync(arg0, arg1, arg2, arg3, arg4);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.AssetBundle.RecompressAssetBundleAsync");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isStreamedSceneAssetBundle(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.AssetBundle obj = (UnityEngine.AssetBundle)o;
			bool ret = obj.isStreamedSceneAssetBundle;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isStreamedSceneAssetBundle on a nil value");
		}
	}
}

