using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backsound : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("backsound on") == null)
        {
            DontDestroyOnLoad(gameObject);
            gameObject.name = "backsound on";
            audioSource = GetComponent<AudioSource>();
            if (audioSource != null)
            {
                audioSource.Play();
                PlayerPrefs.SetFloat("volume", 1f);
            }
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instance
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (audioSource != null)
        {
            float volume = PlayerPrefs.GetFloat("volume", 1f); // Default value is 1
            audioSource.volume = volume;
            print(volume);
        }
    }
}