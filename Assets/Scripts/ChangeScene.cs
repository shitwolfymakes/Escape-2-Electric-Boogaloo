using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    void Awake()
    {
        // To show cursor after First Person Controller
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("DefaultLevel");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void changeHelp()
    {
        SceneManager.LoadScene("Help");
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void loadHonestJohn()
    {
        SceneManager.LoadScene("BobShop");
    }

    public void loadMadamCannon()
    {
        SceneManager.LoadScene("MadamCannon");
    }

    public void loadBusted()
    {
        SceneManager.LoadScene("Busted");
    }


}
