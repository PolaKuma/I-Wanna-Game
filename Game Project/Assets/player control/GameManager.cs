using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject m_player;
    public static float count  = 0;
    public GameObject ui_GameStartImage;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 vec = Vector3.zero;

        vec.x = PlayerPrefs.GetFloat("CameraPosX", 0);
        vec.y = PlayerPrefs.GetFloat("CameraPosY", 4);
        vec.z = PlayerPrefs.GetFloat("CameraPosZ", -10);
        Camera.main.transform.position = vec;

        vec.x = PlayerPrefs.GetFloat("PlayerPosX", -8.5f);
        vec.y = PlayerPrefs.GetFloat("PlayerPosY", 7.5f);
        vec.z = PlayerPrefs.GetFloat("PlayerPosZ", 0);
        m_player.transform.position = vec;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("重新开始"))
        {
            SceneManager.LoadScene("SampleScene");
            count++;
            //音效
            GameObject.Find("SoundManager").SendMessage("StartLevelAudio");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlayerPrefs.SetFloat("PlayerPosX", -9);
            PlayerPrefs.SetFloat("PlayerPosY", -2);
            PlayerPrefs.SetFloat("PlayerPosZ", 0);

            PlayerPrefs.SetFloat("CameraPosX", 0);
            PlayerPrefs.SetFloat("CameraPosY", 4);
            PlayerPrefs.SetFloat("CameraPosZ", -10);
            ui_GameStartImage.SetActive(true);

        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            count++;
            ui_GameStartImage.SetActive(false);
        }
        if (count == 0)
        {
            ui_GameStartImage.SetActive(true);
        }
    }
}
