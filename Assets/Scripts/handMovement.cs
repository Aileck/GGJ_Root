using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < 0)
         transform.Translate(Vector2.right * Time.deltaTime * 2);
         else
          Destroy(this);
    }
}
