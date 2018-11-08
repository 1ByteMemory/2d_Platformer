using System.Collections;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/PlayerData", order = 1)]
public class Lives : ScriptableObject {
    
    public int playerLives = 3;
}
