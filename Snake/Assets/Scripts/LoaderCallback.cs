using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LoaderCallback : MonoBehaviour
{
    private bool firstUpdate = true;

    
    
    private void Update()
    {
        if (firstUpdate)
        {
            firstUpdate = false;
            Loader.LoaderCallback();
        }
    }
}
