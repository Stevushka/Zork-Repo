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
        CurrentLocationText.text = string.Empty;
        ScoreText.text = string.Empty;
        MovesText.text = string.Empty;

        //Events
        _game.Player.LocationChanged += PlayerLocationChanged;
        _game.Player.ScoreChanged += PlayerScoreChanged;
        _game.Player.MovesChanged += PlayerMovesChanged;
        _game.GameInit += Game_Init;
        _game.GameQuit += Game_Quit;

        //Start
        _game.Start(InputService, OutputService);
        OutputService.WriteLine("Press any key to begin!");
        InputService.SelectInputField();
    }

    private void Game_Init(object sender, EventArgs e)
    {
        OutputService.WriteLine(string.IsNullOrWhiteSpace(_game.WelcomeMessage) ? "Welcome To Zork!" : _game.WelcomeMessage);
        CurrentLocationText.text = _game.Player.Location.Name;
        ScoreText.text = "Score: " + _game.Player.Score.ToString();
        MovesText.text = "Moves: " + _game.Player.Moves.ToString();
        _game.Look(_game);
    }
    
    private void Game_Quit(object sender, EventArgs e)
    {
        OutputService.WriteLine(string.IsNullOrWhiteSpace(_game.ExitMessage) ? "Thank you for playing!" : _game.ExitMessage);

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
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
