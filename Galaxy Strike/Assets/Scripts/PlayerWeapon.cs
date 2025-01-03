using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] GameObject laser;
    bool isFiring = false;
    private void Update() {
        ProcessFiring();
    }
    public void OnFire(InputValue value){
        isFiring = value.isPressed;
    }

    void ProcessFiring(){
       var emmissionModule = laser.GetComponent<ParticleSystem>().emission;
       emmissionModule.enabled = isFiring;
    }
}
