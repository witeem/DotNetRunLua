// See https://aka.ms/new-console-template for more information
using Neo.IronLua;

using (Lua l = new Lua())
{
    var g = l.CreateEnvironment();
    var r = g.DoChunk($"LuaLib/ExecMyModule.lua");
    g.CallMember("CallFunc1");
    g.CallMember("CallFunc3");
    Console.ReadKey();
}
