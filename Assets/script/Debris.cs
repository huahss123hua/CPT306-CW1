using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 400 == 0)
        {
            float x = Mathf.Floor(transform.position.x);
            if (x % 2 != 0)
            {
                x++;
            }
            Vector3 pos = transform.position;
            pos.x = x;
            transform.position = pos;
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            ui.score += 5;
            ui.dh++;
            Spawner.barrier--;
        }
    }


}
