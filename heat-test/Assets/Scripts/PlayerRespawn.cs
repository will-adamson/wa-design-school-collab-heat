using UnityEngine;
using System.Collections;

// Author: Will
// Purpose: Periodically saves the player's position and respawns them there if they fall into a death pit.
public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private float checkInterval = 2f;
    [SerializeField] private float respawnDelay = 1f;

    private Vector3 lastSafePosition;
    private float timer;
    private CharacterController cc;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
        lastSafePosition = transform.position;
        timer = checkInterval;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            timer = checkInterval;
            lastSafePosition = transform.position;
        }
    }

    public void Respawn()
    {
        StartCoroutine(RespawnCoroutine());
    }

    private IEnumerator RespawnCoroutine()
    {
        //Slight delay on respawn, player cant move while falling
        cc.enabled = false;
        yield return new WaitForSeconds(respawnDelay);
        transform.position = lastSafePosition;
        cc.enabled = true;
    }
}