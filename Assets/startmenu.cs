using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startmenu : MonoBehaviour
{
    public void exit()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Untuk menghentikan play mode di editor
#endif
    }

    public void play(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
    

    public void sound_volume(float volume)
    {
        PlayerPrefs.SetFloat("volume", volume);
        AudioListener.volume = volume; // Menerapkan volume ke AudioListener
    }
}
