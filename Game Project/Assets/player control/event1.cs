using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event1 : MonoBehaviour
{
    public Rigidbody2D m_toge;
    public float speed = 10f;
    private void OnTriggerEnter2D(Collider2D other)
    {
       if(other.tag=="Player")
        {
                Vector2 v = new Vector2(0, speed);
                m_toge.velocity = v;
                Destroy(gameObject);   
        }
    }
}
