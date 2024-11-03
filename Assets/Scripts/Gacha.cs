using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Random = UnityEngine.Random;
using TMPro;

public class Gacha : MonoBehaviour
{
    [SerializeField] List<GameObject> gdsa = new List<GameObject>();
    [SerializeField] private List<GameObject> keepGDSA = new List<GameObject>();
    [SerializeField] private int money;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] TMP_Text currencyText;
    [SerializeField] private SpriteRenderer sprite;

    private void Start()
    {
        for (int i = 0; i < gdsa.Count; i++)
        {
            gdsa[i].SetActive(false);
            keepGDSA[i].SetActive(false);
            
        }
        currencyText.SetText(money.ToString());
    }

    private void Update()
    {
        currencyText.SetText("Gacha Currency: " + money.ToString());
    }

    public void Roll()
    {
        if (money >= 10)
        {
            for (int i = 0; i < gdsa.Count; i++)
            {
                gdsa[i].SetActive(false);
            }
            
            int prob = Random.Range(1, 101);

            money -= 10;

            //Ultra rare
            if (prob == 1)
            {
                int newProb = Random.Range(1, 4);
                if (newProb == 1)
                {
                    print("Inverted KC");
                    gdsa[0].SetActive(true);
                    keepGDSA[0].SetActive(true);
                }
                else if (newProb == 2){
                    print("Inverted Lucas");
                    gdsa[1].SetActive(true);
                    keepGDSA[1].SetActive(true);
                }
                else
                {
                    print("Bye bye money");
                    money = 0;
                }
            }
            //Rare
            else if (prob > 1 && prob <= 10)
            {
                int newProb = Random.Range(1, 3);
                if (newProb == 1)
                {
                    print("KC");
                    gdsa[2].SetActive(true);
                    keepGDSA[2].SetActive(true);
                }
                else
                {
                    print("Adam");
                    gdsa[3].SetActive(true);
                    keepGDSA[3].SetActive(true);
                }
            }
            //Uncommon
            else if (prob > 10 && prob <= 30)
            {
                int newProb = Random.Range(1, 3);
                if (newProb == 1)
                {
                    print("Dean");
                    gdsa[4].SetActive(true);
                    keepGDSA[4].SetActive(true);
                }
                else if (newProb == 2)
                {
                    print("Logan");
                    gdsa[5].SetActive(true);
                    keepGDSA[5].SetActive(true);
                }
            }
            //Common
            else if (prob > 30 && prob <= 100)
            {
                int newProb = Random.Range(1, 5);
                if (newProb == 1)
                {
                    print("Ruidger");
                    gdsa[6].SetActive(true);
                    keepGDSA[6].SetActive(true);
                }
                else if (newProb == 2)
                {
                    print("Lucas");
                    gdsa[7].SetActive(true);
                    keepGDSA[7].SetActive(true);
                }
                else if (newProb == 3)
                {
                    print("Mikey");
                    gdsa[8].SetActive(true);
                    keepGDSA[8].SetActive(true);
                }
                else
                {
                    print("Lauren");
                    gdsa[9].SetActive(true);
                    keepGDSA[9].SetActive(true);
                }
            }
        }
        else
        {
            print("Not enough money");
        }
    }
}
