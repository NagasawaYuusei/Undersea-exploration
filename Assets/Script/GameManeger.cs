using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    [SerializeField] GameObject m_backPanel;
    [SerializeField] GameObject m_dicePanel;
    [SerializeField] Animator m_daiceAnim;
    [SerializeField] string m_randomDaiceAnimName;
    [SerializeField] bool m_backOn;

    [SerializeField] ShipManeger m_shipManeger;
    [SerializeField] PlayerManeger m_playerManeger;

    public void Player2()
    {
        m_playerManeger.PlayerNum = 2;
        m_playerManeger.IsBack = new bool[2];
        Air();
    }

    public void Player3()
    {
        m_playerManeger.PlayerNum = 3;
        m_playerManeger.IsBack = new bool[3];
        Air();
    }

    public void Player4()
    {
        m_playerManeger.PlayerNum = 4;
        m_playerManeger.IsBack = new bool[4];
        Air();
    }

    public void Player5()
    {
        m_playerManeger.PlayerNum = 5;
        m_playerManeger.IsBack = new bool[5];
        Air();
    }

    public void Player6()
    {
        m_playerManeger.PlayerNum = 6;
        m_playerManeger.IsBack = new bool[6];
        Air();
    }

    void Air()
    {
        m_shipManeger.NowShip();
        //アニメーションイベントで途中Back()を呼ぶ
    }

    void Back()
    {
        m_backPanel.SetActive(true);
    }

    public void Go()
    {
        m_daiceAnim.Play(m_randomDaiceAnimName);
    }

    void Serch()//完成
    {
        m_dicePanel.SetActive(true);
    }
}
