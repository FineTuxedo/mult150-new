using UnityEngine;
using System.Collections.Generic;

public class RandomSpawner : MonoBehaviour
{
    [Header("What to Spawn")]
    public GameObject[] prefabsToSpawn; // Put your blue Cat and Doughnut prefabs here

    [Header("Where to Spawn")]
    public Transform[] spawnLocations; // Put your Empties here

    [Header("How Many")]
    public int amountToSpawn = 5;

    void Start()
    {
        // Copy the array into a list so we can remove points as we use them
        List<Transform> availablePoints = new List<Transform>(spawnLocations);

        for (int i = 0; i < amountToSpawn; i++)
        {
            // Safety check in case you ask to spawn more items than you have points
            if (availablePoints.Count == 0) break; 

            // 1. Pick a random empty from the list
            int randomLocationIndex = Random.Range(0, availablePoints.Count);
            Transform chosenPoint = availablePoints[randomLocationIndex];

            // 2. Pick a random item (Cat or Doughnut)
            int randomItemIndex = Random.Range(0, prefabsToSpawn.Length);
            GameObject chosenItem = prefabsToSpawn[randomItemIndex];

            // 3. Spawn the item at the chosen empty's position
            Instantiate(chosenItem, chosenPoint.position, chosenPoint.rotation);

            // 4. Remove this point from the list so it can't be picked again
            availablePoints.RemoveAt(randomLocationIndex);
        }
    }
}
