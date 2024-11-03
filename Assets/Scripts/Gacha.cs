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
    [SerializeField] private int money;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] TMP_Text currencyText;

    private void Start()
    {
        currencyText.SetText(money.ToString());
        FindObjectOfType<AudioManager>().Play("Tetris");
    }

    private void Update()
    {
        currencyText.SetText(money.ToString());
    }

    public void Roll()
    {
        if (money >= 10)
        {
            int prob = Random.Range(1, 101);

            money -= 10;

            //Ultra rare
            if (prob == 1)
            {
                int newProb = Random.Range(1, 4);
                if (newProb == 1)
                {
                    print("Inverted KC");
                    Instantiate(gdsa[0], spawnPoint.transform.position, transform.rotation);
                }
                else if (newProb == 2)
                {
                    print("Inverted Lucas");
                    Instantiate(gdsa[1], spawnPoint.transform.position, transform.rotation);
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
                    Instantiate(gdsa[2], spawnPoint.transform.position, transform.rotation);
                }
                else
                {
                    print("Adam");
                    Instantiate(gdsa[3], spawnPoint.transform.position, transform.rotation);
                }
            }
            //Uncommon
            else if (prob > 10 && prob <= 30)
            {
                int newProb = Random.Range(1, 5);
                if (newProb == 1)
                {
                    print("Dean");
                    Instantiate(gdsa[4], spawnPoint.transform.position, transform.rotation);
                }
                else if (newProb == 2)
                {
                    print("Logan");
                    Instantiate(gdsa[5], spawnPoint.transform.position, transform.rotation);
                }
                else if (newProb == 3)
                {
                    print("Lucas");
                    Instantiate(gdsa[6], spawnPoint.transform.position, transform.rotation);
                }
                else
                {
                    print("Jason");
                    Instantiate(gdsa[7], spawnPoint.transform.position, transform.rotation);
                }
            }
            //Common
            else if (prob > 30 && prob <= 100)
            {
                int newProb = Random.Range(1, 4);
                if (newProb == 1)
                {
                    print("Ruidger");
                    Instantiate(gdsa[8], spawnPoint.transform.position, transform.rotation);
                }
                else if (newProb == 2)
                {
                    print("Lauren");
                    Instantiate(gdsa[9], spawnPoint.transform.position, transform.rotation);
                }
                else
                {
                    print("Mikey");
                    Instantiate(gdsa[10], spawnPoint.transform.position, transform.rotation);
                }
            }
        }
        else
        {
            print("Not enough money");
        }
    }
}
