using UnityEngine;

public class Spherical : PhysicsBody
{
    public float radius;

    public override float Weight => base.Weight;

    public override Vector3 CenterOfMass => base.CenterOfMass;

    public override Vector3 InertiaTensor
    {
        get
        {
            return new Vector3(2 / 5f * mass * radius * radius, 2 / 5f * mass * radius * radius, 2 / 5f * mass * radius * radius);
        }
    }
}
