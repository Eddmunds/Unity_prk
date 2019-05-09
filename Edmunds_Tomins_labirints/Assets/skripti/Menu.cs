using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement; //tiek izmantots lai piekļūtu ainu funkcijām

public class Menu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        EditorSceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void toMain()
    {
        EditorSceneManager.UnloadSceneAsync("SampleScene");
        EditorSceneManager.LoadScene(0);
    }

}