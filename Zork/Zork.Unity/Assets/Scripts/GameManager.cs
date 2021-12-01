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
    private TextMeshProUGUI CurrentLocationText;

    [SerializeField]
    private UnityInputService InputService;

    [SerializeField]
    private UnityOutputService OutputService;

    void Start()
    {
        //Setup
        TextAsset gameTextAsset = Resources.Load<TextAsset>("Zork");
        _game = JsonConvert.DeserializeObject<Game>(gameTextAsset.text);
        _game.Start(InputService, OutputService);

        //Events
        _game.Player.LocationChanged += PlayerLocationChanged;
        
        //Initialize
        CurrentLocationText.text = _game.Player.Location.ToString();
    }

    private void PlayerLocationChanged(object sender, Room newLocation)
    {
        CurrentLocationText.text = newLocation.ToString();
    }

    private Game _game;
}