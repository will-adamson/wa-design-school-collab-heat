using UnityEngine;
using System.Collections;

//Track the players position while standing on the ground so when they die from a deathpit, they just respawn at the top

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