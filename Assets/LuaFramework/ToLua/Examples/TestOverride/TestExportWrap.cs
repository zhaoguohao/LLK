//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class TestExportWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(TestExport), typeof(System.Object));
		L.RegFunction("get_Item", get_Item);
		L.RegFunction("set_Item", set_Item);
		L.RegFunction("TestByteBuffer", TestByteBuffer);
		L.RegFunction("Test", Test);
		L.RegFunction("New", _CreateTestExport);
		L.RegVar("this", _this, null);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("buffer", get_buffer, set_buffer);
		L.RegFunction("TestBuffer", TestExport_TestBuffer);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateTestExport(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				TestExport obj = new TestExport();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: TestExport.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _get_this(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TestExport obj = (TestExport)ToLua.CheckObject(L, 1, typeof(TestExport));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int o = obj[arg0];
			LuaDLL.lua_pushinteger(L, o);
			return 1;

		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _set_this(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			TestExport obj = (TestExport)ToLua.CheckObject(L, 1, typeof(TestExport));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj[arg0] = arg1;
			return 0;

		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _this(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushvalue(L, 1);
			LuaDLL.tolua_bindthis(L, _get_this, _set_this);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Item(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(double)))
			{
				double arg0 = (double)LuaDLL.lua_tonumber(L, 1);
				int o = TestExport.get_Item(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				int o = TestExport.get_Item(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(TestExport), typeof(int)))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int o = obj[arg0];
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TestExport.get_Item");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Item(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(double)))
			{
				double arg0 = (double)LuaDLL.lua_tonumber(L, 1);
				int o = TestExport.set_Item(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(TestExport), typeof(int), typeof(int)))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				obj[arg0] = arg1;
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TestExport.set_Item");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestByteBuffer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TestExport obj = (TestExport)ToLua.CheckObject(L, 1, typeof(TestExport));
			TestExport.TestBuffer arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (TestExport.TestBuffer)ToLua.CheckObject(L, 2, typeof(TestExport.TestBuffer));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(TestExport.TestBuffer), func) as TestExport.TestBuffer;
			}

			obj.TestByteBuffer(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Test(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(TestExport), typeof(string)))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(string), typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				int o = TestExport.Test(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(TestExport), typeof(TestExport.Space)))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				TestExport.Space arg0 = (TestExport.Space)ToLua.ToObject(L, 2);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(TestExport), typeof(double)))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				double arg0 = (double)LuaDLL.lua_tonumber(L, 2);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(TestExport), typeof(object)))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(TestExport), typeof(int), typeof(int)))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int o = obj.Test(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(TestExport), typeof(object), typeof(string)))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				string arg1 = ToLua.ToString(L, 3);
				int o = obj.Test(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (TypeChecker.CheckParamsType(L, typeof(object), 2, count - 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				object[] arg0 = ToLua.ToParamsObject(L, 2, count - 1);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TestExport.Test");
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
	static int get_buffer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			byte[] ret = obj.buffer;
			ToLua.Push(L, new LuaByteBuffer(ret));
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index buffer on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_buffer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
			obj.buffer = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index buffer on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestExport_TestBuffer(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(TestExport.TestBuffer), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

