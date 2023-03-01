using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareBrain : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        var m = other.GetComponent<GameController>();

        m.score++;
        this.transform.gameObject.SetActive(false);
    }
}
