using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCtrl : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Cat");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < player.transform.position.y - 10.0f)
            Destroy(gameObject);
    }
}
