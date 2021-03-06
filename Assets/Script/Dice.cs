using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    /// <summary>サイコロの出目の和</summary>
    public int DiceSum { get { return m_diceSum; } } 

    [SerializeField] GameObject[] m_diceObjects;
    [SerializeField] Transform[] m_diceTransforms;
    [SerializeField] Animator m_daiceAnim;
    [SerializeField] PlayerManeger m_playerManeger;
    [SerializeField] float m_stopTime = 2.0f;
    List<GameObject> m_dice = new List<GameObject>();
    private int m_randomDiceValue1;
    private int m_randomDiceValue2;
    private int m_diceSum;
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

        dice1.transform.position = m_diceTransforms[0].position;
        dice2.transform.position = m_diceTransforms[1].position;
    }

    public void Stop()
    {
        m_daiceAnim.enabled = false;
        RandomDice();
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        yield return new WaitForSeconds(m_stopTime);
        m_playerManeger.MoveOn();
    }
}
