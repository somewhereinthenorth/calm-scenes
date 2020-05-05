using UnityEngine;

public class SineWave : MonoBehaviour
{
    private float amplitude;
    private float periode;
    private float phase;

    public SineWave(float amplitude, float periode, float phase) {
        this.amplitude = amplitude;
        this.periode = periode;
        this.phase = phase;
    }

    public float getWave() {
        return amplitude * Mathf.Sin(2 * Mathf.PI * (1 / periode) * Time.time + phase);
    }


}
