using UnityEngine;
using UnityEngine.UI;

public class MassMomentOfInertiaTest : MonoBehaviour
{
    public PhysicsBody rotating;
    public PhysicsBody pivot;

    public Text infoText;

    private void Start()
    {
        Vector3 massMomentofInertia = PhysicsOperation.MassMomentOfInertia(rotating, pivot);
        infoText.text = "Mass Moment of Inertia of the Red Object : " + massMomentofInertia;
    }
}
