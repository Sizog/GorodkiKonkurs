using UnityEngine;

public class PlayerExitFromCollider : MonoBehaviour
{
    public TeleportPointCanvas teleportPointCanvas;
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("PlayerExitFromCollider::OnTriggerExit(); -- other:" + other);
        if (other.gameObject.tag == "Player")
        {
            if (teleportPointCanvas != null)
            {
                teleportPointCanvas.TogglePanel(false);
            }
        }
    }
}
