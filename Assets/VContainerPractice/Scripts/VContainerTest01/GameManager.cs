using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VContainer;

public class GameManager : MonoBehaviour
{
    Button _mainButton;

    // Start is called before the first frame update
    void Start()
    {
        _mainButton.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        Debug.Log("ƒ{ƒ^ƒ“‚ª‰Ÿ‚³‚ê‚Ü‚µ‚½");
    }

    [Inject]
    public void Constructor(MainButton injectMainButton)
    {
        _mainButton = injectMainButton.GetComponent<Button>();
    }
}
