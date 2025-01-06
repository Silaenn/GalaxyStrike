using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float moveSpeed = 5f;


    private void Update() {
        MoveTowardsPlayer();
    }

    void MoveTowardsPlayer()
    {
        if (player != null) {
            Vector3 direction = (player.transform.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
    }
}
