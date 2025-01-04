using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destoryedVFX;
    [SerializeField] int hitPoints = 3;
    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        hitPoints--;

        if (hitPoints <= 0)
        {
            Instantiate(destoryedVFX, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
