using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public PlayerMv mouvement;
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        if (mouvement.enabled == false)
        {
            scoreText.text = "You hit an obstacle";
        }
        if (mouvement.rb.position.y < -1f)
        {
            scoreText.text = "You fell";
        }
    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            mouvement.enabled = false;
        }
    }
}
