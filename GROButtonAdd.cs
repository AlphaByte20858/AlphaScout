using UnityEngine;
using UnityEngine.UI;

public class PointIncrementGROButtonAdd : MonoBehaviour
{
    public Button GROButtonAdd;
    public int currentPoints=0;
    public InputField GROInput;
    

    private void Start()
    {
        GROButtonAdd.onClick.AddListener(IncrementPoints);
    }

    private void IncrementPoints()
    {
        currentPoints = (int.Parse(GROInput.text)); 
        currentPoints += 2; 
        GROInput.text = currentPoints.ToString(); 
    }
}