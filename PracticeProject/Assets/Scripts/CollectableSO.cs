using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSO : ScriptableObject
{
    //bool checks a true or false statement. Is the collectable correcter, true or false?
    public bool collected;
    //we will use a public int variable to hold number of the items cost value
    public int costValue;
    //We can use GameObject to call out a object within the game
    public GameObject art3D;
    //Sprite is used to call out a Sprite in the game
    public Sprite art2D;
    //Color is used to call out the color variable and set it. We use the PUBLIC tag to make it accessible in game. This goes for everything above too.
    public Color artColorTint;
}
