using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    [SerializeField] GameObject m_backPanel;
    [SerializeField] GameObject m_serchPanel;
    [SerializeField] GameObject m_isekiTipHirou;
    [SerializeField] GameObject m_isekiTipOku;
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
        m_diceAnim.enabled = true;
        m_diceAnim.Play(m_randomDaiceAnimName);
    }

    public void Serch()//完成
    {
        m_serchPanel.SetActive(true);
        if(m_playerManeger.Mass[m_playerManeger.PlayerMass[m_playerManeger.PlayerTurn]].transform.gameObject.tag == "None")
        {
            m_isekiTipOku.SetActive(true);
        }
        else
        {
            m_isekiTipHirou.SetActive(true);
        }
    }

    public void Nanimosinai()//完成
    {
        m_isekiTipOku.SetActive(false);
        m_isekiTipHirou.SetActive(false);
        m_serchPanel.SetActive(false);
        Air();
    }

    public void Isekitippuwohirou()
    {
        m_isekiTipOku.SetActive(false);
        m_isekiTipHirou.SetActive(false);
        m_serchPanel.SetActive(false);
        Air();
    }

    public void Isekitippuwooku()
    {
        m_isekiTipOku.SetActive(false);
        m_isekiTipHirou.SetActive(false);
        m_serchPanel.SetActive(false);
        Air();
    }

    void Hirou()
    {

    }

    void Oku()
    {

    }
}
