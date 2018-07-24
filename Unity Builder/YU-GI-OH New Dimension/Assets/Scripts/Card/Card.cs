using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Card : MonoBehaviour {

    //delgates
    public Action OnReplacement;
    public Action OnFieldEnter;
    public Action OnFieldExit;

    public int id;
    public Enums.CardType type;
    public string cardName;
    public string description;
    public Sprite image;

    void Start () {
		
	}

	void Update () {
		
	}
}
