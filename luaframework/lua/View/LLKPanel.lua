--这里貌似啥也没做啊
local transform;
local gameObject;

LLKPanel = {};
local this = LLKPanel;

--启动事件--
function LLKPanel.Awake(obj)
	gameObject = obj;
	transform = obj.transform;

	this.InitPanel();
	logWarn("Awake lua--->> in llkpanel"..gameObject.name);
end

--初始化面板--
function LLKPanel.InitPanel()
	--this.btnClose = transform:FindChild("Button").gameObject;
end

function LLKPanel.Start()
    print'llkpanel will auto call?'
end

--单击事件--
function LLKPanel.OnDestroy()
	logWarn("OnDestroy---->>>");
end

function LLKPanel.OnEnable()
    print 'llk on enable'
end

