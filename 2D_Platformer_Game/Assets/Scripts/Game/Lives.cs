using System.Collections;
using UnityEngine;

// This is code for a scriptable object

// Allows an object to be created in the assets folder to be accessed and edited by scripts in multiple scenes.
// fileName = The name that appears when the object is created ("New Script" for scripts, "Cube" for cubes)
// menuName = The name that appears in the create menu. "/" is used to put it in a folder in the create menu.
// order = The order in which it appears in the list. Useful for organisation.
[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/PlayerData", order = 1)]
public class Lives : ScriptableObject {
    
    // I am using this scriptable object to keep the number of lives remaing the same across scenes.
    public int playerLives = 3;
}
