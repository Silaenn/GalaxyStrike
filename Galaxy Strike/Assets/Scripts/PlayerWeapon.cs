using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] GameObject[] lasers;
    bool isFiring = false;
    private void Update() {
        ProcessFiring();
    }
    public void OnFire(InputValue value){
        isFiring = value.isPressed;
    }

    void ProcessFiring(){
      foreach(GameObject laser in lasers) {
           var emmissionModule = laser.GetComponent<ParticleSystem>().emission;
           emmissionModule.enabled = isFiring;
      } 
    }
}
