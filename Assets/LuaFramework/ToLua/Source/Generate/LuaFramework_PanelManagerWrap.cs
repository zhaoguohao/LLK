//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaFramework_PanelManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.PanelManager), typeof(Manager));
		L.RegFunction("CreatePanel", CreatePanel);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreatePanel(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaFramework.PanelManager obj = (LuaFramework.PanelManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.PanelManager));
			string arg0 = ToLua.CheckString(L, 2);
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			obj.CreatePanel(arg0, arg1);
			return 0;
		}
		catch(Exception e)
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
}

