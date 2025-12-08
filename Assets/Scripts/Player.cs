using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, vertical, 0).normalized;
        transform.position += movement * speed;
    }
}