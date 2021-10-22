using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManeger : MonoBehaviour
{
    int m_playerNum;
    int m_playerTurn;
    int[] m_playerMass;
    int[] m_playerGet;
    bool[] m_playerBack;
    [SerializeField] float m_stopTime = 1.0f;
    [SerializeField] GameObject[] m_playerObject;
    [SerializeField] GameManeger m_gameManeger;
    [SerializeField] Dice m_diceManeger;
    [SerializeField] GameObject m_dicePanel;
    [SerializeField] GameObject[] m_mass;

    int m_shipInAir;
    /// <summary>
    /// カプセル化開始
    /// </summary>
    /// 
    public int PlayerNum
    {
        get
        {
            return m_playerNum;
        }
    }

    public int PlayerTurn
    {
        get
        {
            return m_playerTurn;
        }
        set
        {
            m_playerTurn = value;
        }
    }
    public int ShipInAir
    {
        get
        {
            return m_shipInAir;
        }
    }

    /// <summary>
    /// カプセル化終了
    /// </summary>

    public void Player2()
    {
        m_playerNum = 1;
        m_playerTurn = 1;
        m_playerGet = new int[1];
        m_playerBack = new bool[1];
    }

    public void Player3()
    {
        m_playerNum = 2;
        m_playerTurn = 2;
        m_playerGet = new int[2];
        m_playerBack = new bool[2];
    }

    public void Player4()
    {
        m_playerNum = 3;
        m_playerTurn = 3;
        m_playerGet = new int[3];
        m_playerBack = new bool[3];
    }

    public void Player5()
    {
        m_playerNum = 4;
        m_playerTurn = 4;
        m_playerGet = new int[4];
        m_playerBack = new bool[4];
    }

    public void Player6()
    {
        m_playerNum = 5;
        m_playerTurn = 5;
        m_playerGet = new int[5];
        m_playerBack = new bool[5];
    }

    public void Yes()//完成
    {
        m_playerBack[m_playerTurn] = true;
        m_gameManeger.Go();
    }

    public void No()//完成
    {
        m_gameManeger.Go();
    }

    public void MoveOn()
    {
        m_dicePanel.SetActive(false);
        StartCoroutine(MovePlayer());

    }

    IEnumerator MovePlayer()
    {
        yield return new WaitForSeconds(m_stopTime);
        for (int i = 0; i < m_diceManeger.DiceSum; i++)
        {
            int count = 1;
            if(m_playerTurn == 0)
            {
                if(!m_playerBack[0])
                {
                    if(m_mass[m_playerMass[0] + count].transform.gameObject.tag == "Player")
                    {
                        count++;
                    }
                    else
                    {
                        m_mass[m_playerMass[0] + count].transform.parent = m_playerObject[0].transform;
                        m_playerObject[0].transform.position = new Vector3(0, 0, 0);
                        yield return new WaitForSeconds(m_stopTime);
                        m_playerMass[0] += count;
                        count = 1;
                    }
                }
                else
                {
                    if (m_mass[m_playerMass[0] - count].transform.gameObject.tag == "Player")
                    {
                        count++;
                    }
                    else
                    {
                        m_mass[m_playerMass[0] - count].transform.parent = m_playerObject[0].transform;
                        m_playerObject[0].transform.position = new Vector3(0, 0, 0);
                        yield return new WaitForSeconds(m_stopTime);
                        m_playerMass[0] -= count;
                        count = 1;
                    }
                }
            }
            else if (m_playerTurn == 1)
            {
                if (!m_playerBack[1])
                {
                    if (m_mass[m_playerMass[1] + count].transform.gameObject.tag == "Player")
                    {
                        count++;
                    }
                    else
                    {
                        m_mass[m_playerMass[1] + count].transform.parent = m_playerObject[1].transform;
                        m_playerObject[1].transform.position = new Vector3(0, 0, 0);
                        yield return new WaitForSeconds(m_stopTime);
                        m_playerMass[1] += count;
                        count = 1;
                    }
                }
                else
                {
                    if (m_mass[m_playerMass[1] - count].transform.gameObject.tag == "Player")
                    {
                        count++;
                    }
                    else
                    {
                        m_mass[m_playerMass[1] - count].transform.parent = m_playerObject[1].transform;
                        m_playerObject[1].transform.position = new Vector3(0, 0, 0);
                        yield return new WaitForSeconds(m_stopTime);
                        m_playerMass[1] -= count;
                        count = 1;
                    }
                }
            }
            else if (m_playerTurn == 2)
            {
                if (!m_playerBack[2])
                {
                    if (m_mass[m_playerMass[2] + count].transform.gameObject.tag == "Player")
                    {
                        count++;
                    }
                    else
                    {
                        m_mass[m_playerMass[2] + count].transform.parent = m_playerObject[2].transform;
                        m_playerObject[2].transform.position = new Vector3(0, 0, 0);
                        yield return new WaitForSeconds(m_stopTime);
                        m_playerMass[2] += count;
                        count = 1;
                    }
                }
                else
                {
                    if (m_mass[m_playerMass[2] - count].transform.gameObject.tag == "Player")
                    {
                        count++;
                    }
                    else
                    {
                        m_mass[m_playerMass[2] - count].transform.parent = m_playerObject[2].transform;
                        m_playerObject[2].transform.position = new Vector3(0, 0, 0);
                        yield return new WaitForSeconds(m_stopTime);
                        m_playerMass[2] -= count;
                        count = 1;
                    }
                }
            }
            else if (m_playerTurn == 3)
            {
                if (!m_playerBack[3])
                {
                    if (m_mass[m_playerMass[3] + count].transform.gameObject.tag == "Player")
                    {
                        count++;
                    }
                    else
                    {
                        m_mass[m_playerMass[3] + count].transform.parent = m_playerObject[3].transform;
                        m_playerObject[3].transform.position = new Vector3(0, 0, 0);
                        yield return new WaitForSeconds(m_stopTime);
                        m_playerMass[3] += count;
                        count = 1;
                    }
                }
                else
                {
                    if (m_mass[m_playerMass[3] - count].transform.gameObject.tag == "Player")
                    {
                        count++;
                    }
                    else
                    {
                        m_mass[m_playerMass[3] - count].transform.parent = m_playerObject[3].transform;
                        m_playerObject[3].transform.position = new Vector3(0, 0, 0);
                        yield return new WaitForSeconds(m_stopTime);
                        m_playerMass[3] -= count;
                        count = 1;
                    }
                }
            }
            else if (m_playerTurn == 4)
            {
                if (!m_playerBack[4])
                {
                    if (m_mass[m_playerMass[4] + count].transform.gameObject.tag == "Player")
                    {
                        count++;
                    }
                    else
                    {
                        m_mass[m_playerMass[4] + count].transform.parent = m_playerObject[4].transform;
                        m_playerObject[4].transform.position = new Vector3(0, 0, 0);
                        yield return new WaitForSeconds(m_stopTime);
                        m_playerMass[4] += count;
                        count = 1;
                    }
                }
                else
                {
                    if (m_mass[m_playerMass[4] - count].transform.gameObject.tag == "Player")
                    {
                        count++;
                    }
                    else
                    {
                        m_mass[m_playerMass[4] - count].transform.parent = m_playerObject[4].transform;
                        m_playerObject[4].transform.position = new Vector3(0, 0, 0);
                        yield return new WaitForSeconds(m_stopTime);
                        m_playerMass[4] -= count;
                        count = 1;
                    }
                }
            }
            else
            {
                if (!m_playerBack[5])
                {
                    if (m_mass[m_playerMass[5] + count].transform.gameObject.tag == "Player")
                    {
                        count++;
                    }
                    else
                    {
                        m_mass[m_playerMass[5] + count].transform.parent = m_playerObject[5].transform;
                        m_playerObject[5].transform.position = new Vector3(0, 0, 0);
                        yield return new WaitForSeconds(m_stopTime);
                        m_playerMass[5] += count;
                        count = 1;
                    }
                }
                else
                {
                    if (m_mass[m_playerMass[5] - count].transform.gameObject.tag == "Player")
                    {
                        count++;
                    }
                    else
                    {
                        m_mass[m_playerMass[5] - count].transform.parent = m_playerObject[5].transform;
                        m_playerObject[5].transform.position = new Vector3(0, 0, 0);
                        yield return new WaitForSeconds(m_stopTime);
                        m_playerMass[5] -= count;
                        count = 1;
                    }
                }
            }
        }
        m_gameManeger.Serch();
    }

    void ShipAir()
    {
        if (m_playerTurn == 0)
        {
            m_shipInAir += m_playerGet[0];
        }
        else if (m_playerTurn == 1)
        {
            m_shipInAir += m_playerGet[1];
        }
        else if (m_playerTurn == 2)
        {
            m_shipInAir += m_playerGet[2];
        }
        else if (m_playerTurn == 3)
        {
            m_shipInAir += m_playerGet[3];
        }
        else if (m_playerTurn == 4)
        {
            m_shipInAir += m_playerGet[4];
        }
        else if (m_playerTurn == 5)
        {
            m_shipInAir += m_playerGet[5];
        }
    }
}
