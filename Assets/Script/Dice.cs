using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    /// <summary>サイコロの出目の和</summary>
    public int DiceSum { get { return m_diceSum; } }
    public GameObject Dice1 { get { return m_dice1; } }
    public GameObject Dice2 { get { return m_dice2; } }

    [SerializeField] GameObject[] m_diceObjects;
    [SerializeField] Transform[] m_diceTransforms;
    [SerializeField] GameObject m_dicePanel;
    [SerializeField] float m_diceDisplayTime;
    List<GameObject> m_dice = new List<GameObject>();
    private int m_randomDiceValue1;
    private int m_randomDiceValue2;
    private int m_diceSum;

    GameObject m_dice1;
    GameObject m_dice2;
    
    void Start()
    {
        SetUp();
    }

    void SetUp()
    {
        m_dice.AddRange(m_diceObjects);
    }
    public void RandomDice()
    {
        m_randomDiceValue1 = Random.Range(0, 3);
        m_randomDiceValue2 = Random.Range(0, 3);
        m_diceSum = m_randomDiceValue1 + m_randomDiceValue2 + 2;

        Debug.Log(m_diceSum);
        
        var dice1 = Instantiate(m_dice[m_randomDiceValue1]);
        var dice2 = Instantiate(m_dice[m_randomDiceValue2]);

        m_dice1 = dice1;
        m_dice2 = dice2;

        dice1.transform.position = m_diceTransforms[0].position;
        dice2.transform.position = m_diceTransforms[1].position;
    }

    public void Stop()
    {
        RandomDice();
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        yield return new WaitForSeconds(m_diceDisplayTime);
        m_dicePanel.SetActive(false);
    }
}
