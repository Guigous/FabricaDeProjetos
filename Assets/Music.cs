using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class ExampleClass : MonoBehaviour
{
    public AudioClip smileStartClip;
    public AudioClip smileLoopClip;
    void Start()
    {
        GetComponent<AudioSource>().loop = true;
        StartCoroutine(playEngineSound());
    }

    IEnumerator playEngineSound()
    {
        GetComponent<AudioSource>().clip = smileStartClip;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        GetComponent<AudioSource>().clip = smileLoopClip;
        GetComponent<AudioSource>().Play();
    }
}