using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet: MonoBehaviour
{
    public int bullet_damage = 10;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.SendMessage("Beshot", bullet_damage, SendMessageOptions.DontRequireReceiver);
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
