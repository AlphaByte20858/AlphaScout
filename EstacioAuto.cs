using UnityEngine;
using UnityEngine.UI;

public class EstacioAutoPoints : MonoBehaviour
{
   public Toggle NPersonalizado;
   public int EstacioPoint = 10;
   public InputField InputOne;

public void Start(){

    NPersonalizado.onValueChanged.AddListener(Points);
}
private void Points(bool isOn){

    if (isOn) {
        InputOne.text = EstacioPoint.ToString();
    }
    else {
    InputOne.text = string.Empty;
    }
}
}
