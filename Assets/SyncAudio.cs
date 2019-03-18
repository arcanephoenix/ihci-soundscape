using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncAudio : MonoBehaviour
{
    public AudioSource source1;
    public AudioSource source2;
    public AudioSource source3;
    public AudioSource source4;
    public AudioSource source5;

    // Update is called once per frame
    void Update()
    {
        source2.timeSamples = source1.timeSamples;
        source3.timeSamples = source1.timeSamples;
        source4.timeSamples = source1.timeSamples;
        source5.timeSamples = source1.timeSamples;
    }
}
