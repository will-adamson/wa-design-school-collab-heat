using UnityEngine;

// Author: Will
// Purpose: Displays the furnace UI canvas when the player enters the furnace trigger zone.
public class FuranceController : MonoBehaviour
{
    public GameObject canvas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.SetActive(true);
        } 
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        //AudioController.Instance.PlaySound("furnaceRoom");
    }
}
