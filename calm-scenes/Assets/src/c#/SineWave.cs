using UnityEngine;

public class SineWave : MonoBehaviour
{
    private float amplitude;
    private float periode;

    public SineWave(float amplitude, float periode) {
        this.amplitude = amplitude;
        this.periode = periode;
    }

    public float getWave() {
        return amplitude * Mathf.Sin(2 * Mathf.PI * (1 / periode) * Time.time);
    }
}
