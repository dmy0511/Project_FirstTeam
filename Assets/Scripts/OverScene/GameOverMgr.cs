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
            highScoreText.text = "�ְ��� : " + GameMgr.m_BestHeight.ToString("N2");

        if (currentScoreText != null)
            currentScoreText.text = "���� : " + GameMgr.m_CurBHeight.ToString("N2");
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
        if (Input.GetKeyDown(KeyCode.K)) //ġƮŰ
        {
            PlayerPrefs.DeleteAll();    //���� �� ��� �ʱ�ȭ �ϱ�

            GameMgr.Load();

            if (highScoreText != null)
                highScoreText.text = "�ְ��� : " + GameMgr.m_BestHeight.ToString("N2");

            if (currentScoreText != null)
                currentScoreText.text = "�̹���� : " + GameMgr.m_CurBHeight.ToString("N2");
        }
        */
    }
}
