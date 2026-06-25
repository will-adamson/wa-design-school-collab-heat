using UnityEngine;

// Purpose: Destroys a breakable wall when the player enters its trigger zone while carrying a drill.

public class WallBreakController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (PlayerController.Instance.hasDrill == true)
            {
                Destroy(gameObject);
            }

            //Write code here for drilling prompt
        }

    }
}
