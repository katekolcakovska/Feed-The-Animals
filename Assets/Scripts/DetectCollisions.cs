using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); //ova e onoj sto ja detektiral kolizijata - animal
        Destroy(other.gameObject); // onoj sto pravi kolizija - picata
    }
}
