using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Library : MonoBehaviour
{
    public string levelName = "";
    public GameObject[] chapPenal;

    public int chapter = 0;
   

//    public Scene B = SceneManager.GetActiveScene();
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Load_Level(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    
    private int lastChapter = 1;
    public void Switch_Chap(bool isNextChap)
    {
        // 0 equal chapter 1
        if(isNextChap)
        {
            if(chapter != lastChapter)
            {
                chapPenal[chapter].SetActive(false);
                chapter++;
                chapPenal[chapter].SetActive(true);
            }
        }
        else
        {
            if (chapter != 0)
            {
                chapPenal[chapter].SetActive(false);
                chapter--;
                chapPenal[chapter].SetActive(true);
            }
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
