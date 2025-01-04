using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destoryedVFX;
    [SerializeField] int hitPoints = 3;
    [SerializeField] int scoreValue = 10;
    Scoreboard scoreboard;
    private void Start() {
        scoreboard = FindAnyObjectByType<Scoreboard>();
    }
    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        hitPoints--;

        if (hitPoints <= 0)
        {
            scoreboard.IncreaseScore(scoreValue);
            Instantiate(destoryedVFX, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
