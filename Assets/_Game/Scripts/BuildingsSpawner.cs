using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] buildingsPrefabs;

    public GameObject currentBuilding;

    public void SpawnBuilding(int index)
    {
        if (currentBuilding != null)
        {
            Destroy(currentBuilding);
        }

        currentBuilding = Instantiate(buildingsPrefabs[index], transform.position, transform.rotation, transform);
    }
}
