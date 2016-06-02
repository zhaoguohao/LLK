--核心算法在这里
local H = 6 --行 up to down : x
local V = 10  --列  left to right :y 
local QiTrack = nil
llk = {}
llk.init = function(track)
    QiTrack = track
end
llk.check = function(first,second)
    print('---------查看下面两个是否会相连---------')
    first:display()
    second:display()
    if first.value ~= second.value then
        print('两个值都不相等, 还计算个毛')
        return false
    end
    --检查两者周围的点是否可以组成连线.
    local a = llk.getEmpty(first)
    local b = llk.getEmpty(second)
    for ak,av in pairs(a) do
        for bk,bv in pairs(b) do
            if llk.checkALine(av,bv) == true then
                print'在空余的位置相连, 找到了,可以连通的'
                av:display()
                bv:display()
                if av.value == bv.value then 
                    print('相连',av.value, bv.value)
                    return true
                end
            end
        end
    end
    --检查两点之间是不是连线
    if llk.checkALine(first,second) then
        print'本身就直接相连, 找到了,可以连通的'
        return true
    end
    print('-----------不相连-----------')
    return false
end

llk.checkALine = function(first,second)
    print('查看是不是在一条线')
    first:display()
    second:display()
    local delta 
    --if one at the out side, but not in a line
    if (first.x == 0 or first.y == 0 or first.x == H+1 or first.y == V+1
    or second.x == 0 or second.y == 0 or second.x == H+1 or second.y == V+1) 
    and (first.x ~= second.x and first.y ~= second.y) then
        return false
    end
    --if in a line at out side
    if first.x == second.x and first.x == 0 
    or first.y == second.y and first.y == 0
    or first.x == second.x and first.x == H+1
    or first.y == second.y and first.y == V+1 then
        return true
    end


    if first.x == second.x then
        if second.y > first.y then
            delta = 1
        else
            delta = -1
        end
        for i = first.y + delta, second.y - delta, delta do
            print('x,y',first.x,i)
            if QiTrack[first.x][i].value > 0 then
                print('--有棋子挡道')
                return false
            end
        end
        return true
    end
    
    if first.y == second.y then
        if second.x > first.x then
            delta = 1
        else
            delta = -1
        end
        for i = first.x + delta, second.x - delta, delta do
            print('x,y',i,first.y)
            if QiTrack[i][first.y].value > 0 then
                print('--有棋子挡道')
                return false
            end
        end
        return true
    end

    --[[local list,a,b,c,d = llk.getEmpty(first)
    if second:equal(a) or second:equal(b) or second:equal(c) or second:equal(d) then
        print('有相等的')
        return true
    end
    return false]]--
end

function llk.getEmpty(qi)
    --print('.tr is ',self.tr)
    local ret = {}
    local i = 1
    local l,r,u,d
    local found = false
    --左侧
    for h=qi.y-1,1,-1 do
        --print('qi.x, h is: ',qi.x,h)
        if QiTrack[qi.x][h].value > 0 then
            --有棋子,结束循环
            l = QiTrack[qi.x][h]
            found = true
            break
        else
            --是空的
            ret[i] = QiTrack[qi.x][h]
            i = i+1
        end
    end
    if found == false then
        l = LLKItemCtrl.New(qi.x,0,0)
        ret[i] = l
        i = i + 1
    end
    found = false
    --右侧
    for h=qi.y+1,V,1 do
        if QiTrack[qi.x][h].value > 0 then
            --有棋子,结束循环
            r = QiTrack[qi.x][h]
            found = true
            break
        else
            --是空的
            ret[i] = QiTrack[qi.x][h]
            i = i+1
        end
    end
    if found == false then
        r = LLKItemCtrl.New(qi.x,V+1,0)
        ret[i] = r 
        i = i + 1
    end
    found = false
    --上侧
    for v=qi.x-1,1,-1 do
        if QiTrack[v][qi.y].value > 0 then
            u = QiTrack[v][qi.y]
            found = true
            break
        else
            ret[i] = QiTrack[v][qi.y]
            i = i+1
        end
    end
    if found == false then
        u = LLKItemCtrl.New(0,qi.y,0)
        ret[i] = u
        i = i + 1
    end
    found = false
    --下侧
    for v=qi.x+1,H,1 do
        if QiTrack[v][qi.y].value > 0 then
            d = QiTrack[v][qi.y]
            break
        else
            ret[i] = QiTrack[v][qi.y]
            i = i+1
        end
    end
    if found == false then
        d = LLKItemCtrl.New(H+1,qi.y,0)
        ret[i] = d 
    end
    found = false
    return ret,l,r,u,d
   end