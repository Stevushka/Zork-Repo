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
        _game.GameQuit += _game_GameQuit;

        //Start
        _game.Start(InputService, OutputService);
        _game.Output.WriteLine("Press any key to begin!");
    }

    private void _game_GameQuit(object sender, EventArgs e)
    {
        output.WriteLine(string.IsNullOrWhiteSpace(_game.ExitMessage) ? "Thank you for playing!" : _game.ExitMessage);
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
        _game.Look(_game);
    }

    private Game _game;


}
