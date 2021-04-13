using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public Owner CurrentPlayer;
    public Tile[] Tiles = new Tile[4];
    public quit_button QuitButton;
    public reset_button ResetButton;
    public int SwordScore;
    public int ShieldScore;
    //public GameObject quitbutton;
    //public GameObject resetbutton;

    public enum Owner
    {
        None,
        Sword,
        Shield
    }

    private bool won;

    // Start is called before the first frame update
    void Start()
    {
        won = false;
        CurrentPlayer = Owner.Sword;
    }

    public void ChangePlayer()
    {
        if (CheckForWinner())
            return;

        if (CurrentPlayer == Owner.Sword)
            CurrentPlayer = Owner.Shield;
        else
            CurrentPlayer = Owner.Sword;
    }

    public bool CheckForWinner()
    {
        if (Tiles[6].owner == CurrentPlayer && Tiles[7].owner == CurrentPlayer && Tiles[8].owner == CurrentPlayer)
            won = true;
        else if (Tiles[5].owner == CurrentPlayer && Tiles[0].owner == CurrentPlayer && Tiles[1].owner == CurrentPlayer)
            won = true;
        else if (Tiles[4].owner == CurrentPlayer && Tiles[3].owner == CurrentPlayer && Tiles[2].owner == CurrentPlayer)
            won = true;
        else if (Tiles[6].owner == CurrentPlayer && Tiles[5].owner == CurrentPlayer && Tiles[4].owner == CurrentPlayer)
            won = true;
        else if (Tiles[7].owner == CurrentPlayer && Tiles[0].owner == CurrentPlayer && Tiles[3].owner == CurrentPlayer)
            won = true;
        else if (Tiles[8].owner == CurrentPlayer && Tiles[1].owner == CurrentPlayer && Tiles[2].owner == CurrentPlayer)
            won = true;
        else if (Tiles[6].owner == CurrentPlayer && Tiles[0].owner == CurrentPlayer && Tiles[2].owner == CurrentPlayer)
            won = true;
        else if (Tiles[8].owner == CurrentPlayer && Tiles[0].owner == CurrentPlayer && Tiles[4].owner == CurrentPlayer)
            won = true;

        //void ScoreDisplay(int indexIn)
        //{
         //   if (CurrentPlayer == Owner.Sword)
         //       SwordScore++;
          //  else if (CurrentPlayer == Owner.Shield)
          //      ShieldScore++;
        //}
        
        if (won)
        {
            Debug.Log("Winner: " + CurrentPlayer);

            //ScoreDisplay();
            //return;
            if (CurrentPlayer == Owner.Sword)
                SwordScore++;
            else if (CurrentPlayer == Owner.Shield)
                ShieldScore++;

            QuitButton.GameOver();
            return true;

            ResetButton.GameOver();
            return true;

            // resetbutton.SetActive(true);
            // quitbutton.SetActive(true);
        }

       // void OnClickReset()
        //{
            //Tiles[5].owner == None
            
        //}

        return false;
    }
}
