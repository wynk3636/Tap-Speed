using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{

    public static int[] value = new int[3];
    public int startCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        value = new int[]{ startCount,startCount,startCount};
    }

    // Update is called once per frame
    void Update()
    {

        if (this.name.Equals("Score"))
        {
            GetComponent<Text>().text = "Score:" + ScoreCount.value[0].ToString();
        }
        if (this.name.Equals("SumScore"))
        {
            GetComponent<Text>().text = "SumScore:" + ScoreCount.value[0].ToString();
        }
        if (this.name.Equals("leftScore"))
        {
            GetComponent<Text>().text = "leftScore:" + ScoreCount.value[1].ToString();
        }
        if (this.name.Equals("rightScore"))
        {
            GetComponent<Text>().text = "rightScore:" + ScoreCount.value[2].ToString();
        }
    }
}
