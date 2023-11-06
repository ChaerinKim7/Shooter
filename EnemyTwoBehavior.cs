using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //-1 is horizontal  2 is speed of the enemy 
        transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * 4);
        if (transform.position.y < -7f)
        {
            Destroy(this.gameObject);
        }
    }
}
