using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackCtrl : MonoBehaviour
{
    GameObject player;
    float startY = 3.5f;   //백그라운드의 시작 y 높이 위치
    float scroll = 0.2f;    //백그라운드가 위로 올라가는 속도

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Cat");
    }

    // Update is called once per frame
    void Update()
    {
        float scrollPos = startY - player.transform.position.y * scroll;
        if (scrollPos > 12.0f)
            scrollPos = 12.0f;
        else if (scrollPos < -12.0f)
            scrollPos = -12.0f;

        transform.position = new Vector3(0.0f,
                                player.transform.position.y + scrollPos, 0.0f);
    }
}
