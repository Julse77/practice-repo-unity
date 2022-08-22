using UnityEngine;
using UnityEditor;
using System.IO;

public class BuildiOSAssetBundles : MonoBehaviour
{
    [MenuItem("Bundle/Build iOS AssetBundle")]
    static void BuildAssetBundles()
    {
        string assetBundleDirectory = "Assets/AssetBundles_ios";
        if (!Directory.Exists(assetBundleDirectory))
        {
            Directory.CreateDirectory(assetBundleDirectory);
        }

        var options = BuildAssetBundleOptions.None;

        bool shouldCheckODR = EditorUserBuildSettings.activeBuildTarget == BuildTarget.iOS;

#if UNITY_TVOS
            shouldCheckODR |= EditorUserBuildSettings.activeBuildTarget == BuildTarget.tvOS;
#endif

        if (shouldCheckODR)
        {
#if ENABLE_IOS_ON_DEMAND_RESOURCES
            if (PlayerSettings.iOS.useOnDemandResources)
                options |= BuildAssetBundleOptions.None;
#endif

#if ENABLE_IOS_APP_SLICING
            options |= BuildAssetBundleOptions.None;
#endif
        }

        BuildPipeline.BuildAssetBundles(assetBundleDirectory, options, EditorUserBuildSettings.activeBuildTarget);
    }


}
