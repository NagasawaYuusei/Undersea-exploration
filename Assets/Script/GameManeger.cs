using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    [SerializeField] GameObject m_backPanel;
    [SerializeField] GameObject m_serchPanel;
    [SerializeField] Animator m_shipAnim;
    [SerializeField] Animator m_diceAnim;
    [SerializeField] string m_shipAnimName;
    [SerializeField] string m_randomDaiceAnimName;
    [SerializeField] PlayerManeger m_playerManeger;

    public void GameStart()
    {
        Air();
    }

    public void Air()
    {
        if(m_playerManeger.PlayerNum > m_playerManeger.PlayerTurn)
        {
            m_playerManeger.PlayerTurn++;
        }
        else
        {
            m_playerManeger.PlayerTurn = 0;
        }
        m_shipAnim.Play(m_shipAnimName);
    }

    void Back()//シップアニメーションの途中で呼ぶ
    {
        m_backPanel.SetActive(true);
    }

    public void Go()
    {
        m_diceAnim.Play(m_randomDaiceAnimName);
    }

    void Serch()//完成
    {
        m_serchPanel.SetActive(true);
    }

    public void Nanimosinai()//完成
    {
        m_serchPanel.SetActive(false);
        Air();
    }

    public void Isekitippuwohirou()
    {
        m_serchPanel.SetActive(false);
        Air();
    }

    public void Isekitippuwooku()
    {
        m_serchPanel.SetActive(false);
        Air();
    }
}
