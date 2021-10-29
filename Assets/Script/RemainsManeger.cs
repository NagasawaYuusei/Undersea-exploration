using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemainsManeger : MonoBehaviour
{

    [SerializeField] GameObject m_sannkakuObject;
    [SerializeField] GameObject m_sikakuObject;
    [SerializeField] GameObject m_gokakukeiObject;
    [SerializeField] GameObject m_rokukakukeiObject;
    [SerializeField] GameObject[] m_space;

    List<GameObject> m_remains = new List<GameObject>();
    int m_remainsRemaining;
    int[] m_playerResult;
    int[,] m_remainsResult;
    int m_maxBoard;

    public int MaxBoard
    {
        get
        {
            return m_maxBoard;
        }
    }
private void Start()
    {
        SetUp();
        SetBoard();
    }

    void SetUp()
    {
        for(int i = 0; i < 32; i++)
        {
            if(i < 8)
            {
                m_remains.Add(m_sannkakuObject);
            }
            else if(i < 16)
            {
                m_remains.Add(m_sikakuObject);
            }
            else if(i < 24)
            {
                m_remains.Add(m_gokakukeiObject);
            }
            else
            {
                m_remains.Add(m_rokukakukeiObject);
            }
        }
        m_remainsRemaining = 32;
    }
    void Set()
    {
        m_remainsRemaining = m_remainsRemaining - 9; //ボードに残っているリマインズ
        m_remains.RemoveRange(0, 6);//
        m_remains.RemoveRange(8, 3);//
        m_playerResult = new int[] { 2, 1, 4 };//奥にいたプレイヤー順
        m_remainsResult = new int[4, 4] { { 1, 2, 0, 0 }, { 1, 1, 2, 2 }, { 0, 0, 0, 0 }, { 1, 1, 1, 0 } };//落としたリマインズ
    }
    public void SetBoard()
    {
        for(int s = 0; s < m_remains.Count;s++)
        {
            if(m_remains[s] == m_sannkakuObject && s < m_remainsRemaining)
            {
                Instantiate(m_sannkakuObject, m_space[s].transform);
                m_maxBoard++;
            }
            else if(m_remains[s] == m_sikakuObject && s < m_remainsRemaining)
            {
                Instantiate(m_sikakuObject, m_space[s].transform);
                m_maxBoard++;
            }
            else if(m_remains[s] == m_gokakukeiObject && s < m_remainsRemaining)
            {
                Instantiate(m_gokakukeiObject, m_space[s].transform);
                m_maxBoard++;
            }
            else if(m_remains[s] == m_rokukakukeiObject && s < m_remainsRemaining)
            {
                Instantiate(m_rokukakukeiObject, m_space[s].transform);
                m_maxBoard++;
            }
        }


        for(int i = 0; i < m_playerResult.Length; i++)
        {
            if(m_playerResult[i] == 1)
            {
                for (int j = 0; j < m_remainsResult.GetLength(1); j++)
                {
                    if (m_remainsResult[0, j] == 1)
                    {
                        Instantiate(m_sannkakuObject,m_space[m_remainsRemaining + i].transform);
                    }
                    else if (m_remainsResult[0, j] == 2)
                    {
                        Instantiate(m_sikakuObject, m_space[m_remainsRemaining + i].transform);
                    }
                    else if (m_remainsResult[0, j] == 3)
                    {
                        Instantiate(m_gokakukeiObject, m_space[m_remainsRemaining + i].transform);
                    }
                    else if (m_remainsResult[0, j] == 4)
                    {
                        Instantiate(m_rokukakukeiObject, m_space[m_remainsRemaining + i].transform);
                    }
                }
                m_maxBoard++;
            }
            else if (m_playerResult[i] == 2)
            {
                for (int j = 0; j < m_remainsResult.GetLength(1); j++)
                {
                    if (m_remainsResult[1, j] == 1)
                    {
                        Instantiate(m_sannkakuObject, m_space[m_remainsRemaining + i].transform);
                    }
                    else if (m_remainsResult[1, j] == 2)
                    {
                        Instantiate(m_sikakuObject, m_space[m_remainsRemaining + i].transform);
                    }
                    else if (m_remainsResult[1, j] == 3)
                    {
                        Instantiate(m_gokakukeiObject, m_space[m_remainsRemaining + i].transform);
                    }
                    else if (m_remainsResult[1, j] == 4)
                    {
                        Instantiate(m_rokukakukeiObject, m_space[m_remainsRemaining + i].transform);
                    }
                }
                m_maxBoard++;
            }
            else if (m_playerResult[i] == 3)
            {
                for (int j = 0; j < m_remainsResult.GetLength(1); j++)
                {
                    if (m_remainsResult[2, j] == 1)
                    {
                        Instantiate(m_sannkakuObject, m_space[m_remainsRemaining + i].transform);
                    }
                    else if (m_remainsResult[2, j] == 2)
                    {
                        Instantiate(m_sikakuObject, m_space[m_remainsRemaining + i].transform);
                    }
                    else if (m_remainsResult[2, j] == 3)
                    {
                        Instantiate(m_gokakukeiObject, m_space[m_remainsRemaining + i].transform);
                    }
                    else if (m_remainsResult[2, j] == 4)
                    {
                        Instantiate(m_rokukakukeiObject, m_space[m_remainsRemaining + i].transform);
                    }
                }
                m_maxBoard++;
            }
            else if(m_playerResult[i] == 4)
            {
                for (int j = 0; j < m_remainsResult.GetLength(1); j++)
                {
                    if (m_remainsResult[3, j] == 1)
                    {
                        Instantiate(m_sannkakuObject, m_space[m_remainsRemaining + i].transform);
                    }
                    else if (m_remainsResult[3, j] == 2)
                    {
                        Instantiate(m_sikakuObject, m_space[m_remainsRemaining + i].transform);
                    }
                    else if (m_remainsResult[3, j] == 3)
                    {
                        Instantiate(m_gokakukeiObject, m_space[m_remainsRemaining + i].transform);
                    }
                    else if (m_remainsResult[3, j] == 4)
                    {
                        Instantiate(m_rokukakukeiObject, m_space[m_remainsRemaining + i].transform);
                    }
                }
                m_maxBoard++;
            }
            else if (m_playerResult[i] == 5)
            {
                for (int j = 0; j < m_remainsResult.GetLength(1); j++)
                {
                    if (m_remainsResult[4, j] == 1)
                    {
                        Instantiate(m_sannkakuObject, m_space[m_remainsRemaining + i].transform);
                    }
                    else if (m_remainsResult[4, j] == 2)
                    {
                        Instantiate(m_sikakuObject, m_space[m_remainsRemaining + i].transform);
                    }
                    else if (m_remainsResult[4, j] == 3)
                    {
                        Instantiate(m_gokakukeiObject, m_space[m_remainsRemaining + i].transform);
                    }
                    else if (m_remainsResult[4, j] == 4)
                    {
                        Instantiate(m_rokukakukeiObject, m_space[m_remainsRemaining + i].transform);
                    }
                }
                m_maxBoard++;
            }
            else if (m_playerResult[i] == 6)
            {
                for (int j = 0; j < m_remainsResult.GetLength(1); j++)
                {
                    if (m_remainsResult[5, j] == 1)
                    {
                        Instantiate(m_sannkakuObject, m_space[m_remainsRemaining + i].transform);
                    }
                    else if (m_remainsResult[5, j] == 2)
                    {
                        Instantiate(m_sikakuObject, m_space[m_remainsRemaining + i].transform);
                    }
                    else if (m_remainsResult[5, j] == 3)
                    {
                        Instantiate(m_gokakukeiObject, m_space[m_remainsRemaining + i].transform);
                    }
                    else if (m_remainsResult[5, j] == 4)
                    {
                        Instantiate(m_rokukakukeiObject, m_space[m_remainsRemaining + i].transform);
                    }
                }
                m_maxBoard++;
            }
        }
    }
}
