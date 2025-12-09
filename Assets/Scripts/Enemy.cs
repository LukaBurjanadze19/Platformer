using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Direction = Player.position - transform.position;
        transform.position += Direction.normalized * speed * Time.deltaTime;
    }
}
