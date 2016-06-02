--检测玩家输入, 随机生成连连看关卡
require "Common/define"
require("Common/functions")

require "3rd/pblua/login_pb"
require "3rd/pbc/protobuf"
require("Controller/LLKItemCtrl")
require("Logic/LLKMain")

local sproto = require "3rd/sproto/sproto"
local core = require "sproto.core"
local print_r = require "3rd/sproto/print_r"

LLKCtrl = {};
local this = LLKCtrl;

local panel;
local prompt;
local transform;
local gameObject;
--一维的数组
local QiArray = {}
local QiTrack = {}
local crtState = LLKItemCtrl.STATE_NONE
local M = 6 --6行
local N = 10 --10列
local firstQi = nil
local secondQi = nil

--构建函数--
function LLKCtrl.New()
	logWarn("LLKCtrl.New--->>");
	llk.init(QiTrack)
	return this;
end

function LLKCtrl.Awake()
	logWarn("LLKCtrl.Awake--->>");
	panelMgr:CreatePanel('LLK', this.OnCreate);
end

--启动事件--
function LLKCtrl.OnCreate(obj)
    gameObject = obj;
	transform = obj.transform;

	panel = transform:GetComponent('UIPanel');
	prompt = transform:GetComponent('LuaBehaviour');
	logWarn("Start lua--->>"..gameObject.name);

	this.InitPanel();	--初始化面板--
	prompt:AddClick(PromptPanel.btnOpen, this.OnClick);
end

--随机生成图片ID
local function resetQi()
	math.randomseed(tostring(os.time()):reverse():sub(1, 6))  
	local arr = {}
	for i = 1,#QiArray do
		arr[i] = i
	end
	for i = 1, M do
		QiTrack[i] = {}
	end
	print('arr length is ', #arr)
	
	
	local ttt = 0
	while #arr > 0 do
		local id =  math.random(1,10)
		local a = math.random(1,#arr)
		local c = QiArray[arr[a]]
		table.remove(arr,a)
		local b = math.random(1,#arr)
		local d = QiArray[arr[b]]
		table.remove(arr,b)
		print("a,b",a,b)
		QiArray[c.value]:setValue(id)
		QiArray[d.value]:setValue(id)
		ttt = ttt + 1
		if ttt > 70 then
		print'fuck it is larger than 79'
			break
		end
	end
	for i = 1, #QiArray do
		local temp = i % N
		if temp == 0 then
			temp = N
		end
		print('gen',math.ceil(i/N), temp)
		QiTrack[math.ceil(i/N)][temp] = QiArray[i]
	end	
end

--初始化面板--
function LLKCtrl.InitPanel()
	panel.depth = 1;	--设置纵深--
    local tsGrid = panel.transform:FindChild("grid")
    print("==========> ts grid is ", tsGrid)
	local parent = PromptPanel.gridParent;
	local itemPrefab = prompt:LoadAsset('LLKItem');
	local j = 0
	for i = 1, M * N do
		local go = newObject(itemPrefab);
		go.name = tostring(i);
		go.transform.parent = tsGrid
		go.transform.localScale = Vector3.one;
		go.transform.localPosition = Vector3.zero;
		prompt:AddClick(go, this.OnItemClick);
        local lh = go:AddComponent(typeof(LuaFramework.LuaBehaviour))
		local temp = i % N
		if temp == 0 then
			temp = N
		end
        local itemGo = LLKItemCtrl.New(math.ceil(i/N),temp, i, go)
        --缺点, 必须得每个LUA指定一个名字才行.
        lh:addLua(itemGo,"just test name")
		local goo = go.transform:FindChild('Label');
		goo:GetComponent('UILabel').text = i;
        QiArray[i] = itemGo
        --这里添加了一个变量的引用
        QiArray[i].txt = goo:GetComponent('UILabel')
		--itemGo:onDispose()
		--QiTrack[itemGo.x][itemGo.y] = itemGo
	end
	local grid = tsGrid:GetComponent('UIGrid');
	grid:Reposition();
	grid.repositionNow = true;
    panel.transform.localPosition = Vector3(-200,100,0)
	--parent:GetComponent('WrapGrid'):InitGrid();
	resetQi()
end



--滚动项单击事件--
function LLKCtrl.OnItemClick(go)
    local lh = go:GetComponent("LuaBehaviour")
    --lh:callLua("func",'ww','ee','rr')
    local ll = lh:getLua("just test name");
    --ll:onDispose()
    print("whhhhhhhh======>", ll.txt.text)
    ll:display()
    ll:onSelect(true)
    if crtState == LLKItemCtrl.STATE_NONE then            
        print'--第一下点'
		crtState = LLKItemCtrl.STATE_FIRST
		ll.state = LLKItemCtrl.STATE_FIRST
		firstQi = ll
    elseif crtState == LLKItemCtrl.STATE_FIRST then
        if ll.state == LLKItemCtrl.STATE_NONE then
        	print'--点击第二个, 得要考虑是否会消除'
			secondQi = ll
			if llk.check(firstQi, secondQi) then
				print'连着的'
				firstQi:dispose()
				secondQi:dispose()
				crtState = LLKItemCtrl.STATE_NONE --状态回到空		    				
			else
				print'不是连着的'
				crtState = LLKItemCtrl.STATE_FIRST	--当作第一下点
				firstQi.state = LLKItemCtrl.STATE_NONE --清空之前点击的状态
				ll.state = LLKItemCtrl.STATE_FIRST	    --当前按钮当作是第一次点
				firstQi = ll	--当前按钮为被点击按钮
			end 			           
        elseif ll.state == LLKItemCtrl.STATE_FIRST then
        	print'--第一下点了自己, 然后第二下又点了自己'
			crtState = LLKItemCtrl.STATE_FIRST		    
			ll.state = LLKItemCtrl.STATE_FIRST
			firstQi = ll	    
        end
    end
end

--单击事件--
function LLKCtrl.OnClick(go)
	logWarn("OnClick---->>>"..go.name);
end

--关闭事件--
function LLKCtrl.Close()
	panelMgr:ClosePanel(CtrlNames.Prompt);
end


