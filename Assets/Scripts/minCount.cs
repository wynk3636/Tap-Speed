using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class minCount : MonoBehaviour
{

    public float span = 3f;
    private float currentTime = 0f;
    public string sceneName;

    //public string showObjectName;
    //GameObject showObject;

    // Start is called before the first frame update
    void Start()
    {
        //showObject = GameObject.Find(showObjectName);
        //showObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > span)
        {
            GameCounter.value--;

            if (GameCounter.value == 0)
            {
                //GetComponent<Text>().text = "Finish!";
                SceneManager.LoadScene(sceneName);
            }
            else
            {
                GetComponent<Text>().text = "Limit:" + GameCounter.value.ToString() + "min";
            }
            currentTime = 0f;
        }
    }
}
