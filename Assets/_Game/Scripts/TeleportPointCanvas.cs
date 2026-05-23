using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportPointCanvas : MonoBehaviour
{
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private BuildingsSpawner buildingsSpawner;
    [SerializeField] private GameObject spawnBatCapsule;
    [SerializeField] private GameObject spawnBatPoint;
    private GameObject currentBatCapsule;
    [SerializeField] private InputActionReference[] onSpawnBatCapsule;

    void Start()
    {
        if (buildingsSpawner == null) FindObjectOfType<BuildingsSpawner>();
        foreach (var action in onSpawnBatCapsule)
        {
            if (action.action != null)
            {
                action.action.performed += (InputAction.CallbackContext callbackContext) => SpawnBatCapsule();
            }
        }
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
