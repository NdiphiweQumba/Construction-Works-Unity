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
        float rotationAmount =  input * rotationSpeed * Time.deltaTime;

        Debug.Log("Rotaion Amount: " + rotationAmount);

        float xRot = transform.localEulerAngles.x;
        Debug.Log("x rotation: " + xRot);

        float yRot = transform.localEulerAngles.y;
        float zRot = transform.localEulerAngles.z;

        if (input > 0 && xRot <= maxConstraint)
            transform.localEulerAngles = new Vector3(xRot - rotationAmount, yRot, zRot);
        if(input < 0 && xRot > minConstraint)
            transform.localEulerAngles = new Vector3(xRot - rotationAmount, yRot, zRot);
    }
    #endregion
}
[System.Serializable]
public class ArmControllerFields
{

}