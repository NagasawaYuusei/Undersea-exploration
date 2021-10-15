using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    [SerializeField] GameObject m_back;
    [SerializeField] GameObject m_SerchPanel;
    [SerializeField] Animator m_daiceAnim;
    [SerializeField] string m_randomDaiceAnimName;

    void Air()
    {
        
    }

    void Back()
    {
        
    }

    void Go()
    {
        m_daiceAnim.Play(m_randomDaiceAnimName);
    }

    void Serch()//完成
    {
        m_SerchPanel.SetActive(true);
    }

    public void Yes()
    {
        Go();
    }

    public void No()//完成
    {
        Go();
    }

    public void Nanimosinai()//完成
    {
        m_SerchPanel.SetActive(false);
        Air();
    }

    public void Isekitippuwohirou()
    {
        m_SerchPanel.SetActive(false);
        Air();
    }

    public void Isekitippuwooku()
    {
        m_SerchPanel.SetActive(false);
        Air();
    }
}
