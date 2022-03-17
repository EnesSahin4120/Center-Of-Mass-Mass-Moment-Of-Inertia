using UnityEngine;

public  abstract class PhysicsBody : MonoBehaviour
{
    public float mass;
    private const float gravityConstant = 9.81f;

    public virtual float Weight
    {
        get
        {
            return mass * gravityConstant;
        }
    }

    public abstract Vector3 InertiaTensor { get; }
  
    public virtual Vector3 CenterOfMass
    {
        get
        {
            return transform.position;
        }
    }
}
