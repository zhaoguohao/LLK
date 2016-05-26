﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaFramework_AppConstWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.AppConst), typeof(System.Object));
		L.RegFunction("New", _CreateLuaFramework_AppConst);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegConstant("DebugMode", 0);
		L.RegConstant("ExampleMode", 1);
		L.RegConstant("UpdateMode", 0);
		L.RegConstant("LuaByteMode", 0);
		L.RegConstant("LuaBundleMode", 0);
		L.RegConstant("TimerInterval", 1);
		L.RegConstant("GameFrameRate", 30);
		L.RegVar("AppName", get_AppName, null);
		L.RegVar("LuaTempDir", get_LuaTempDir, null);
		L.RegVar("ExtName", get_ExtName, null);
		L.RegVar("AppPrefix", get_AppPrefix, null);
		L.RegVar("WebUrl", get_WebUrl, null);
		L.RegVar("UserId", get_UserId, set_UserId);
		L.RegVar("SocketPort", get_SocketPort, set_SocketPort);
		L.RegVar("SocketAddress", get_SocketAddress, set_SocketAddress);
		L.RegVar("FrameworkRoot", get_FrameworkRoot, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaFramework_AppConst(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				LuaFramework.AppConst obj = new LuaFramework.AppConst();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: LuaFramework.AppConst.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AppName(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, LuaFramework.AppConst.AppName);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LuaTempDir(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, LuaFramework.AppConst.LuaTempDir);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ExtName(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, LuaFramework.AppConst.ExtName);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AppPrefix(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, LuaFramework.AppConst.AppPrefix);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_WebUrl(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, LuaFramework.AppConst.WebUrl);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UserId(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, LuaFramework.AppConst.UserId);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SocketPort(IntPtr L)
	{
		LuaDLL.lua_pushinteger(L, LuaFramework.AppConst.SocketPort);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SocketAddress(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, LuaFramework.AppConst.SocketAddress);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FrameworkRoot(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, LuaFramework.AppConst.FrameworkRoot);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UserId(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			LuaFramework.AppConst.UserId = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_SocketPort(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			LuaFramework.AppConst.SocketPort = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_SocketAddress(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			LuaFramework.AppConst.SocketAddress = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

