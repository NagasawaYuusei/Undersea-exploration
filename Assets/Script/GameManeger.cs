using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class GameManeger : MonoBehaviour
{
    [SerializeField] GameObject m_backPanel;
    [SerializeField] GameObject m_serchPanel;
    [SerializeField] GameObject m_isekiTipHirou;
    [SerializeField] GameObject m_isekiTipOku;
    [SerializeField] GameObject m_nonePanel;
    [SerializeField] GameObject[] m_nonePotisions;
    [SerializeField] GameObject m_roundOverText;
    [SerializeField] Text m_nextRoundText;
    [SerializeField] Animator m_shipAnim;
    [SerializeField] Animator m_diceAnim;
    [SerializeField] string m_shipAnimName;
    [SerializeField] string m_randomDaiceAnimName;
    [SerializeField] PlayerManeger m_playerManeger;
    [SerializeField] ShipManeger m_shipManager;
    [SerializeField] RemainsManeger m_remainsManager;
    [SerializeField] GameObject m_none;
    bool m_roundEnd;
    int m_roundCount = 1;


    public void GameStart()
    {
        m_remainsManager.SetBoard();
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

        m_playerManeger.ShipAir();
        if(m_playerManeger.ShipInAir >= 25)
        {
            m_roundEnd = true;
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
        if(!m_roundEnd)
        {
            Air();
        }

    }

    public void Isekitippuwohirou()
    {
        Hirou();
        m_isekiTipOku.SetActive(false);
        m_isekiTipHirou.SetActive(false);
        m_serchPanel.SetActive(false);
        if (!m_roundEnd)
        {
            Air();
        }
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
        var remains = m_nonePotisions[0];

        GameObject[] childObject = new GameObject[remains.transform.childCount];

        m_playerManeger.m_playerGetRemains1.RemoveAt(0);

        for (int i = 0; i < remains.transform.childCount; i++)
        {
            childObject[i] = remains.transform.GetChild(i).gameObject;
        }

        Destroy(m_playerManeger.Mass[m_playerManeger.PlayerMass[m_playerManeger.PlayerTurn]].transform.parent);
        foreach (var g in childObject)
            Instantiate(g, m_playerManeger.Mass[m_playerManeger.PlayerMass[m_playerManeger.PlayerTurn]].transform);
        m_playerManeger.PlayerGet[m_playerManeger.PlayerTurn]--;
        for(int i = 0; i < m_nonePotisions.Length; i++)
        {
            Destroy(m_nonePotisions[i].transform.parent);
            m_nonePotisions[i].SetActive(false);
        }
        m_nonePanel.SetActive(false);
        if (!m_roundEnd)
        {
            Air();
        }
    }

    public void Two()
    {
        var remains = m_nonePotisions[1];

        GameObject[] childObject = new GameObject[remains.transform.childCount];

        m_playerManeger.m_playerGetRemains1.RemoveAt(1);

        for (int i = 0; i < remains.transform.childCount; i++)
        {
            childObject[i] = remains.transform.GetChild(i).gameObject;
        }

        Destroy(m_playerManeger.Mass[m_playerManeger.PlayerMass[m_playerManeger.PlayerTurn]].transform.parent);
        foreach (var g in childObject)
            Instantiate(g, m_playerManeger.Mass[m_playerManeger.PlayerMass[m_playerManeger.PlayerTurn]].transform);
        m_playerManeger.PlayerGet[m_playerManeger.PlayerTurn]--;
        for (int i = 0; i < m_nonePotisions.Length; i++)
        {
            Destroy(m_nonePotisions[i].transform.parent);
            m_nonePotisions[i].SetActive(false);
        }
        m_nonePanel.SetActive(false);
        if (!m_roundEnd)
        {
            Air();
        }
    }

    public void Three()
    {
        var remains = m_nonePotisions[2];

        GameObject[] childObject = new GameObject[remains.transform.childCount];

        m_playerManeger.m_playerGetRemains1.RemoveAt(2);

        for (int i = 0; i < remains.transform.childCount; i++)
        {
            childObject[i] = remains.transform.GetChild(i).gameObject;
        }

        Destroy(m_playerManeger.Mass[m_playerManeger.PlayerMass[m_playerManeger.PlayerTurn]].transform.parent);
        foreach (var g in childObject)
            Instantiate(g, m_playerManeger.Mass[m_playerManeger.PlayerMass[m_playerManeger.PlayerTurn]].transform);
        m_playerManeger.PlayerGet[m_playerManeger.PlayerTurn]--;
        for (int i = 0; i < m_nonePotisions.Length; i++)
        {
            Destroy(m_nonePotisions[i].transform.parent);
            m_nonePotisions[i].SetActive(false);
        }
        m_nonePanel.SetActive(false);
        if (!m_roundEnd)
        {
            Air();
        }
    }

    public void Four()
    {
        var remains = m_nonePotisions[3];

        GameObject[] childObject = new GameObject[remains.transform.childCount];

        m_playerManeger.m_playerGetRemains1.RemoveAt(3);

        for (int i = 0; i < remains.transform.childCount; i++)
        {
            childObject[i] = remains.transform.GetChild(i).gameObject;
        }

        Destroy(m_playerManeger.Mass[m_playerManeger.PlayerMass[m_playerManeger.PlayerTurn]].transform.parent);
        foreach (var g in childObject)
            Instantiate(g, m_playerManeger.Mass[m_playerManeger.PlayerMass[m_playerManeger.PlayerTurn]].transform);
        m_playerManeger.PlayerGet[m_playerManeger.PlayerTurn]--;
        for (int i = 0; i < m_nonePotisions.Length; i++)
        {
            Destroy(m_nonePotisions[i].transform.parent);
            m_nonePotisions[i].SetActive(false);
        }
        m_nonePanel.SetActive(false);
        if (!m_roundEnd)
        {
            Air();
        }
    }

    public void Five()
    {
        var remains = m_nonePotisions[4];

        GameObject[] childObject = new GameObject[remains.transform.childCount];

        m_playerManeger.m_playerGetRemains1.RemoveAt(4);

        for (int i = 0; i < remains.transform.childCount; i++)
        {
            childObject[i] = remains.transform.GetChild(i).gameObject;
        }

        Destroy(m_playerManeger.Mass[m_playerManeger.PlayerMass[m_playerManeger.PlayerTurn]].transform.parent);
        foreach (var g in childObject)
            Instantiate(g, m_playerManeger.Mass[m_playerManeger.PlayerMass[m_playerManeger.PlayerTurn]].transform);
        m_playerManeger.PlayerGet[m_playerManeger.PlayerTurn]--;
        for (int i = 0; i < m_nonePotisions.Length; i++)
        {
            Destroy(m_nonePotisions[i].transform.parent);
            m_nonePotisions[i].SetActive(false);
        }
        m_nonePanel.SetActive(false);
        if (!m_roundEnd)
        {
            Air();
        }
    }

    public void Six()
    {
        var remains = m_nonePotisions[5];

        GameObject[] childObject = new GameObject[remains.transform.childCount];

        m_playerManeger.m_playerGetRemains1.RemoveAt(5);

        for (int i = 0; i < remains.transform.childCount; i++)
        {
            childObject[i] = remains.transform.GetChild(i).gameObject;
        }

        Destroy(m_playerManeger.Mass[m_playerManeger.PlayerMass[m_playerManeger.PlayerTurn]].transform.parent);
        foreach (var g in childObject)
            Instantiate(g, m_playerManeger.Mass[m_playerManeger.PlayerMass[m_playerManeger.PlayerTurn]].transform);
        m_playerManeger.PlayerGet[m_playerManeger.PlayerTurn]--;
        for (int i = 0; i < m_nonePotisions.Length; i++)
        {
            Destroy(m_nonePotisions[i].transform.parent);
            m_nonePotisions[i].SetActive(false);
        }
        m_nonePanel.SetActive(false);
        if (!m_roundEnd)
        {
            Air();
        }
    }

    void RoundOver()
    {
        m_roundOverText.SetActive(true);
        if(m_roundCount < 3)
        {
            m_roundCount++;
            m_nextRoundText.text = "Next Round " + m_roundCount;

            var remains = m_playerManeger.Mass[0];

            GameObject[] childObject = new GameObject[remains.transform.childCount];//勝ったプレイヤーのオブジェクト

            for (int i = 0; i < remains.transform.childCount; i++)
            {
                childObject[i] = remains.transform.GetChild(i).gameObject;
            }

            var list = new List<GameObject>();
            list.AddRange(childObject);
            string item = "Osaka";

            if (list.Contains(item))
            {
                Console.WriteLine("{0}が見つかりました", item);
            }
            else
            {
                Console.WriteLine("{0}は見つかりませんでした", item);
            }

            Console.ReadKey();
        }
        else
        {
            m_nextRoundText.text = "Next Result " + m_roundCount;
        }
    }
}
