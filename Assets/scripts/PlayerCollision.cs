
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMv mouvement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            mouvement.enabled = false;
            Debug.Log("You hit an " + collisionInfo.collider.name);
            FindAnyObjectByType<GameManager>().EndGame();

        }
    }
}
