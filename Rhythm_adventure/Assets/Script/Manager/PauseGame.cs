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
    [SerializeField] GameObject Pause_Panel;
    [SerializeField] GameObject Statistics_Panel;
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
        if (GM_Ref.isGameOver)
        {
            Show_Statistics();
            GM_Ref.isGameOver = false;
        }
    }

    // Pause gmae
    void Pause()
    {
        if(!GM_Ref.isGameOver)
        {
            Pause_Panel.SetActive(true);
            isPause = true;
            GM_Ref.Music_Main.Pause();
            Time.timeScale = 0.0f;
        }
    }

    public void Resume()
    { 
        Pause_Panel.SetActive(false);
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

    void Show_Statistics()
    {
        Statistics_Panel.SetActive(true);
    }

    //Quit game
    public void Exit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
