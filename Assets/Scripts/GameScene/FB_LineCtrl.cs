using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FB_LineCtrl : MonoBehaviour
{
    GameObject player;
    float destroyDistance = 10.0f;  //���ΰ� �Ʒ������� 10m

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

        //���� �Ÿ� �Ʒ� �ı�
        if (transform.position.y < playerPos.y - destroyDistance)
            Destroy(gameObject);

        //GameObject : Ŭ���� �̸�(��������)
        //gameObject : ��ü
    }

    public void SetHideFootBoard(int a_Count)
    {   //a_Count ��� ������ �ʰ� �� ���� ����
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

        //--- ����� ���� ��Ű��...
        int range = 10; //10 ���� 1 Ȯ���� ���� ���� ������ ����

        SpriteRenderer[] FB_Obj = GetComponentsInChildren<SpriteRenderer>();
        //Active�� Ȱ��ȭ �Ǿ� �ִ� ���� ��ϸ� �������� ���
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
