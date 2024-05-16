using UnityEngine;

public class FollowMovingPlatform : MonoBehaviour
{
    private Transform platform;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MovingPlatform"))
        {
            platform = collision.transform;
            transform.parent = platform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MovingPlatform"))
        {
            transform.parent = null;
            platform = null;
        }
    }

    private void FixedUpdate()
    {
        if (platform != null)
        {
            Vector3 platformVelocity = platform.GetComponent<Rigidbody2D>().velocity;
            transform.position += platformVelocity * Time.fixedDeltaTime;
        }
    }
}
