using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RhythmAssets;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Rhythm_GameMode GM_Ref;  
    public bool isPause = false;
    [SerializeField] GameObject Panel;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (isPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    // Pause gmae
    void Pause()
    {
        Panel.SetActive(true);
        isPause = true;
        GM_Ref.Music_Main.Pause();
        Time.timeScale = 0.0f;
    }

    public void Resume()
    { 
        Panel.SetActive(false);
        isPause = false;
        GM_Ref.Music_Main.Play(); 
        Time.timeScale = 1.0f;
    }

    //Back to MainMenu
    public void Load_MainMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainMenu");
    }
       
    //Quit game
    public void Exit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
