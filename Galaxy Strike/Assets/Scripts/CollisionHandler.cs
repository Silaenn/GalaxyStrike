using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject destoryedVFX;

    private void OnTriggerEnter(Collider other) {
        Instantiate(destoryedVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
