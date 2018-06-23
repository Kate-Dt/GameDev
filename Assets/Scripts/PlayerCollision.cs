using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

	void OnCollisionEnter(Collision collisionInfo)
    {
		if (collisionInfo.collider.tag == "Obstacle"||collisionInfo.collider.tag == "Sphere")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
			FindObjectOfType<AudioManager> ().Play("hit");
        }
    }
}
