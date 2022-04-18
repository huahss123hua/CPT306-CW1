using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    Vector2 moveDir;
    public LayerMask layerMask;
    // Start is called before the first frame update
    void Start()
    {
        checkTwoNeighbour(Vector2.right);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.frameCount % 70 == 0)
        {
            float x = Mathf.Round(transform.position.x);
            Vector3 pos = transform.position;
            if(x%2 == 0)
            {
                pos.x = x;
            }
            else
            {
                pos.x = x + 1;
            }
            transform.position = pos;
        }

        Collection(Vector2.right);
        Collection(Vector2.up);

    }

    void Collection( Vector2 dir)
    {
        checkTwoNeighbour(dir);
    }


    bool checkTwoNeighbour(Vector2 dir)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, 2f, layerMask);
        if (checkNeighbour(dir) && hit.collider.GetComponent<Object>().checkNeighbour(dir))
        {
            Destroy(this.gameObject);
            Destroy(hit.collider.GetComponent<Object>().gameObject);
            Debug.Log(hit.collider.GetComponent<Object>().gameObject.transform.position);

            Vector3 pos = hit.collider.GetComponent<Object>().gameObject.transform.position;
            RaycastHit2D hit1 = Physics2D.Raycast(pos, dir, 2f, layerMask);
            Destroy(hit1.collider.GetComponent<Object>().gameObject);

            ui.score = ui.score + 10;
            ui.ipg++;
            if (this.CompareTag("IonisedParticleRed"))
            {
                ui.red++;
            }
            else if(this.CompareTag("IonisedParticleGreen"))
            {
                ui.green++;
            }
            else if (this.CompareTag("IonisedParticleBlue"))
            {
                ui.blue++;
            }


            return true;
        }
        else
        {
            return false;
        }
    }

    bool checkNeighbour(Vector2 dir)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, 2f, layerMask);
        if (!hit)
        {
            return false;
        }
        else if (hit.collider.tag == this.tag)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
