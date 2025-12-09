using UnityEngine;

public class CammeraFollow : MonoBehaviour
{
    [SerializeField] Transform player;
    private Vector3 directionToPlayer;
    private void Start()
    {
        
    }
    private void LateUpdate()
    {
        transform.position = player.position + new Vector3(0, 0, -10);
       
    }
}