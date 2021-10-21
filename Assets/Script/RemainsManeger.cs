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
private void Start()
    {
        SetUp();
        Set();
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
        m_remainsRemaining = m_remainsRemaining - 9;
        m_remains.RemoveRange(0, 6);
        m_remains.RemoveRange(8, 3);
        m_playerResult = new int[] { 2, 1, 4 };
        m_remainsResult = new int[4, 4] { { 1, 2, 0, 0 }, { 1, 1, 2, 2 }, { 0, 0, 0, 0 }, { 1, 1, 1, 0 } };
    }
    public void SetBoard()
    {
        for(int s = 0; s < m_remains.Count;s++)
        {
            if(m_remains[s] == m_sannkakuObject && s < m_remainsRemaining)
            {
                Instantiate(m_sannkakuObject, m_space[s].transform);
            }
            else if(m_remains[s] == m_sikakuObject && s < m_remainsRemaining)
            {
                Instantiate(m_sikakuObject, m_space[s].transform);
            }
            else if(m_remains[s] == m_gokakukeiObject && s < m_remainsRemaining)
            {
                Instantiate(m_gokakukeiObject, m_space[s].transform);
            }
            else if(m_remains[s] == m_rokukakukeiObject && s < m_remainsRemaining)
            {
                Instantiate(m_rokukakukeiObject, m_space[s].transform);
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
            }
        }

        /*int triangle = 8 - m_lossTriangle;
        int square = 8 - m_lossSquare;
        int gokakukei = 8 - m_lossGokakukei;
        int hexagonal = 8 - m_lossHexagonal;

        foreach(GameObject i in m_mass)
        {
            //m_rokukakukei[m_rokukakukei.Length].SetActive(false);

            if(triangle > 0)
            {
                GameObject child = i.transform.Find("sannkaku").gameObject;
                child.SetActive(true);
                triangle--;
            }
            else if(square > 0)
            {
                GameObject child = i.transform.Find("sikaku").gameObject;
                child.SetActive(true);
                square--;
            }
            else if(gokakukei > 0)
            {
                GameObject child = i.transform.Find("gokakukei").gameObject;
                child.SetActive(true);
                gokakukei--;
            }
            else if(hexagonal > 0)
            {
                GameObject child = i.transform.Find("rokukakukei").gameObject;
                child.SetActive(true);
                hexagonal--;
            }
            else if(m_player1lose > m_player2lose && m_player1lost.Length != 0)
            {
                if(m_player1lose > m_player3lose)
                {
                    if(m_player1lose > m_player4lose)
                    {
                        if(m_player1lose > m_player5lose)
                        {
                            if (m_player1lose > m_player6lose )
                            {
                                GameObject sannkakuChild = i.transform.Find("sannkaku").gameObject;
                                GameObject sikakuChild = i.transform.Find("sikaku").gameObject;
                                GameObject gokakukeiChild = i.transform.Find("gokakukei").gameObject;
                                GameObject rokukakukeiChild = i.transform.Find("rokukakukei").gameObject;
                                if(m_player1lost[0] >= 1)
                                {
                                    sannkakuChild.SetActive(true);
                                    m_player1lost[0]--;
                                    for (int j = 0; j < m_player1lost[0]; j++)
                                    {
                                        Instantiate(m_sannkakuObject, i.transform);
                                    }
                                }
                                else if(m_player1lost[1] >= 1)
                                {
                                    sikakuChild.SetActive(true);
                                    m_player1lost[1]--;
                                    for (int j = 0; j < m_player1lost[1]; j++)
                                    {
                                        Instantiate(m_sikakuObject, i.transform);
                                    }
                                }
                                else if (m_player1lost[2] >= 1)
                                {
                                    gokakukeiChild.SetActive(true);
                                    m_player1lost[2]--;
                                    for (int j = 0; j < m_player1lost[2]; j++)
                                    {
                                        Instantiate(m_gokakukeiObject, i.transform);
                                    }
                                }
                                else if (m_player1lost[3] >= 1)
                                {
                                    rokukakukeiChild.SetActive(true);
                                    m_player1lost[3]--;
                                    for (int j = 0; j < m_player1lost[3]; j++)
                                    {
                                        Instantiate(m_rokukakukeiObject, i.transform);
                                    }
                                }
                                m_player1lost = null;
                            }
                        }
                    }
                }
            }
            
        }*/
    }

    public void GetRemain()
    {

    }
    /*[SerializeField] GameObject[] m_mass;
    [SerializeField] GameObject[] m_triangle;
    [SerializeField] GameObject[] m_square;
    [SerializeField] GameObject[] m_hexagonal;

    int m_lossTriangle = 1;
    int m_lossSquare = 1;
    int m_lossGokakukei = 1;
    int m_lossHexagonal = 1;

    int[] m_player1lost;
    int[] m_player2lost;
    int[] m_player3lost;
    int[] m_player4lost;
    int[] m_player5lost;
    int[] m_player6lost;

    int m_player1lose;
    int m_player2lose;
    int m_player3lose;
    int m_player4lose; 
    int m_player5lose;
    int m_player6lose;*/
}
