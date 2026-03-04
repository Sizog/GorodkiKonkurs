using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPointCanvas : MonoBehaviour
{
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private BuildingsSpawner buildingsSpawner;

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
}
