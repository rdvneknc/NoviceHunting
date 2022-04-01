using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton kendisi = null;
    public int score = 0;

    
    public static Singleton KendiFonksiyon
    {
        get
        {
            return kendisi;
        }
    }

    private void Awake()
    {
        
        if (kendisi != null && kendisi != this)
        {
            Destroy(gameObject);
        }

        kendisi = this;
        DontDestroyOnLoad(gameObject);
    }
}
