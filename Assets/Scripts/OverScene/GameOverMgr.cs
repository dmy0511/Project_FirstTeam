using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverMgr : MonoBehaviour
{
    public Text bestScoreText;
    public Text currentScoreText;
    public Button replayBtn;

    void Start()
    {
        /**
        if (GameMgr.m_BestHeight < GameMgr.m_CurBHeight)
        {
            GameMgr.m_BestHeight = GameMgr.m_CurBHeight;
            GameMgr.Save();
        }

        if (highScoreText != null)
            highScoreText.text = "최고점 : " + GameMgr.m_BestHeight.ToString("N2");

        if (currentScoreText != null)
            currentScoreText.text = "점수 : " + GameMgr.m_CurBHeight.ToString("N2");
        */

        if (replayBtn != null)
        {
            replayBtn.onClick.AddListener(() =>
            {
                SceneManager.LoadScene("GameScene");
            });
        }
    }

    void Update()
    {
        /**
        if (Input.GetKeyDown(KeyCode.K)) //치트키
        {
            PlayerPrefs.DeleteAll();    //저장 값 모두 초기화 하기

            GameMgr.Load();

            if (highScoreText != null)
                highScoreText.text = "최고기록 : " + GameMgr.m_BestHeight.ToString("N2");

            if (currentScoreText != null)
                currentScoreText.text = "이번기록 : " + GameMgr.m_CurBHeight.ToString("N2");
        }
        */
    }
}
