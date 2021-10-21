﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManeger : MonoBehaviour
{
    [SerializeField] GameObject[] m_kuukis;
    [SerializeField] GameObject[] m_senn;
    [SerializeField] PlayerManeger m_playerManeger;
    int m_get;
    public void NowShip()
    {
        for(int i = 0; i < m_get; i++)
        {
            m_kuukis[i].SetActive(false);
            m_senn[i].SetActive(false);
        }
    }
}
