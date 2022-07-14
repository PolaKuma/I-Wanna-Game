using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event2 : MonoBehaviour
{
    public Rigidbody2D m_toge;
    public float speed = 1f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Vector2 v = new Vector2(speed, 0);
            m_toge.velocity = v;
            Destroy(gameObject);
        }
    }
}
