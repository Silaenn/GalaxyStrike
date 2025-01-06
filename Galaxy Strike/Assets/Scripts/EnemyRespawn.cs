using System.Collections;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float respawnZ = 849f;
    [SerializeField] float minX = 240f;
    [SerializeField] float maxX = 450f;
     [SerializeField] float minRespawnTime = 2f; 
    [SerializeField] float maxRespawnTime = 5f;

    private void Start() {
        StartCoroutine(RespawnRoutine());
    }

    void Respawn()
    {
        float randomX = Random.Range(minX, maxX);
        transform.position = new Vector3(randomX, transform.position.y, respawnZ);
    }

    IEnumerator RespawnRoutine()
    {
        while(true){
            float randomTime = Random.Range(minRespawnTime, maxRespawnTime);
            yield return new WaitForSeconds(randomTime);
            Instantiate(enemy, transform.position, Quaternion.identity);
            Respawn();
        }
    }


}
