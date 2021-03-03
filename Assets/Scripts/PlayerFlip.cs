using System.Collections;
using UnityEngine;

public class PlayerFlip : MonoBehaviour
{
    public Transform cursor;
    public float number;
    public bool facingRight = true;

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        if (mousePosition.x < transform.position.x && facingRight)
        {
            Flip();
        }
        else if (mousePosition.x > transform.position.x && !facingRight)
        {
            Flip();
        }

        Vector2 direction = new Vector2(
        mousePosition.x - transform.position.x,
        mousePosition.y - transform.position.y
        );

    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;

    }
}
