using System.Collections;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float respawnZ = 849f;
    [SerializeField] float minX = 240f;
    [SerializeField] float maxX = 450f;
    [SerializeField] float minY = -4f;
    [SerializeField] float maxY = -75f;
     [SerializeField] float minRespawnTime = 2f; 
    [SerializeField] float maxRespawnTime = 5f;

    private void Start() {
        Respawn();
        StartCoroutine(RespawnRoutine());
    }

    void Respawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        transform.position = new Vector3(randomX, randomY, respawnZ);
        Instantiate(enemy, transform.position, Quaternion.identity);

    }

    IEnumerator RespawnRoutine()
    {
        while(true){
            float randomTime = Random.Range(minRespawnTime, maxRespawnTime);
            yield return new WaitForSeconds(randomTime);
            Respawn();
        }
    }


}
