local MyModule = {}
MyModule.constant = "这是一个常量"
function MyModule.func1()
    io.write("这是一个公有函数！\n")
end

local function func2()
    print("这是一个私有函数")
end

function MyModule.func3()
    func2()
end

return MyModule