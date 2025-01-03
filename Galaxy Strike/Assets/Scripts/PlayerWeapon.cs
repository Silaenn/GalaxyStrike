using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] GameObject[] lasers;
    [SerializeField] RectTransform crosshair;
    [SerializeField] Transform targetPoint;
    [SerializeField] float targetDistance = 100f;
    bool isFiring = false;
    private void Start() {
        Cursor.visible = false;
    }
    private void Update() {
        ProcessFiring();
        MoveCrosshair();
        MoveTargetPoint();
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

    void MoveCrosshair(){
        crosshair.position = Input.mousePosition;
    }

    void MoveTargetPoint(){
        Vector3 targetPointPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, targetDistance);
        targetPoint.position = Camera.main.ScreenToWorldPoint(targetPointPosition);
    }
}
