using UnityEngine;
using UnityEngine.UI;

public class PointDecrementGROButtonSub : MonoBehaviour
{
    public Button GROButtonSub;
    public int currentPoints=0;
    public InputField GROInput;
    

    private void Start()
    {
        GROButtonSub.onClick.AddListener(DecrementPoints);
    }

    private void DecrementPoints()
    {
        currentPoints = (int.Parse(GROInput.text));
        currentPoints -= 2;
        GROInput.text = currentPoints.ToString();
    }
}