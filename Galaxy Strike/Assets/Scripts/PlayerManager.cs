using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance { get; private set; }
    public Transform PlayerTransform { get; private set; }

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            PlayerTransform = this.transform; 
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }
}

