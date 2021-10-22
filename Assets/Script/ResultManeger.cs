using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultManeger : MonoBehaviour
{
    [SerializeField] int m_playerNum;
    [SerializeField] string[] m_playerName;

    int[] m_sankakuGetRemains = new int[] { 2,3,1,1,1,0 }; 
    int[] m_sikakuGetRemains = new int[] { 0,0,0,1,6,1 };
    int[] m_gokakuGetRemains = new int[] { 2 };
    int[] m_rokukakuGetRemains = new int[] { 2 };

    [SerializeField] List<GameObject> m_sankakuRemains = new List<GameObject>();
    [SerializeField] List<GameObject> m_sikakuRemains = new List<GameObject>();
    [SerializeField] List<GameObject> m_gokakuRemains = new List<GameObject>();
    [SerializeField] List<GameObject> m_rokukakuRemains = new List<GameObject>();


    [SerializeField] TextMeshProUGUI m_scoreText;
    private void Start()
    {
        Result();
    }
    public void Result()
    {
        foreach (var s in m_sankakuRemains)
            s.SetActive(false);
        foreach (var s in m_sikakuRemains)
            s.SetActive(false);
        foreach (var s in m_gokakuRemains)
            s.SetActive(false);
        foreach (var s in m_rokukakuRemains)
            s.SetActive(false);

        m_playerNum++;
        Sannkaku();
        Sikaku();
        Gokaku();
        Rokukaku();
    }

    void Sannkaku()
    {
        for(int i = 0; i < m_sankakuGetRemains[m_playerNum - 1]; i++)
        {
            int random = Random.Range(0, m_sankakuRemains.Count);
            m_sankakuRemains[random].SetActive(true);
            m_sankakuRemains.RemoveAt(random);
        }
    }

    void Sikaku()
    {
        for (int i = 0; i < m_sikakuGetRemains[m_playerNum - 1]; i++)
        {
            int random = Random.Range(0, m_sikakuRemains.Count);
            m_sikakuRemains[random].SetActive(true);
            m_sikakuRemains.RemoveAt(random);
        }
    }
    void Gokaku()
    {
        for (int i = 0; i < m_gokakuGetRemains[m_playerNum - 1]; i++)
        {
            int random = Random.Range(0, m_gokakuRemains.Count);
            m_gokakuRemains[random].SetActive(true);
            m_gokakuRemains.RemoveAt(random);
        }
    }

    void Rokukaku()
    {
        for (int i = 0; i < m_rokukakuGetRemains[m_playerNum - 1]; i++)
        {
            int random = Random.Range(0, m_rokukakuRemains.Count);
            m_rokukakuRemains[random].SetActive(true);
            m_rokukakuRemains.RemoveAt(random);
        }
    }
}
