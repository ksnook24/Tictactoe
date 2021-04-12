using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit_button : MonoBehaviour
{
    public UnityEngine.UI.Text WinText;
    public GameObject QuitButton;
    //public string ButtonText;

    // Start is called before the first frame update
    public void Start()
    {
        QuitButton.SetActive(false);
    }

    public void GameOver()
    {
        QuitButton.SetActive(true);
        //WinText.text = ButtonText;
    }
    public void Quit()
    {
        Application.Quit();
    }

}
