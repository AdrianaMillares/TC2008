using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject box;
    Vector3 position = new Vector3(-1.90132f, -0.5630876f, 1.217f);

    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movement();
    }

    void movement()
    {
        if(transform.position == box.transform.position){
            Destroy(box);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, box.transform.position, Time.deltaTime * Random.Range(0.5f, 3.0f));
        }
    }
}
