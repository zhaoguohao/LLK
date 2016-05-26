using UnityEngine;
using LuaInterface;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Reflection;

namespace LuaFramework {
    public class LuaBehaviour : Base {
        private string data = null;
        private AssetBundle bundle = null;
        private Dictionary<string, LuaFunction> buttons = new Dictionary<string, LuaFunction>();
//zhaqijie add
#region add lua object
[SerializeField]
public List<String> _luaNames;
[SerializeField]
private Dictionary<string, LuaTable> _dic;
public void addLua(LuaTable lt, string ltName)
{
    print("tostring is " + ltName);
    Debug.Log("lt.name is "+lt.GetStringField("x"));
    print("lt 's hashcode is" + lt.GetHashCode());
    print("name is is i si sis is is nnn名字是名字名字名字名字" + name);
    /*打印所有的属性出来*/
    PropertyInfo[] infos = lt.GetType().GetProperties();
    foreach(PropertyInfo info in infos)
    {
        print("info.name: " + ltName);
       // print("key " + info.Name + ",value " + info.GetValue(lt,null));
    }
    
    if(_dic == null)
    {
        _dic = new Dictionary<string,LuaTable>();
        _luaNames = new List<string>();
    }
    if(_dic.ContainsKey(ltName) == false)
    {
        _dic.Add(ltName,lt);
        _luaNames.Add(ltName);
    }
}

public void callLua(string fn, params object[] obj)
{
    print("on enter call lua: " + fn);
    foreach(LuaTable lt in _dic.Values)
    {
        LuaFunction lf = lt.RawGetLuaFunction(fn);
        if(lf != null)
        {
            lf.Call(obj);
        }
    }
}

public LuaTable getLua(string ln)
{
    if(_dic != null && _dic.ContainsKey(ln))
    {
        return _dic[ln];
    }
    return null;
}

#endregion

        protected void Awake() {
            //Util.CallMethod(name, "Awake", gameObject);
            callLua("Awake", gameObject);
        }

        protected void Start() {
            //Util.CallMethod(name, "Start");
            callLua("Start");
        }

        protected void OnClick() {
            //Util.CallMethod(name, "OnClick");
        }

        protected void OnClickEvent(GameObject go) {
            //Util.CallMethod(name, "OnClick", go);
        }

        /// <summary>
        /// 初始化面板
        /// </summary>
        public void OnInit(AssetBundle bundle, string text = null) {
            this.data = text;   //初始化附加参数
            this.bundle = bundle; //初始化
            Debug.LogWarning("OnInit---->>>" + name + " text:>" + text);
        }

        /// <summary>
        /// 获取一个GameObject资源
        /// </summary>
        /// <param name="name"></param>
        public GameObject LoadAsset(string name) {
            if (bundle == null) return null;
            return Util.LoadAsset(bundle, name);
        }

        /// <summary>
        /// 添加单击事件
        /// </summary>
        public void AddClick(GameObject go, LuaFunction luafunc) {
            if (go == null || luafunc == null) return;
            buttons.Add(go.name, luafunc);
            UIEventListener.Get(go).onClick = delegate(GameObject o) {
                luafunc.Call(go);
            };
        }

        /// <summary>
        /// 删除单击事件
        /// </summary>
        /// <param name="go"></param>
        public void RemoveClick(GameObject go) {
            if (go == null) return;
            LuaFunction luafunc = null;
            if (buttons.TryGetValue(go.name, out luafunc)) {
                buttons.Remove(go.name);
                luafunc.Dispose();
                luafunc = null;
            }
        }

        /// <summary>
        /// 清除单击事件
        /// </summary>
        public void ClearClick() {
            foreach (var de in buttons) {
                if (de.Value != null) {
                    de.Value.Dispose();
                }
            }
            buttons.Clear();
        }
        
        //-----------------------------------------------------------------
        protected void OnDestroy() {
            if (bundle) {
                bundle.Unload(true);
                bundle = null;  //销毁素材
            }
            ClearClick();
            Util.ClearMemory();
            Debug.Log("~" + name + " was destroy!");
        }
    }
}