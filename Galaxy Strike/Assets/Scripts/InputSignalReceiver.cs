using UnityEngine;

public class InputSignalReceiver : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public PlayerWeapon playerWeapon;
    public EnemyRespawn enemyRespawn2;
    public EnemyRespawn enemyRespawn3;

    public void EnableInput(){
        playerMovement.enabled = true;
        playerWeapon.enabled = true;   
    }

    public void EnableEnemy(){
        enemyRespawn2.enabled = true;
        enemyRespawn3.enabled = true;
    }
}
