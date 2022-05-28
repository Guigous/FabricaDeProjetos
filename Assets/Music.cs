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
        audio.clip = smileStartClip;
        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
        audio.clip = smileLoopClip;
        audio.Play();
    }
}