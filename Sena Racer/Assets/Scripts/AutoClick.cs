using UnityEngine;
using UnityEngine.UI;

public class AutoClick : MonoBehaviour
{
    public Button miBoton; // Aseg�rate de asignar este bot�n en el Inspector de Unity

    void Start()
    {
        miBoton.onClick.Invoke(); // Esto invocar� la funci�n asignada al bot�n en el Inspector de Unity
    }
}
