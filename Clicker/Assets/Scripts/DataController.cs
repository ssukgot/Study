﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour {

    private int m_gold = 0;

    private int m_goldPerClick = 0;

    private void Awake()
    {

        m_gold = PlayerPrefs.GetInt("Gold");

        m_goldPerClick = PlayerPrefs.GetInt("GoldPerClick",1);

    }

    //GoldPerClick의 값을 현재 골드량에 따라 증가시키기

    public void SetGold(int newGold)
    {

        m_gold = newGold;

        PlayerPrefs.SetInt("Gold", m_gold);

    }

    public void AddGold(int newGold)
    {

        m_gold += newGold; //m_gold = m_gold + newGold의 축약형

        SetGold(m_gold);

    }

    public void SubGold(int newGold)
    {

        m_gold -= newGold;

        SetGold(m_gold);

    }

    public int GetGold()
    {

        return m_gold;
       
    }

    public int GetGoldPerClick()
    {

        return m_goldPerClick;

    }

    public void SetGoldPerClick(int newGoldPerClick)
    {

        m_goldPerClick = newGoldPerClick;

        PlayerPrefs.SetInt("GoldPerClick", m_goldPerClick);

    }

}
