using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    public float CX;
    public float PX;
    public float PY;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerPrefs.SetFloat("CameraPosX", CX);
            PlayerPrefs.SetFloat("CameraPosY", 4);
            PlayerPrefs.SetFloat("CameraPosZ", -10);
            PlayerPrefs.SetFloat("PlayerPosX", PX);
            PlayerPrefs.SetFloat("PlayerPosY", PY);
            PlayerPrefs.SetFloat("PlayerPosZ", 0);
            SceneManager.LoadScene("SampleScene");
        }
    }
}

