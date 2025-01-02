using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] float controlSpeed = 10f;
    Vector2 movemnt;

    void Update()
    {
        ProcessTranslation();
    }

    public void OnMove(InputValue value){
        movemnt = value.Get<Vector2>();
    }

    private void ProcessTranslation()
    {
        float xOffset = movemnt.x * controlSpeed * Time.deltaTime;
        float yOffset = movemnt.y * controlSpeed * Time.deltaTime;
        transform.localPosition = new Vector3(transform.localPosition.x + xOffset, transform.localPosition.y + yOffset, 0f);
    }
}
