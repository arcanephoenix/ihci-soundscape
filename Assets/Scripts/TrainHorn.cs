using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Plays the train horn every 20 seconds
 */
public class TrainHorn : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(SoundsTick());
    }

    IEnumerator SoundsTick()
    {
        while (true)
        {
            audioSource.Play();
            yield return new WaitForSeconds(20f);
        }
    }
}
