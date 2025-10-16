using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    float colliderTimer = 0.03f;
    float colliderDelay = 0.03f;
    //bool canSpawn = true;
    [SerializeField] Block block;

    private void Update()
    {
        //if (colliderCount == 0)
        //{
        //    Instantiate(block, transform.position, transform.rotation);
        //}
        if (colliderTimer <= 0)
        {
            Instantiate(block, transform.position, transform.rotation);
            colliderTimer = colliderDelay;
        }
        if (colliderTimer > 0) colliderTimer-= Time.deltaTime;
        transform.position = transform.position + Random.insideUnitSphere * 0.001f;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        colliderTimer = colliderDelay;
    }
}
