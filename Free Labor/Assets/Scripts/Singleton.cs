using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : Component
{
    public static T Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("More than one Singleton Detected: " + gameObject.name);
        }

        Instance = this as T;
    }
}
