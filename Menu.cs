using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void Start()
    {
        //PlayerPrefs.DeleteAll();
    }
    public void game()
    {
        int loadedLevel = PlayerPrefs.GetInt("load");

        if (loadedLevel == 0)
        {
            SceneManager.LoadScene(loadedLevel+1); // sceen switcher if i havent level, this calling 0 
        }
        else
        {
            SceneManager.LoadScene(loadedLevel);
        }
    }

    public void exit()
    {
        Application.Quit(); // for exit
        PlayerPrefs.DeleteAll();
    }
}

