﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_ScreenWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("Screen");
		L.RegFunction("SetResolution", SetResolution);
		L.RegVar("resolutions", get_resolutions, null);
		L.RegVar("GetResolution", get_GetResolution, null);
		L.RegVar("currentResolution", get_currentResolution, null);
		L.RegVar("showCursor", get_showCursor, set_showCursor);
		L.RegVar("lockCursor", get_lockCursor, set_lockCursor);
		L.RegVar("width", get_width, null);
		L.RegVar("height", get_height, null);
		L.RegVar("dpi", get_dpi, null);
		L.RegVar("fullScreen", get_fullScreen, set_fullScreen);
		L.RegVar("autorotateToPortrait", get_autorotateToPortrait, set_autorotateToPortrait);
		L.RegVar("autorotateToPortraitUpsideDown", get_autorotateToPortraitUpsideDown, set_autorotateToPortraitUpsideDown);
		L.RegVar("autorotateToLandscapeLeft", get_autorotateToLandscapeLeft, set_autorotateToLandscapeLeft);
		L.RegVar("autorotateToLandscapeRight", get_autorotateToLandscapeRight, set_autorotateToLandscapeRight);
		L.RegVar("orientation", get_orientation, set_orientation);
		L.RegVar("sleepTimeout", get_sleepTimeout, set_sleepTimeout);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetResolution(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(int), typeof(int), typeof(bool)))
			{
				int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				UnityEngine.Screen.SetResolution(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(int), typeof(int), typeof(bool), typeof(int)))
			{
				int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				int arg3 = (int)LuaDLL.lua_tonumber(L, 4);
				UnityEngine.Screen.SetResolution(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Screen.SetResolution");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_resolutions(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Screen.resolutions);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_GetResolution(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Screen.GetResolution);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_currentResolution(IntPtr L)
	{
		ToLua.PushValue(L, UnityEngine.Screen.currentResolution);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_showCursor(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, UnityEngine.Screen.showCursor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lockCursor(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, UnityEngine.Screen.lockCursor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_width(IntPtr L)
	{
		LuaDLL.lua_pushinteger(L, UnityEngine.Screen.width);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_height(IntPtr L)
	{
		LuaDLL.lua_pushinteger(L, UnityEngine.Screen.height);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dpi(IntPtr L)
	{
		LuaDLL.lua_pushnumber(L, UnityEngine.Screen.dpi);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fullScreen(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, UnityEngine.Screen.fullScreen);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autorotateToPortrait(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, UnityEngine.Screen.autorotateToPortrait);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autorotateToPortraitUpsideDown(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, UnityEngine.Screen.autorotateToPortraitUpsideDown);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autorotateToLandscapeLeft(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, UnityEngine.Screen.autorotateToLandscapeLeft);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autorotateToLandscapeRight(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, UnityEngine.Screen.autorotateToLandscapeRight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_orientation(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Screen.orientation);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sleepTimeout(IntPtr L)
	{
		LuaDLL.lua_pushinteger(L, UnityEngine.Screen.sleepTimeout);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_showCursor(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Screen.showCursor = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lockCursor(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Screen.lockCursor = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fullScreen(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Screen.fullScreen = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autorotateToPortrait(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Screen.autorotateToPortrait = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autorotateToPortraitUpsideDown(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Screen.autorotateToPortraitUpsideDown = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autorotateToLandscapeLeft(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Screen.autorotateToLandscapeLeft = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autorotateToLandscapeRight(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Screen.autorotateToLandscapeRight = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_orientation(IntPtr L)
	{
		try
		{
			UnityEngine.ScreenOrientation arg0 = (UnityEngine.ScreenOrientation)ToLua.CheckObject(L, 2, typeof(UnityEngine.ScreenOrientation));
			UnityEngine.Screen.orientation = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sleepTimeout(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Screen.sleepTimeout = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

