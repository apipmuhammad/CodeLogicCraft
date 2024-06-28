using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplasScreen : MonoBehaviour
{
    public float timer = 3;
    public void Update() {
        timer -= Time.deltaTime;
        if (timer > 0)
        {
            Debug.Log(timer);

        }
        else {
            Application.LoadLevel("Start Menu");
        }
    }
}
