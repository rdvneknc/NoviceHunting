using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voice : MonoBehaviour
{
    public AudioSource voiceKeeper;

    
    // Start is called before the first frame update
    void Awake()
    {
        voiceKeeper = GetComponent<AudioSource>();

        voiceKeeper.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VoiceFunction()
    {
        //voiceKeeper = GetComponent<AudioSource>();

        voiceKeeper.Play();

    }
}
