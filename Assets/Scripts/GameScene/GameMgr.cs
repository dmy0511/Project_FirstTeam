using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMgr : MonoBehaviour
{
    GameObject player;

    public Text CurScore_Text;
    public Text BestScore_Text;

    float m_Score = 0.0f;  //현재높이
    public static float m_CurScore = 0.0f;    //현재 최고 높이
    public static float m_BestScore = 0.0f;    //최고 기록 높이

    // Start is called before the first frame update
    void Start()
    {
        Load();

        player = GameObject.Find("cat");
        m_CurScore = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //--- 점수 기록
        m_Score = player.transform.position.y;

        if (m_Score < 0.0f)
            m_Score = 0.0f;

        if (m_CurScore < m_Score)
            m_CurScore = m_Score;

        if (m_BestScore < m_CurScore)
        {
            m_BestScore = m_CurScore;
            Save();
        }

        if (CurScore_Text != null)
            CurScore_Text.text = "점수 : " + m_CurScore.ToString("N2");

        if (BestScore_Text != null)
            BestScore_Text.text = "최고점 : " + m_CurScore.ToString("N2");
        //--- 높이값 기록
    }

    public static void Save()
    {
        PlayerPrefs.SetFloat("HighScore", m_BestScore);
    }

    public static void Load()
    {
        m_BestScore = PlayerPrefs.GetFloat("HighScore", 0.0f);
    }
}
