using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class MyBuilder
{
    // ビルド実行でAndroidのapkを作成する例
    [UnityEditor.MenuItem("Tools/Build Project AllScene Android")]
    public static void BuildProjectAllSceneAndroid()
    {
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
        List<string> allScene = new List<string>();
        foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
        {
            if (scene.enabled)
            {
                allScene.Add(scene.path);
            }
        }
        var companyName = PlayerSettings.companyName;
        var productName = PlayerSettings.productName;

        PlayerSettings.applicationIdentifier = "com." + companyName + "." + productName;

        PlayerSettings.statusBarHidden = true;
        BuildPipeline.BuildPlayer(
                allScene.ToArray(),
                productName + ".apk",
                BuildTarget.Android,
                BuildOptions.None
        );
    }

    // ビルド実行でiOS用のXcodeプロジェクトを作成する例
    [UnityEditor.MenuItem("Tools/Build Project AllScene iOS")]
    public static void BuildProjectAllSceneiOS()
    {
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.iOS);
        List<string> allScene = new List<string>();
        foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
        {
            if (scene.enabled)
            {
                allScene.Add(scene.path);
            }
        }

        BuildOptions opt = BuildOptions.SymlinkLibraries |
                           BuildOptions.AllowDebugging |
                           BuildOptions.ConnectWithProfiler |
                           BuildOptions.Development;


        var companyName = PlayerSettings.companyName;
        var productName = PlayerSettings.productName;

        //BUILD for Device
        PlayerSettings.iOS.sdkVersion = iOSSdkVersion.DeviceSDK;
        PlayerSettings.applicationIdentifier = "jp.co." + productName + "." + companyName;
        PlayerSettings.statusBarHidden = true;
        BuildPipeline.BuildPlayer(
                        allScene.ToArray(),
                        "iOS",
                        BuildTarget.iOS,
                                    opt
                                 );

        //if (string.IsNullOrEmpty(errorMsg_Device))
        //{
        //}
        //else
        //{
        //    // エラー処理
        //}
    }
    
        // ビルド実行でiOS用のXcodeプロジェクトを作成する例
    [UnityEditor.MenuItem("Tools/Build Project AllScene iOS Buy")]
    public static void BuildProjectAllSceneiOSBuy()
    {
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.iOS);
        List<string> allScene = new List<string>();
        foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
        {
            if (scene.enabled)
            {
                allScene.Add(scene.path);
            }
        }

        BuildOptions opt = BuildOptions.SymlinkLibraries |
                           BuildOptions.AllowDebugging |
                           BuildOptions.ConnectWithProfiler |
                           BuildOptions.Development;


        var companyName = PlayerSettings.companyName;
        var productName = PlayerSettings.productName;

        //BUILD for Device
        PlayerSettings.iOS.sdkVersion = iOSSdkVersion.DeviceSDK;
        PlayerSettings.applicationIdentifier = "jp.co." + productName + "." + companyName + ".test";
        PlayerSettings.statusBarHidden = true;
        BuildPipeline.BuildPlayer(
                        allScene.ToArray(),
                        "iOS",
                        BuildTarget.iOS,
                                    opt
                                 );

        //if (string.IsNullOrEmpty(errorMsg_Device))
        //{
        //}
        //else
        //{
        //    // エラー処理
        //}
    }

    // ビルド実行WebGLを作成する例
    [UnityEditor.MenuItem("Tools/Build Project AllScene WebGL")]
    public static void BuildProjectAllSceneWebGL()
    {
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.WebGL);
        List<string> allScene = new List<string>();
        foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
        {
            if (scene.enabled)
            {
                allScene.Add(scene.path);
            }
        }

        BuildOptions opt = BuildOptions.SymlinkLibraries |
                           BuildOptions.AllowDebugging |
                           BuildOptions.ConnectWithProfiler |
                           BuildOptions.Development;


        var companyName = PlayerSettings.companyName;
        var productName = PlayerSettings.productName;

        //BUILD for Device
        PlayerSettings.iOS.sdkVersion = iOSSdkVersion.DeviceSDK;
        PlayerSettings.applicationIdentifier = "jp.co." + productName + "." + companyName;
        PlayerSettings.statusBarHidden = true;
        BuildPipeline.BuildPlayer(
                        allScene.ToArray(),
                        "webgl",
                        BuildTarget.WebGL,
                                    opt
                                 );

        //if (string.IsNullOrEmpty(errorMsg_Device))
        //{
        //}
        //else
        //{
        //    // エラー処理
        //}
    }
}
