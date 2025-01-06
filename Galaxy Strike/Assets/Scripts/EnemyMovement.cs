using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float stoppingDistance = 5f; 

    private void Awake() {
        player = PlayerManager.Instance.PlayerTransform;
    }

    private void Update() {
        MoveTowardsPlayer();
    }

    void MoveTowardsPlayer()
    {
        if (player != null) {
            Vector3 direction = (player.position - transform.position).normalized;

            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * moveSpeed);

            float distance = Vector3.Distance(transform.position, player.position);
            if (distance > stoppingDistance) {
                transform.position += direction * moveSpeed * Time.deltaTime;
            }
        }
    }
}
