using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class StateController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _mushroomText;
    [SerializeField] private Player _player;
    
    private System.Random rnd = new System.Random();
    private readonly StatePlayer.States[] states = { StatePlayer.States.Disorientation, 
        StatePlayer.States.Blindness, StatePlayer.States.Glitches };

    private void Update()
    {
        if (int.Parse(_mushroomText.text) > 3 && _player.playerState == StatePlayer.States.Default)
            _player.playerState = states[rnd.Next(0, 2)];
    }
}
