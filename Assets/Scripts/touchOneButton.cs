using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchOneButton : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //スマホのタッチ
        /*
        if (Input.GetMouseButtonDown(0))
        {
            var wPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var hit = Physics2D.Raycast(wPos, Vector2.zero);
            if (hit)
            {
                if (hit.collider.gameObject.name == this.name)
                {
                    addScore();
                }
            }
        }
        */

        //長押しタップをしていた場合に他のボタンを押しても処理が行われない
        if (Input.touchCount > 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Touch[] myTouches = Input.touches;

            for (int i = 1; i < myTouches.Length; i++)
            {
                addScore();
            }
        }

        //タップが静止していてもカウントできるように
        /*
        if(Input.touchCount > 1)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                addScore();
                return;
            }
            if (Input.GetTouch(1).phase == TouchPhase.Began)
            {
                addScore();
                return;
            }
        }
        */
    }

    //PCでのクリック
    //スマホタッチも吸収
    private void OnMouseDown()
    {
        addScore();
    }

    private void addScore()
    {
        Debug.Log(this.name);
        if (this.name.Equals("Button"))
        {
            ScoreCount.value[0]++;
        }
        else if (this.name.Equals("leftButton"))
        {
            ScoreCount.value[1]++;
            ScoreCount.value[0]++;
        }
        else if (this.name.Equals("rightButton"))
        {
            ScoreCount.value[2]++;
            ScoreCount.value[0]++;
        }
    }
}
