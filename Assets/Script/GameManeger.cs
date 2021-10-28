using UnityEngine;

public class GameManeger : MonoBehaviour
{
    [SerializeField] GameObject m_backPanel;
    [SerializeField] GameObject m_serchPanel;
    [SerializeField] GameObject m_isekiTipHirou;
    [SerializeField] GameObject m_isekiTipOku;
    [SerializeField] GameObject m_nonePanel;
    [SerializeField] GameObject[] m_nonePotisions;
    [SerializeField] Animator m_shipAnim;
    [SerializeField] Animator m_diceAnim;
    [SerializeField] string m_shipAnimName;
    [SerializeField] string m_randomDaiceAnimName;
    [SerializeField] PlayerManeger m_playerManeger;
    [SerializeField] GameObject m_none;


    public void GameStart()
    {
        Air();
    }

    public void Air()
    {
        if (m_playerManeger.PlayerNum > m_playerManeger.PlayerTurn)
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
        if (m_playerManeger.Mass[m_playerManeger.PlayerMass[m_playerManeger.PlayerTurn]].transform.gameObject.tag == "None")
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
        Hirou();
        m_isekiTipOku.SetActive(false);
        m_isekiTipHirou.SetActive(false);
        m_serchPanel.SetActive(false);
        Air();
    }

    public void Isekitippuwooku()
    {
        Oku();
        m_isekiTipOku.SetActive(false);
        m_isekiTipHirou.SetActive(false);
        m_serchPanel.SetActive(false);
    }

    void Hirou()
    {
        var remains = m_playerManeger.Mass[m_playerManeger.PlayerMass[m_playerManeger.PlayerTurn]];

        GameObject[] childObject = new GameObject[remains.transform.childCount];

        for (int i = 0; i < remains.transform.childCount; i++)
        {
            childObject[i] = remains.transform.GetChild(i).gameObject;
        }

        m_playerManeger.PlayerGet[m_playerManeger.PlayerTurn]++;

        if (m_playerManeger.PlayerTurn == 0)
            m_playerManeger.m_playerGetRemains0.Add(childObject);
        else if (m_playerManeger.PlayerTurn == 1)
            m_playerManeger.m_playerGetRemains1.Add(childObject);
        else if (m_playerManeger.PlayerTurn == 2)
            m_playerManeger.m_playerGetRemains2.Add(childObject);
        else if (m_playerManeger.PlayerTurn == 3)
            m_playerManeger.m_playerGetRemains3.Add(childObject);
        else if (m_playerManeger.PlayerTurn == 4)
            m_playerManeger.m_playerGetRemains4.Add(childObject);
        else
            m_playerManeger.m_playerGetRemains5.Add(childObject);

        foreach (var g in childObject)
            Destroy(g);

        Instantiate(m_none, remains.transform);
    }

    void Oku()
    {
        m_nonePanel.SetActive(true);
        if (m_playerManeger.PlayerTurn == 0)
        {
            for(int i = 0; i < m_playerManeger.m_playerGetRemains0.Count; i++)
            {
                m_nonePotisions[i].SetActive(true);
                foreach (var g in m_playerManeger.m_playerGetRemains0[i])
                    Instantiate(g , m_nonePotisions[i].transform);
            }
        }
        else if (m_playerManeger.PlayerTurn == 1)
        {
            for (int i = 0; i < m_playerManeger.m_playerGetRemains1.Count; i++)
            {
                m_nonePotisions[i].SetActive(true);
                foreach (var g in m_playerManeger.m_playerGetRemains1[i])
                    Instantiate(g, m_nonePotisions[i].transform);
            }
        }
        else if (m_playerManeger.PlayerTurn == 2)
        {
            for (int i = 0; i < m_playerManeger.m_playerGetRemains2.Count; i++)
            {
                m_nonePotisions[i].SetActive(true);
                foreach (var g in m_playerManeger.m_playerGetRemains2[i])
                    Instantiate(g, m_nonePotisions[i].transform);
            }
        }
        else if (m_playerManeger.PlayerTurn == 3)
        {
            for (int i = 0; i < m_playerManeger.m_playerGetRemains3.Count; i++)
            {
                m_nonePotisions[i].SetActive(true);
                foreach (var g in m_playerManeger.m_playerGetRemains3[i])
                    Instantiate(g, m_nonePotisions[i].transform);
            }
        }
        else if (m_playerManeger.PlayerTurn == 4)
        {
            for (int i = 0; i < m_playerManeger.m_playerGetRemains4.Count; i++)
            {
                m_nonePotisions[i].SetActive(true);
                foreach (var g in m_playerManeger.m_playerGetRemains4[i])
                    Instantiate(g, m_nonePotisions[i].transform);
            }
        }
        else
        {
            for (int i = 0; i < m_playerManeger.m_playerGetRemains5.Count; i++)
            {
                m_nonePotisions[i].SetActive(true);
                foreach (var g in m_playerManeger.m_playerGetRemains5[i])
                    Instantiate(g, m_nonePotisions[i].transform);
            }
        }
    }

    public void One()
    {

    }

    public void Two()
    {

    }

    public void Three()
    {

    }

    public void Four()
    {

    }

    public void Five()
    {

    }

    public void Six()
    {

    }
}
