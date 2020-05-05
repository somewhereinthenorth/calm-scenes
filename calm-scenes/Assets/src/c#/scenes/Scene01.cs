using UnityEngine;

public class Scene01 : MonoBehaviour
{
    public float wave;
    public SineWave sineWave;
    GameObject cube0;
    GameObject cube1;
    GameObject cube2;

    void Start()
    {
        cube0 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    void Update()
    {
        wave = new SineWave(1f, 1f, 0f).getWave();
        cube0.transform.position = Vector3.up * new SineWave(1f, 1f, 0f).getWave();
        cube1.transform.position = Vector3.up * new SineWave(1f, 1f, 1f).getWave() + Vector3.right;
    }
}
