using UnityEngine;

// Author: Will
// Purpose: Triggers player respawn when the player falls into a death pit.

public class DeathPitController : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerRespawn respawn = collision.GetComponent<PlayerRespawn>();
            if (respawn != null)
                respawn.Respawn();
        }
    }
}