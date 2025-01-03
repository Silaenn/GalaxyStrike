using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnParticleCollision(GameObject other) {
        Destroy(this.gameObject);
    }
}
