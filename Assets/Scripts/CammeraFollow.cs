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
        //CammeraFollowToPlayer();
    }

    private void CammeraFollowToPlayer()
    {
        transform.position += player.position + directionToPlayer;
    }
}