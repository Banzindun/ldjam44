﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPlayer : MonoBehaviour {

    public int CurrentTurn = 0;

    public List<Card> Cards;

    public bool Lost() {
        return Cards.Count == 0;
    }

    virtual public void RemoveCard(Card card) {
        // Removes a card from list of cards
        Cards.Remove(card);
    }

    public void NewTurn(int turnNumber) {
        CurrentTurn = turnNumber;

        for (int i = 0; i < Cards.Count; i++)
        {
            Cards[i].definition.OnNewTurn();
        }
    }
	
}
