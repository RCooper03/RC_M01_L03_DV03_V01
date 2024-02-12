using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammoBehaviour : MonoBehaviour
{
    // 1
    private void OnCollisionEnter(Collision collision)
    {
        // 2
        if(collision.gameObject.name == "Player")
        {
            // 3
            Destroy(this.transform.parent.gameObject);

            // 4
            Debug.Log("You picked up ammo.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
