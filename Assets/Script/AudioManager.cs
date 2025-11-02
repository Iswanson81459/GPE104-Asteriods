using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioSource myAudioSource;
    public float volume;


    public void Start()
    {
        myAudioSource.volume = volume;
    }

    public void PlayAudioAtObject(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, Vector3.zero);
    }

    public void PlayAudioAtVolume()
    {

    }
}

