using UnityEngine;
using System.Collections;

public class AudioToggleController : MonoBehaviour
{
    AudioSource audioSource;
    public GameObject audioToggleButton;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.mute = !audioSource.mute;
        }
    }
}