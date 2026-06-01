using UnityEngine;
using System.Collections;

public class PlayerRespawn : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        // This will print a message to your Console when ANYTHING touches the water
        Debug.Log("Something hit the water: " + other.gameObject.name);
        
        gameManager.PositionPlayer();
    }
}
