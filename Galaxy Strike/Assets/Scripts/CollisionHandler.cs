using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject destoryedVFX;
    GameSceneManager gameSceneManager;
    private void Start() {
        gameSceneManager = FindAnyObjectByType<GameSceneManager>();
    }

    private void OnTriggerEnter(Collider other) {
        gameSceneManager.ReloadLevel();
        Instantiate(destoryedVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
