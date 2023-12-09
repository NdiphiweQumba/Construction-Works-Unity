using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmController : MonoBehaviour
{
	#region Public Fields
	public float rotationSpeed = 1.0f;
	public float maxConstraint = 0.0f;
	public float minConstraint = 5.0f;
    #endregion
    #region Private Fields
    #endregion
    #region Monobehaviour Callbacks
    private void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        MoveArm(verticalInput);
    }
    #endregion
    #region Custom Methods Fields
    protected virtual void MoveArm(float input)
    {
        // Rotate the arm around its local x-axis
        float rotationAmount = input * rotationSpeed * Time.deltaTime;
        float newRotation = Mathf.Clamp(transform.localEulerAngles.x + 1,minConstraint, maxConstraint);
        Debug.Log(newRotation);
        // Apply constraints
        transform.localEulerAngles = new Vector3(newRotation, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }
    #endregion
}
[System.Serializable]
public class ArmControllerFields
{

}