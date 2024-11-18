using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void Pause()
    {

    }

    public void SetTime(float time)
    {
        source.time = time;
    }
        
}
