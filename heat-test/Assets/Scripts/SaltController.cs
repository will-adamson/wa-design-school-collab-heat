using UnityEngine;

// Purpose: Tracks and manages salt resources, destroying the object when depleted.

public class SaltController : MonoBehaviour
{
    [SerializeField] public float totalSalt;

    public static SaltController Instance;

    void Update()
    {
        if (totalSalt <= 0)
        {   
            AudioController.Instance.PlaySound("depleteOre");
            Debug.Log("0 Salt Left");
            Destroy(gameObject);
        }
    }

    void Salt()
    {
        //Player picks up coal
    }
}
