using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public int score = 0;
    public GameObject cube;
    public Text scoreText;
    public GameObject winText;
    public int num = 40;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        drawSquares(num, 12);
        winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        scoreText.text = score.ToString();
        if(score >= num)
        {
            winText.SetActive(true);
            Time.timeScale = 0;
        }
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
