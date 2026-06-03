using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadGame()
    {
        // This now perfectly matches your scene name. 
        // Note: Capitalization matters! If your scene is "Game" with a capital G, change it here too.
        SceneManager.LoadScene("game"); 
    }
}