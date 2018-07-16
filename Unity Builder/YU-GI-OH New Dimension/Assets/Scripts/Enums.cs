using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
	public enum CardType
    {
        Normal=0,
        Spirit=1,
        Effect=2,
        Union=3,
        Gemini=4,
        Fusion=5,
        Tuner=6,
        Synchro=7,
        Flip=8,
        Xyz=9,
        Pendulum=10,
        Toon=11,
        Link=12
    }
    public enum SpellType
    {
        Normal=0,
        Continuous=1,
        Equip=2,
        Field=3,
        QuickPlay=4,
        Ritual=5
    }
    public enum MonsterAttributes
    {
        Fire=0,
        Earth=1,
        Dark=2,
        Light=3,
        Water=4,
        Wind=5,
        Divine=6
    }
    public enum MonsterType
    {
        Spellcaster=0,
        Dragon=1,
        Zombie=2,
        Warrior=3,
        BeastWarrior=4,
        Beast=5,
        WingedBeast=6,
        Fiend=7,
        Fairy=8,
        Insect=9,
        Dinosaur=10,
        Reptile=11,
        Fish=12,
        SeaSerpent=13,
        Aqua=14,
        Pyro=15,
        Thunder=16,
        Rock=17,
        Plant=18,
        Machine=19,
        Psychic=20,
        DivineBeast=21,
        Wyrm=22,
        Cyberse=23
    }
}
