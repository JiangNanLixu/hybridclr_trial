using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditorInternal;
using UnityEngine;

[CreateAssetMenu(fileName = "HybridCLRGlobalSettings", menuName = "HybridCLR/GlobalSettings")]
public class HybridCLRGlobalSettings : ScriptableObject
{
    [Header("开启HybridCLR插件")]
    public bool enable = true;

    [Header("从gitee clone插件代码")]
    public bool cloneFromGitee = true; // false 则从github上拉取

    [Header("热更新Assembly Definition Modules")]
    public AssemblyDefinitionAsset[] hotfixAssemblyDefinitions;

    [Header("热更新dlls")]
    public string[] hotfixAssemblies;

    [Header("自动扫描生成的link.xml路径")]
    public string outputLinkFile = "LinkGenerator/link.xml";

    [Header("预留MonoPInvokeCallbackAttribute函数个数")]
    public int pinvokeReverseWrapperCount = 10;

    [Header("MethodBridge泛型搜索迭代次数")]
    public int maxMethodBridgeGenericIteration = 4;

    [Header("热更新dll输出目录（相对HybridCLRData目录）")]
    public string hotfixDllOutputDir = "HotFixDlls";

    [Header("HybridCLRData目录（相对工程目录）")]
    public string hybridCLRDataDir = "HybridCLRData";

    [Header("裁剪后的AOT assembly输出目录")]
    public string strippedAssemblyDir = "AssembliesPostIl2CppStrip";
}
