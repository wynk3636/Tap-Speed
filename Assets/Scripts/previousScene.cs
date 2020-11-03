using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class previousScene : MonoBehaviour
{

    public static string sceneName = "";

    // Start is called before the first frame update
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
        Debug.Log("set " + sceneName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
