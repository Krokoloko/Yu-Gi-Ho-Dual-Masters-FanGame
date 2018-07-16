using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OnButtonClick : MonoBehaviour {

    GameObject[] Objects;

    public void Quit()
    {
        Application.Quit();
    }

    public void SceneSwitch(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void MenuSelector(string menu)
    {
        Objects = GameObject.FindGameObjectsWithTag(menu);
        
        if(Objects[0].activeSelf == true)
        {
            HideElement();
        }
        else if(Objects[0].activeSelf == false)
        {
            ShowElement();
        }
    }

    private void ShowElement()
    {
        foreach (GameObject g in Objects)
        {
            g.SetActive(true);
        }
    }

    public void HideElement()
    {
        foreach (GameObject g in Objects)
        {
            g.SetActive(false);
        }
    }
}
