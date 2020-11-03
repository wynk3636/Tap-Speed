using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (this.name.Equals("scoreSum"))
        {
            GetComponent<Text>().text = "Your sum score is " + ScoreCount.value[0].ToString();
        }
        if (this.name.Equals("scoreLeft") && previousScene.sceneName == "doubleTapGame")
        {
            GetComponent<Text>().text = "Your left score is " + ScoreCount.value[1].ToString();
        }
        if (this.name.Equals("scoreRight") && previousScene.sceneName == "doubleTapGame")
        {
            GetComponent<Text>().text = "Your right score is " + ScoreCount.value[2].ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
