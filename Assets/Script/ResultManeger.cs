using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class ResultManeger : MonoBehaviour
{

<<<<<<< HEAD
    int[] m_sankakuGetRemains = new int[] { 2, 3, 1, 1, 1, 0 };
    int[] m_sikakuGetRemains = new int[] { 0, 0, 0, 1, 6, 1 };
    int[] m_gokakuGetRemains = new int[] { 2 };
    int[] m_rokukakuGetRemains = new int[] { 2 };
=======
    //渡していただくもの
    [SerializeField]int m_playerNum = 6;//プレイヤーの人数(m_playerCountとは異なります)　　　　　　　　　　
    int[] m_sankakuGetRemains = new int[] { 2, 3, 1, 1, 1, 0 };
    int[] m_sikakuGetRemains = new int[] { 0, 0, 1, 1, 5, 1 };
    int[] m_gokakuGetRemains = new int[] { 2, 3, 2, 1, 0, 0 };
    int[] m_rokukakuGetRemains = new int[] { 2, 2, 1, 1, 1, 1 };
    //ここまでの情報をください！
>>>>>>> 7df3bb978efe0f8f6bd506cba98583996435b714

    [SerializeField] TextMeshProUGUI m_scoreText;
    [SerializeField] TextMeshProUGUI m_toPlayer2Text;
    [SerializeField] TextMeshProUGUI m_toPlayer3Text;
    [SerializeField] TextMeshProUGUI m_toPlayer4Text;
    [SerializeField] TextMeshProUGUI m_toPlayer5Text;
    [SerializeField] TextMeshProUGUI m_toPlayer6Text;
    [SerializeField] UnityEvent m_finishResultEvent;
    [SerializeField] List<GameObject> m_sankakuRemains = new List<GameObject>();
    [SerializeField] List<GameObject> m_sikakuRemains = new List<GameObject>();
    [SerializeField] List<GameObject> m_gokakuRemains = new List<GameObject>();
    [SerializeField] List<GameObject> m_rokukakuRemains = new List<GameObject>();
    int m_playerCounter;

    GameObject[] m_playerSankakuRemains;
    public void Result()
    {
        //foreach (var s in m_sankakuRemains)
        //{
        //    s.SetActive(false);
        //}
        //foreach (var s in m_sikakuRemains)
        //{
        //    s.SetActive(false);
        //}
        //foreach (var s in m_gokakuRemains)
        //{
        //    s.SetActive(false);
        //}
        //foreach (var s in m_rokukakuRemains)
        //{
        //    s.SetActive(false);
        //}
        

        m_playerCounter++;
        Sannkaku();
        Sikaku();
        Gokaku();
        Rokukaku();
    }

    void Score()
    {
        
    }

    void Sannkaku()
    {
<<<<<<< HEAD
        for (int i = 0; i < m_sankakuGetRemains[m_playerNum - 1]; i++)
=======
        for (int i = 0; i < m_sankakuGetRemains[m_playerCounter - 1]; i++)
>>>>>>> 7df3bb978efe0f8f6bd506cba98583996435b714
        {
            int random = Random.Range(0, m_sankakuRemains.Count);
            m_sankakuRemains[random].SetActive(true);
            m_sankakuRemains.RemoveAt(random);
        }
    }

    void Sikaku()
    {
        for (int i = 0; i < m_sikakuGetRemains[m_playerCounter - 1]; i++)
        {
            int random = Random.Range(0, m_sikakuRemains.Count);
            m_sikakuRemains[random].SetActive(true);
            m_sikakuRemains.RemoveAt(random);
        }
    }
    void Gokaku()
    {
        for (int i = 0; i < m_gokakuGetRemains[m_playerCounter - 1]; i++)
        {
            int random = Random.Range(0, m_gokakuRemains.Count);
            m_gokakuRemains[random].SetActive(true);
            m_gokakuRemains.RemoveAt(random);
        }
    }

    void Rokukaku()
    {
        for (int i = 0; i < m_rokukakuGetRemains[m_playerCounter - 1]; i++)
        {
            int random = Random.Range(0, m_rokukakuRemains.Count);
            m_rokukakuRemains[random].SetActive(true);
            m_rokukakuRemains.RemoveAt(random);
        }
    }
    public void ToPlayer2()
    {
        Result();
        /*for (int i = 0; i < m_sankakuGetRemains[m_playerCounter - 1]; i++)
        {
            Destroy(m_playerSankakuRemains[i]);
        }*/
        if(m_playerNum == 3)
        {
            m_toPlayer3Text.text = "Finish Game";
        }
    }
    public void ToPlayer3()
    {
        /*for (int i = 0; i < m_sankakuGetRemains[m_playerCounter - 1]; i++)
        {
            Destroy(m_playerSankakuRemains[i]);
        }*/
        if (m_playerNum == 4)
        {
            m_toPlayer4Text.text = "Finish Game";
            Result();
        }
        else if(m_playerNum >= 3)
        {
            Result();
        }
        else
        {
            m_finishResultEvent.Invoke();
        }
    }
    public void ToPlayer4()
    {
        /*for (int i = 0; i < m_sankakuGetRemains[m_playerCounter - 1]; i++)
        {
            Destroy(m_playerSankakuRemains[i]);
        }*/
        if (m_playerNum == 5)
        {
            m_toPlayer5Text.text = "Finish Game";
            Result();
        }
        else if (m_playerNum >= 4)
        {
            Result();
        }
        else
        {
            m_finishResultEvent.Invoke();
        }
    }
    public void ToPlayer5()
    {
        /*for (int i = 0; i < m_sankakuGetRemains[m_playerCounter - 1]; i++)
        {
            Destroy(m_playerSankakuRemains[i]);
        }*/
        if (m_playerNum >= 5)
        {
            Result();
        }
        else
        {
            m_finishResultEvent.Invoke();
        }
    }
    public void ToPlayer6()
    {
        /*for (int i = 0; i < m_sankakuGetRemains[m_playerCounter - 1]; i++)
        {
            Destroy(m_playerSankakuRemains[i]);
        }*/
        if (m_playerNum == 6)
        {
            Result();
        }
        else
        {
            m_finishResultEvent.Invoke();
        }
    }
    public void FinishResult()
    {
        Destroy(m_playerSankakuRemains[0]);
        m_finishResultEvent.Invoke();
    }
}