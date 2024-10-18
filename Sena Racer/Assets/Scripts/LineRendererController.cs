using UnityEngine;

public class LineRendererController : MonoBehaviour
{
    public Transform targetObject; // El objeto 3D al que quieres conectar la l�nea
    public Color lineColor = Color.blue; // Color de la l�nea

    private LineRenderer lineRenderer;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startColor = lineColor;
        lineRenderer.endColor = lineColor;
    }

    private void Update()
    {
        // Actualiza la posici�n de la l�nea para que siempre est� unida a tu posici�n
        lineRenderer.SetPosition(0, transform.position);

        // Actualiza la posici�n de la otra punta de la l�nea para que est� unida al objeto 3D
        if (targetObject != null)
        {
            lineRenderer.SetPosition(1, targetObject.position);
        }
    }
}
