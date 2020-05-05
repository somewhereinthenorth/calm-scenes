
using UnityEngine;

public class UtilMath : MonoBehaviour
{
    public static float GetSineWave(float amplitude, float periode, float time) {
        return amplitude * Mathf.Sin(2 * Mathf.PI * (1/periode) * time);
    }
}
