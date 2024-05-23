using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FB_LineCtrl : MonoBehaviour
{
    GameObject player;
    float destroyDistance = 10.0f;  //주인공 아래쪽으로 10m

    public GameObject[] FootBoards;
    public GameObject Item_1;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Cat");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.transform.position;

        //일정 거리 아래 파괴
        if (transform.position.y < playerPos.y - destroyDistance)
            Destroy(gameObject);

        //GameObject : 클래스 이름(데이터형)
        //gameObject : 객체
    }

    public void SetHideFootBoard(int a_Count)
    {   //a_Count 몇개를 보이지 않게 할 건지 개수
        List<int> active = new List<int>();
        for (int ii = 0; ii < FootBoards.Length; ii++)
        {
            active.Add(ii);
        }

        for (int ii = 0; ii < a_Count; ii++)
        {
            int ran = Random.Range(0, active.Count);
            FootBoards[active[ran]].SetActive(false);

            active.RemoveAt(ran);
        }

        active.Clear();

        //--- 물고기 스폰 시키기...
        int range = 10; //10 분의 1 확률로 발판 위에 아이템 생성

        SpriteRenderer[] FB_Obj = GetComponentsInChildren<SpriteRenderer>();
        //Active가 활성화 되어 있는 구름 목록만 가져오는 방법
        for (int ii = 0; ii < FB_Obj.Length; ii++)
        {
            if (Random.Range(0, range) == 0)
                SpawnFish(FB_Obj[ii].transform.position);
        }
    }

    void SpawnFish(Vector3 a_Pos)
    {
        GameObject go = Instantiate(Item_1);
        go.SetActive(true);
        go.transform.position = a_Pos + Vector3.up * 0.8f;
    }
}
