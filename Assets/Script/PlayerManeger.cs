using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManeger : MonoBehaviour
{
    int m_playerNum;
    int m_playerTurn = 1;
    int m_player1Get;
    int m_player2Get;
    int m_player3Get;
    int m_player4Get;
    int m_player5Get;
    int m_player6Get;

    int m_shipInAir;

    public int ShipInAir
    {
        get
        {
            return m_shipInAir;
        }
    }

    public void Player2()
    {
        m_playerNum = 2;
    }

    public void Player3()
    {
        m_playerNum = 3;
    }

    public void Player4()
    {
        m_playerNum = 4;
    }

    public void Player5()
    {
        m_playerNum = 5;
    }

    public void Player6()
    {
        m_playerNum = 6;
    }

    void ShipAir()
    {
        if (m_playerTurn == 1)
        {
            m_shipInAir += m_player1Get;
        }
        else if (m_playerTurn == 2)
        {
            m_shipInAir += m_player2Get;
        }
        else if (m_playerTurn == 3)
        {
            m_shipInAir += m_player3Get;
        }
        else if (m_playerTurn == 4)
        {
            m_shipInAir += m_player4Get;
        }
        else if (m_playerTurn == 5)
        {
            m_shipInAir += m_player5Get;
        }
        else if (m_playerTurn == 6)
        {
            m_shipInAir += m_player6Get;
        }
    }
}
