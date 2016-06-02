-- 单个Item的控制.绑在GameObject上面的Lua脚本.
require("Common/define")

LLKItemCtrl = { }


LLKItemCtrl.STATE_NONE = 0
LLKItemCtrl.STATE_FIRST = 1
LLKItemCtrl.STATE_SECOND = 2


function LLKItemCtrl.New(xx, yy, identify, obj)
    local item = { }
    -- setmetatable(item, item)
    -- 图片的ID值
    item.value = identify
    -- 0:未选中, 1: 第一个选中状态, 2: 第二个选中状态
    item.state = LLKItemCtrl.STATE_NONE
    item.x = xx
    item.y = yy
    item.go = obj
    -- item.spt = item.go:GetComponent('UISprite')

    function item:onDispose()
        print("item dispose now ", "self", self)
        print("self.x,self.y", self.x, self.y)
    end

    function item.display()
        -- print("display",self.x, self.y, self.id)
        print("display", item.x, item.y, item.value, 'self:', self)
    end

    function item.func(a, b, c)
        print("a,b,c", a, b, c)
        print("you call item.func")
    end

    function item.Awake()
        print('这个会自动调用的吗? llkitem ctrl awake')
    end

    function item:Start()
        local spt = item.go:GetComponent('UISprite')
        if spt ~= nil then
            spt.spriteName = tostring(item.value)
            spt.depth = 4
            print('sssssss')
            print(spt.depth)
        end
        local btn = item.go:GetComponent('UIButton')
        --[[
        disabledSprite = ""
        pressedSprite = "";
        hoverSprite = "";
        normalSprite = "";
         ]]
        btn.disabledSprite = tostring(item.value)
        btn.pressedSprite = tostring(item.value)
        btn.hoverSprite = tostring(item.value)
        btn.normalSprite = tostring(item.value)
        item.btn = btn
        item.spt = spt
    end

    function item:setValue(img)
        print('self.txt is ', self.txt, 'img', img)
        self.txt.text = ""
        self.value = img
    end

    function item:onSelect(yes)
        if yes then
            self.spt.depth = 3
        else
        end
    end

    function item:equal(other)
        if other ~= nil then
            if other.x == self.x and
                other.y == self.y and
                other.value == self.value then
                return true
            else
                return false
            end
        end
        return false
    end

    function item:dispose()
        item.go:SetActive(false)
        item.value = 0
    end

    function item:updateState(state)
        print(item.spt)
    end

    return item
end

