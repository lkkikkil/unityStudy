using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public GameObject[] cardList;

    private List<int> cardNumbers = new List<int>();

    void InitializeCardNumbersList()
    {
        cardNumbers.Clear();

        for(int cardCount = 0; cardCount < 40; cardCount++)
        {
            cardNumbers.Add(cardCount);
        }
    }
}
