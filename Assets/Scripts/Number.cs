using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
    // public int number { get; private set; }
    // private Button button;
    // private ButtonManager buttonManager;

    // public void OnButtonClick()
    // {
    //     // all 0-9 cases right?
    // }

    // public void SetInteractable(bool canClick)
    // {
    //     button.interactable = canClick;
    // }

    // // sets up the button when the game starts
    // public void Initialize()
    // {
    //     this.number == number;
    // }

    // public int GetNumber()
    // {
    //     return number;
    // } 

    public int digit;
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        Debug.Log("Button " + digit + " was clicked");
    }

}
