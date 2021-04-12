using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public TileManager tileManager;
    public TileManager.Owner owner;
    public GameObject SwordPrefab;
    public GameObject ShieldPrefab;

    public void OnMouseUp()
    {
        // Check for current player that is claiming ownership of this space
        owner = tileManager.false;
        
        SwordPrefab.SetActive(true);
        ShieldPrefab.SetActive(false);
        
        // Set the sprite color to represent the owner (Sword = Blue, Shield = Red)
        if (owner == TileManager.Owner.Sword)
        {
            SwordPrefab.SetActive(true);
            //Instantiate(SwordPrefab, transform.position, trasform.rotation);
            //Destroy(GameObject);
        }
            
        //GameObject go = (GameObject)Instantiate(SwordPrefab);
        //this.GetComponent<SpriteRenderer>().color = Color.blue;
        else if (owner == TileManager.Owner.Shield)
        {
            ShieldPrefab.SetActive(true);
            //Instantiate(ShieldPrefab, transform.position, trasform.rotation);
            //Destroy(GameObject);
        }
            
       
        //GameObject go = (GameObject)Instantiate(ShieldPrefab);
        // this.GetComponent<SpriteRenderer>().color = Color.red;

        // Update to the next player in rotation
        tileManager.ChangePlayer();
    }

    public void ClickReset()
    {
        if (owner == TileManager.Owner.Sword)
            owner = TileManager.Owner.None;
    }
}
