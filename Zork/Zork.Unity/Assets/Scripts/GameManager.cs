using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork;
using Newtonsoft.Json;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI CurrentLocationText;

    [SerializeField]
    private UnityInputService InputService;

    [SerializeField]
    private UnityOutputService OutputService;

    // Start is called before the first frame update
    void Start()
    {
        TextAsset gameTextAsset = Resources.Load<TextAsset>("Zork");
        Game game = JsonConvert.DeserializeObject<Game>(gameTextAsset.text);
        
        game.Start(InputService, OutputService);
        CurrentLocationText.text = game.Player.Location.ToString();
    }
}
