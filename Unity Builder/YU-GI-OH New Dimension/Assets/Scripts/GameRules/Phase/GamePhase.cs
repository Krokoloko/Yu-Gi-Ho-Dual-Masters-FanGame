using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePhase : MonoBehaviour {

    public GameObject currentPlayer;
    public Enums.Phase value = Enums.Phase.DrawPhase;
    
    void Start ()
    {
        PhaseSelector();
	}

    void PhaseSelector()
    {
        switch (value)
        {
            case Enums.Phase.DrawPhase:
                DrawPhase();
                break;

            case Enums.Phase.Standby:
                StandbyPhase();
                break;

            case Enums.Phase.MainPhase1:
                MainPhase();
                break;

            case Enums.Phase.BattlePhase:
                BattlePhase();
                break;

            case Enums.Phase.MainPhase2:
                MainPhase2();
                break;

            case Enums.Phase.Endphase:
                EndPhase();
                break;
        }
    }

	void DrawPhase()
    {
        value = Enums.Phase.Standby;
        PhaseSelector();
    }

    void StandbyPhase()
    {
        value = Enums.Phase.MainPhase1;
        PhaseSelector();
    }

    void MainPhase()
    {
        value = Enums.Phase.BattlePhase;
        PhaseSelector();
    }

    void BattlePhase()
    {
        value = Enums.Phase.MainPhase2;
        PhaseSelector();
    }

    void MainPhase2()
    {
        value = Enums.Phase.Endphase;
        PhaseSelector();
    }

    void EndPhase()
    {
        value = Enums.Phase.DrawPhase;
        PhaseSelector();
    }
}
