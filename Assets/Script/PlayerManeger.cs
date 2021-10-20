using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManeger : MonoBehaviour
{
    int m_playerNum;
    int m_playerNowTurn;
    int[] m_playerGet;
    bool[] m_isBack;

    [SerializeField] GameObject[] m_playerObject;
    [SerializeField] GameManeger m_gameManeger;
    [SerializeField] Dice m_diceManneger;
    int m_shipInAir;

    /// <summary>
    /// カプセル化開始
    /// </summary>
    public int PlayerNum
    {
        get
        {
            return m_playerNum;
        }
        set
        {
            m_playerNum = value;
        }
    }

    public int PlayerTurn
    {
        get
        {
            return m_playerNowTurn;
        }
    }

    public int ShipInAir
    {
        get
        {
            return m_shipInAir;
        }
    }

    public bool[] IsBack
    {
        get
        {
            return m_isBack;
        }
        set
        {
            m_isBack = value;
        }
    }
    /// <summary>
    /// カプセル化終了
    /// </summary>

    public void Yes()
    {
        m_isBack[m_playerNowTurn] = true;
        m_gameManeger.Go();
    }

    public void No()//完成
    {
        m_gameManeger.Go();
    }

    void ShipAir()
    {
        if (m_playerNowTurn == 1)
        {
            m_shipInAir += m_playerGet[0];
        }
        else if (m_playerNowTurn == 2)
        {
            m_shipInAir += m_playerGet[1];
        }
        else if (m_playerNowTurn == 3)
        {
            m_shipInAir += m_playerGet[2];
        }
        else if (m_playerNowTurn == 4)
        {
            m_shipInAir += m_playerGet[3];
        }
        else if (m_playerNowTurn == 5)
        {
            m_shipInAir += m_playerGet[4];
        }
        else if (m_playerNowTurn == 6)
        {
            m_shipInAir += m_playerGet[5];
        }
    }

    public void Dice()
    {
        m_diceManneger.RandomDice();
        StartCoroutine(DiceDestoroy());
    }

    IEnumerator DiceDestoroy()
    {
        yield return new WaitForSeconds(2);

        Destroy(m_diceManneger.Dice1);
        Destroy(m_diceManneger.Dice2);

    }


    void Move()
    {
        
    }
}
