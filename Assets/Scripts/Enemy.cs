using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody body;
    private GameObject player;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        body.AddForce(lookDirection * speed);

        if (transform.position.y < -10.0f)
        {
            Destroy(gameObject);
        }
    }
}
