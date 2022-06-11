using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class LoadAssetBundleSceneFromFile : MonoBehaviour
{    
    void Awake()
    {
        // Load AssetBundle Path
        var myLoadedAssetBundle =
            AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath,
            "/Users/minjisu/Documents/GitHub/Unity_Practice_Repository/My project/Assets/Test_AssetBundle/ab_ui_practice"));

        //WWW bundleWWW = WWW.LoadFromCacheOrDownload(sceneURL, 1);
        //yield return bundleWWW;
        //assetBundle = bundleWWW.assetBundle;

        if (myLoadedAssetBundle.isStreamedSceneAssetBundle)
        {
            string[] scenePaths = myLoadedAssetBundle.GetAllScenePaths();
            string sceneName = System.IO.Path.GetFileNameWithoutExtension(scenePaths[0]);
            SceneManager.LoadScene(sceneName);

        }

    }

}
