using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelpage : MonoBehaviour
{
  
    public void play(string scene_name)
    {
        Application.LoadLevel(scene_name);
    }


}
