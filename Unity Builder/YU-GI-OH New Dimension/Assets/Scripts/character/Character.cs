using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    private OnButtonClick Menu;

    [SerializeField]
    protected int LivePoints;

    protected bool IsDead = false;

    public void TakeDamage(int damage)
    {
        LivePoints = LivePoints -= damage;
        if(LivePoints <= 0)
        {
            IsDead = true;
            Menu.MenuSelector("Defeat");
        }
    }
}
