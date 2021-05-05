using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform rightPoint, leftPoint;
    private bool faceLeft = true;
    private float leftx, rightx;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        leftx = leftPoint.position.x;
        rightx = rightPoint.position.x;
        //获取值后可以消除了
        Destroy(rightPoint.gameObject);
        Destroy(leftPoint.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (faceLeft)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            if (transform.position.x < leftx)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                faceLeft = false;
            }
        }

        else
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            if (transform.position.x > rightx)
            {
                transform.localScale = new Vector3(1, 1, 1);
                faceLeft = true;
            }
        }
    }
}
