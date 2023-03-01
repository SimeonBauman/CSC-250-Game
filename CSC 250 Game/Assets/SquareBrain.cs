using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareBrain : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        //transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y + 1, transform.rotation.z + 1, transform.rotation.w+1);
    }

    private void OnTriggerEnter(Collider other)
    {
        var m = other.GetComponent<GameController>();

        m.score++;
        this.transform.gameObject.SetActive(false);
    }
}
