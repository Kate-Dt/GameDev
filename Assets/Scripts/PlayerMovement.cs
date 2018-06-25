using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement current;

    public Rigidbody rigidbody;
    public float forwardForce = 1f;
    public float sidewayForce = 1f;
	// Use this for initialization
	void Start ()
	{
	    current = this;
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rigidbody.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rigidbody.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rigidbody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
