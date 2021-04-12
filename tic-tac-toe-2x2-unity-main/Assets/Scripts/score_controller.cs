using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_controller : MonoBehaviour
{
    public int score = 0;

    public void UpdateScore()
    {
        GetComponent<UnityEngine.UI.Text>().text = "Swords " + score;
    }

    //if win()
   // {
     //   score 
   // }
}
