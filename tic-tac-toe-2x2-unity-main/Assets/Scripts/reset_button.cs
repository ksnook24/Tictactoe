using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset_button : MonoBehaviour
{
    public UnityEngine.UI.Text ResetText;
    public GameObject ResetButton;
    //public string ButtonText;

    // Start is called before the first frame update
    public void Start()
    {
        ResetButton.SetActive(false);
    }

    public void GameOver()
    {
        //WinText.text = ButtonText;
        ResetButton.SetActive(true);

    }

    public void OnClickReset()
    {
       // Tile.ClickReset();
        //return true;
    }

}
