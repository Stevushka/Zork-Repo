using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork;
using Newtonsoft.Json;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI CurrentLocationText = null;

    [SerializeField]
    private TextMeshProUGUI ScoreText = null;

    [SerializeField]
    private TextMeshProUGUI MovesText = null;

    [SerializeField]
    private UnityInputService InputService = null;

    [SerializeField]
    private UnityOutputService OutputService = null;

    void Start()
    {
        //Setup
        TextAsset gameTextAsset = Resources.Load<TextAsset>("Zork");
        _game = Game.Load(gameTextAsset.text);

        //Initialize
        CurrentLocationText.text = _game.Player.Location.ToString();

        //Events
        _game.Player.LocationChanged += PlayerLocationChanged;
        _game.Player.ScoreChanged += PlayerScoreChanged;
        _game.Player.MovesChanged += PlayerMovesChanged;

        //Start
        _game.Start(InputService, OutputService);
    }

    private void PlayerMovesChanged(object sender, int newMoves)
    {
        MovesText.text = newMoves.ToString();
    }

    private void PlayerScoreChanged(object sender, int newScore)
    {
        ScoreText.text = newScore.ToString();
    }

    private void PlayerLocationChanged(object sender, Room newLocation)
    {
        CurrentLocationText.text = newLocation.ToString();
    }

    private Game _game;


}
