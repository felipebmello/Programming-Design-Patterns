using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] string npcName = "John Doe";

    [SerializeField] Round roundManager;


    private void DialogueLines(string currentDayOfWeek, string currentTimeOfDay)
    {
        Debug.Log(npcName+" says: It's " + currentDayOfWeek + " " + currentTimeOfDay + ", and you know what that means!");
    }

    private void OnEnable()
    {
        roundManager.onRoundStartAction += DialogueLines;
        roundManager.onTurnChangeAction += DialogueLines;
    }

    private void OnDisable()
    {
        roundManager.onRoundStartAction -= DialogueLines;
        roundManager.onTurnChangeAction -= DialogueLines;
    }
    
}
