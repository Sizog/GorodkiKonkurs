using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPointCanvas : MonoBehaviour
{
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private BuildingsSpawner buildingsSpawner;
    [SerializeField] private GameObject spawnBatCapsule;
    [SerializeField] private GameObject spawnBatPoint;
    [SerializeField] private GameObject currentBatCapsule;

    void Start()
    {
        if (buildingsSpawner == null) FindObjectOfType<BuildingsSpawner>();
    }

    public void TogglePanel(bool isOpen)
    {
        mainPanel.SetActive(isOpen);
    }

    public void SpawnBuilding(int index)
    {
        buildingsSpawner.SpawnBuilding(index);
        mainPanel.SetActive(false);
    }

    public void SpawnBatCapsule()
    {
        if (spawnBatCapsule != null && spawnBatPoint != null)
        {
            if (currentBatCapsule != null)
            {
                Destroy(currentBatCapsule);
            }
            currentBatCapsule = Instantiate(spawnBatCapsule, spawnBatPoint.transform.position, spawnBatPoint.transform.rotation);
        }
    }
}
