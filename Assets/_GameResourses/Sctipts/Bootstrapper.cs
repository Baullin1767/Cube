using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    Initializer[] initializers;

    private void Awake()
    {
        initializers = FindObjectsOfType<Initializer>();
        Init();
    }
    public void Init()
    {
        foreach (var item in initializers)
        {
            item.Init();
        }
    }
}
