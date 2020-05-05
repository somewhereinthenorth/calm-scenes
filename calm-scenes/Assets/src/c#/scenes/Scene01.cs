using UnityEngine;

public class Scene01 : MonoBehaviour
{
    public float wave;
    public SineWave sineWave;

    void Update()
    {
        wave = new SineWave(1f, 1f).getWave();
    }
}
