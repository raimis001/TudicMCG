using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightParticle : MonoBehaviour
{
    public Light2D light2d;
    public Vector2 intensity;
    public float speed;

    public Gradient color;

    private void Update()
    {
        float pp = Mathf.PingPong(Time.time * speed, 1);
        light2d.intensity = intensity.y * pp + intensity.x;
        light2d.color = color.Evaluate(pp);
    }
}
