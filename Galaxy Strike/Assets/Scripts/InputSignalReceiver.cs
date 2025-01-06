using UnityEngine;

public class InputSignalReceiver : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public PlayerWeapon playerWeapon;

    public void EnableInput(){
        playerMovement.enabled = true;
        playerWeapon.enabled = true;
    }
}
