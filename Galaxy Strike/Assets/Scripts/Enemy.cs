using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destoryedVFX;
    private void OnParticleCollision(GameObject other) {
        Instantiate(destoryedVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
