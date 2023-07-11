using UnityEngine;
using UnityEngine.UI;

public class EstacioAutoPersoDois : MonoBehaviour
{
    public Toggle EstacioAutoPerso;
    public int PointEstacioPerso = 20;
    public InputField PointEstacioInput; 

   private void Start()
    {
        EstacioAutoPerso.onValueChanged.AddListener(Personalizado);
    }


    public void Personalizado (bool isOn)
    {
        if (isOn){
            PointEstacioInput.text = PointEstacioPerso.ToString();
        }
        else {
            PointEstacioInput.text = string.Empty;
        }
    }
}
