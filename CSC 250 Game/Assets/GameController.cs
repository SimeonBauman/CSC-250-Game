using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int score = 0;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        drawSquares(12, 12);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
    }

    void drawSquares(int Num, int radius)
    {
        float ang = 360 / Num;
        Debug.Log(ang);
        for (int i = 0; i < Num; i++)
        {
            float x = radius * (Mathf.Cos((ang * i) * Mathf.Deg2Rad));
            float z = radius * (Mathf.Sin((ang * i) * Mathf.Deg2Rad));
            Instantiate(cube, new Vector3(x, 1.5f, z),new Quaternion(0,0,0,0));
        }
    }
}
