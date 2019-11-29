using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public static class Loader
{
    private static Action loaderCallbackAction;

    public enum Scene
    {
        GameScene,
        Loading,
        MainMenu,
    }

    public static void Load(Scene scene)
    {
        //Sets up callback action that will be triggered when Loading screen is loaded
        loaderCallbackAction = () =>
        {
            SceneManager.LoadScene(scene.ToString());
        };


        //load loading scene when the loading scene is loaded
        SceneManager.LoadScene(Scene.Loading.ToString());

        
        
    }

    public static void LoaderCallback()
    {
        if(loaderCallbackAction != null)
        {
            loaderCallbackAction();
            loaderCallbackAction = null;
        }
    }
}
