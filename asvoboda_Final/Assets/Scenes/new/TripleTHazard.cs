using UnityEngine;

public class TripleTHazard : MonoBehaviour
{
    // Drag your GameManager object into this slot in the Unity Inspector
    public GameManager gameManager; 
    
    [Header("Unique Boss Feature")]
    [Tooltip("Seconds added to the timer when hitting Triple T")]
    public float timePenalty = 5.0f; 

    // Using OnTriggerEnter just like your PlayerRespawn script does
    private void OnTriggerEnter(Collider other)
    {
        // Checks if the object hitting the boss is the player
        if (other.gameObject.name == "FPSController" || other.CompareTag("Player"))
        {
            Debug.Log("Player hit Triple T! Adding time penalty.");
            
            // 1. THE UNIQUE FEATURE: Add a time penalty to the clock
            gameManager.elapsedTime += timePenalty;
            
            // 2. STANDARD HAZARD LOGIC: Teleport the player back to the empty spawn point
            gameManager.PositionPlayer();
        }
    }
}
