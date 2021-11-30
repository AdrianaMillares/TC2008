using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estantes : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform prefab;
    void Start()    
    {   
        for (int i = 1; i < 5; i++)
        {
            Instantiate(prefab, new Vector3(prefab.position.x + (i*2.5f), 1.4f, -1.2f), transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
