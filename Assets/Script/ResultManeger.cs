using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.UI;

public class ResultManeger : MonoBehaviour
{   
    //渡していただくもの
    [SerializeField, Range(2, 6)] int m_playerNum = 6;//プレイヤーの人数(m_playerCountとは異なります)　　　　　　　　　　
    int[] m_sankakuGetRemains = new int[] { 2, 2, 1, 1, 1, 1 };
    int[] m_sikakuGetRemains = new int[] { 0, 0, 1, 1, 5, 1 };
    int[] m_gokakuGetRemains = new int[] { 2, 3, 2, 1, 0, 0 };
    int[] m_rokukakuGetRemains = new int[] { 2, 2, 1, 1, 1, 1 };
    //ここまでの情報をください！

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

    [SerializeField] List<Text> m_sankakuText = new List<Text>();
    [SerializeField] List<Text> m_sikauText = new List<Text>();
    [SerializeField] List<Text> m_gokakuText = new List<Text>();
    [SerializeField] List<Text> m_rokukakuText = new List<Text>();

    List<GameObject> m_initialSankakuRemains = new List<GameObject>();
    List<GameObject> m_initialSikakuRemains = new List<GameObject>();
    List<GameObject> m_initialGokakuRemains = new List<GameObject>();
    List<GameObject> m_initialoldRokukakuRemains = new List<GameObject>();

    int m_playerCounter;
    int m_scoreSum;
    private void Start()
    {
        m_initialSankakuRemains.AddRange(m_sankakuRemains);
        m_initialSikakuRemains.AddRange(m_sikakuRemains);
        m_initialGokakuRemains.AddRange(m_gokakuRemains);
        m_initialoldRokukakuRemains.AddRange(m_rokukakuRemains);
    }
    public void Result()
    {
        m_playerCounter++;
        Sannkaku();
        Sikaku();
        Gokaku();
        Rokukaku();
        Score();
    }
    void Score()
    {
        m_scoreText.text = "合計点数:" + m_scoreSum.ToString();
        m_scoreSum = 0;
    }
    void Sannkaku()
    {
        foreach (var s in m_initialSankakuRemains)
        {
            s.SetActive(false);
        }
        for (int i = 0; i < m_sankakuGetRemains[m_playerCounter - 1]; i++)
        {
            int random = Random.Range(0, m_sankakuRemains.Count);
            m_sankakuRemains[random].SetActive(true);
            m_sankakuRemains.RemoveAt(random);

            m_scoreSum += int.Parse(m_sankakuText[random].text);
            m_sankakuText.RemoveAt(random);
        }
    }

    void Sikaku()
    {
        foreach (var s in m_initialSikakuRemains)
        {
            s.SetActive(false);
        }
        for (int i = 0; i < m_sikakuGetRemains[m_playerCounter - 1]; i++)
        {
            int random = Random.Range(0, m_sikakuRemains.Count);
            m_sikakuRemains[random].SetActive(true);
            m_sikakuRemains.RemoveAt(random);

            m_scoreSum += int.Parse(m_sikauText[random].text);
            m_sikauText.RemoveAt(random);
        }
    }
    void Gokaku()
    {
        foreach (var s in m_initialGokakuRemains)
        {
            s.SetActive(false);
        }
        for (int i = 0; i < m_gokakuGetRemains[m_playerCounter - 1]; i++)
        {
            int random = Random.Range(0, m_gokakuRemains.Count);
            m_gokakuRemains[random].SetActive(true);
            m_gokakuRemains.RemoveAt(random);

            m_scoreSum += int.Parse(m_gokakuText[random].text);
            m_gokakuText.RemoveAt(random);
        }
    }

    void Rokukaku()
    {
        foreach (var s in m_initialoldRokukakuRemains)
        {
            s.SetActive(false);
        }
        for (int i = 0; i < m_rokukakuGetRemains[m_playerCounter - 1]; i++)
        {
            int random = Random.Range(0, m_rokukakuRemains.Count);
            m_rokukakuRemains[random].SetActive(true);
            m_rokukakuRemains.RemoveAt(random);

            m_scoreSum += int.Parse(m_rokukakuText[random].text);
            m_rokukakuText.RemoveAt(random);
        }
    }
    public void ToPlayer2()
    {
        Result();
        if (m_playerNum == 2)
        {
            m_toPlayer3Text.text = "Finish Game";
        }
    }
    public void ToPlayer3()
    {
        if (m_playerNum == 3)
        {
            m_toPlayer4Text.text = "Finish Game";
            Result();
        }
        else if (m_playerNum >= 3)
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
        if (m_playerNum == 4)
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
        if (m_playerNum == 5)
        {
            m_toPlayer6Text.text = "Finish Game";
            Result();
        }
        else if (m_playerNum >= 5)
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

        m_finishResultEvent.Invoke();
    }
}