using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : MonoBehaviour
{

    [SerializeField] int turnsPerRound = 4;

    int roundNumber;
    int turnNumber;

    enum DayOfWeek {Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};
    enum TimeOfDay {Morning, Afternoon, Evening, Night};

    public event Action onRoundChangeAction;
    public event Action<string, string> onRoundStartAction;
    public event Action <string, string> onTurnChangeAction;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        onRoundStartAction(GetDayOfWeek(), GetTimeOfDay());
        while (true)
        {
            yield return new WaitForSeconds(1f);
            NextTurn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextTurn()
    {
        turnNumber++;
        if (turnNumber >= turnsPerRound)
        {
            NextRound();
        }
        if (onTurnChangeAction != null)
        {
            onTurnChangeAction(GetDayOfWeek(), GetTimeOfDay());
        }
    }

    public void NextRound ()
    {
        roundNumber++;
        turnNumber = 0;
        if (onRoundChangeAction != null)
        {
            onRoundChangeAction();
        }
    }

    public int GetTurn()
    {
        return turnNumber;
    }

    public int GetRound()
    {
        return roundNumber;
    }

    public string GetDayOfWeek()
    {
        DayOfWeek currentDay = (DayOfWeek) (roundNumber % 7);
        return currentDay.ToString();
    }

    public string GetTimeOfDay()
    {
        TimeOfDay currentTimeOfDay = (TimeOfDay) (turnNumber % turnsPerRound);
        return currentTimeOfDay.ToString();
    }
}
