using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPause = false;
    [SerializeField] GameObject PauseMenu_Panel;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
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

    void Pause()
    {
        PauseMenu_Panel.SetActive(true);
        isPause = true;
        Time.timeScale = 0.0f;
    }

    void Resume()
    {
        PauseMenu_Panel.SetActive(false);
        isPause = false;
        Time.timeScale = 1.0f;
    }
}
