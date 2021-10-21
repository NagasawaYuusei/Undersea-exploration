using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManeger : MonoBehaviour
{
    int m_playerNum;
    int m_playerTurn;
    int[] m_playerGet;
    bool[] m_playerBack;
    [SerializeField] GameManeger m_playerManeger;

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
        m_playerManeger.Go();
    }

    public void No()//完成
    {
        m_playerManeger.Go();
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
