using UnityEngine;

[System.Serializable]
public class SoundFX
{
    public AudioClip clip;
    public float volume = 1.0f;
}

public class RandomSound : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private SoundFX[] sounds;

    public void PlayOneShot()
    {
        int index = Random.Range(0, sounds.Length);
        audioSource.PlayOneShot(sounds[index].clip, sounds[index].volume);
    }
}
