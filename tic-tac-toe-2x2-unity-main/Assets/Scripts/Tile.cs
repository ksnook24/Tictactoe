using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public TileManager tileManager;
    public TileManager.Owner owner;
    public Sprite Sword;
    public Sprite Shield;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        //tileManager.Start();
        spriteRenderer = GetComponent<SpriteRenderer>();
        //spriteRenderer.sprite = null;
    
        
    }
    public void OnMouseUp()
    {

        //owner= tileManager.true;
        // Check for current player that is claiming ownership of this space
        //owner = tileManager.false;

        // spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        // Set the sprite color to represent the owner (Sword = Blue, Shield = Red)
        //if (owner == TileManager.Owner.Sword)
        //spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        // spriteRenderer.sprite = Sword;


        //GameObject go = (GameObject)Instantiate(SwordPrefab);
        // this.GetComponent<SpriteRenderer>().color = Color.blue;


        if (owner == TileManager.Owner.Shield)
            //this.GetComponent<SpriteRenderer>().sprite = Shield;
            //  spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            // spriteRenderer.sprite = Shield;
            ShieldChange();

        else if (owner == TileManager.Owner.Sword)
            SwordChange();

               //(owner == TileManager.Owner.Sword)
            //this.GetComponent<SpriteRenderer>().sprite = Shield;
          //  spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
           // spriteRenderer.sprite = Sword;
            
        
            
       
       // GameObject go = (GameObject)Instantiate(ShieldPrefab);
        //this.GetComponent<SpriteRenderer>().color = Color.red;

        // Update to the next player in rotation
        tileManager.ChangePlayer();
    }

    public void ShieldChange()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Shield;
    }
       
    public void SwordChange()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Sword;
    }


   // public void ClickReset()
   // {
   //     if (owner == TileManager.Owner.Sword)
   //         owner = TileManager.Owner.None;
    //}
}
