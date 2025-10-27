using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public int digit;
    private TextMeshProUGUI text;
    // private TileType tileType;
    // private bool isHidden;
    // private int feedbackValue;

    private void Awake()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void SetDigit(int newDigit)
    {
        this.digit = newDigit;
        text.text = newDigit.ToString();
    }

    public void Clear()
    {
        this.digit = 0; // or -1 to represent "empty"
        text.text = ""; // Show nothing
    }

    void Start()
    {
        SetDigit(digit);
    }

    // public void Clear()
    // {

    // }

    // public void SetAsHidden(char )
    // {

    // }

    // public void SetAsFeedback(int )
    // {

    // }

    // public void Reveal()
    // {
        
    // }

    
}
