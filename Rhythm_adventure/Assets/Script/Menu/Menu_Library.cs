using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Library : MonoBehaviour
{
    [SerializeField] GameObject Loading_Panel;
    [SerializeField] GameObject[] chapPenal;

    private int chapter = 0;
    AsyncOperation Async;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Load_Level(string sceneName)
    {
        if(sceneName != "")
        {
            Loading_Panel.SetActive(true);
            StartCoroutine(Loading_Scene(sceneName));
        }
    }

    IEnumerator Loading_Scene(string sceneName)
    {
        yield return new WaitForEndOfFrame();
        Async = SceneManager.LoadSceneAsync(sceneName);
        yield return Async;
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
