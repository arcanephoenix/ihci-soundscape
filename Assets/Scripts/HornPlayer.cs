using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HornPlayer : MonoBehaviour
{
    private AudioSource[] cars = new AudioSource[5];
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        foreach(GameObject gob in GameObject.FindGameObjectsWithTag("traffic")) {
            cars[i] = gob.GetComponent<AudioSource>();
            i++;
        }
        StartCoroutine(SoundsTick());

    }
    IEnumerator SoundsTick()
    {
        while (true)
        {
            for (int z = 0; z < cars.Length; z++)
            {
                
                int i = Random.Range(0, cars.Length);
                cars[i].Play();
                yield return new WaitForSeconds(0.5f);
                //cars.Remove(i);
            }
        }
    }
}
