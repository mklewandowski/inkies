using UnityEngine;

public class MoveNormal : MonoBehaviour
{
    enum MoveState {
        None,
        MoveUp,
        MoveDown,
        MoveLeft,
        MoveRight
    };
    private MoveState currentMoveState = MoveState.None;

    [SerializeField]
    Vector2 movingUpEndPos;
    [SerializeField]
    Vector2 movingDownEndPos;
    [SerializeField]
    Vector2 movingLeftEndPos;
    [SerializeField]
    Vector2 movingRightEndPos;
    [SerializeField]
    float movingUpVelocity = 10f;
    [SerializeField]
    float movingDownVelocity = -10f;
    [SerializeField]
    float movingLeftVelocity = -10f;
    [SerializeField]
    float movingRightVelocity = 10f;

    // Update is called once per frame
    void Update()
    {
        if (currentMoveState == MoveState.MoveUp)
        {
            float newY = transform.localPosition.y + movingUpVelocity * Time.deltaTime;
            newY = Mathf.Min(movingUpEndPos.y, newY);
            Vector3 newPos = new Vector3(transform.localPosition.x, newY, transform.localPosition.z);
            transform.localPosition = newPos;
            if (newPos.y == movingUpEndPos.y)
                currentMoveState = MoveState.None;
        }
        else if (currentMoveState == MoveState.MoveDown)
        {
            float newY = transform.localPosition.y + movingDownVelocity * Time.deltaTime;
            newY = Mathf.Max(movingDownEndPos.y, newY);
            Vector3 newPos = new Vector3(transform.localPosition.x, newY, transform.localPosition.z);
            transform.localPosition = newPos;
            if (newPos.y == movingDownEndPos.y)
                currentMoveState = MoveState.None;
        }
        else if (currentMoveState == MoveState.MoveLeft)
        {
            float newX = transform.localPosition.x + movingLeftVelocity * Time.deltaTime;
            newX = Mathf.Max(movingLeftEndPos.x, newX);
            Vector3 newPos = new Vector3(newX, transform.localPosition.y, transform.localPosition.z);
            transform.localPosition = newPos;
            if (newPos.x == movingLeftEndPos.x)
                currentMoveState = MoveState.None;
        }
        else if (currentMoveState == MoveState.MoveRight)
        {
            float newX = transform.localPosition.x + movingRightVelocity * Time.deltaTime;
            newX = Mathf.Min(movingRightEndPos.x, newX);
            Vector3 newPos = new Vector3(newX, transform.localPosition.y, transform.localPosition.z);
            transform.localPosition = newPos;
            if (newPos.x == movingRightEndPos.x)
                currentMoveState = MoveState.None;
        }
    }

    public bool IsMoving()
    {
        return currentMoveState == MoveState.None;
    }

    public void MoveUp()
    {
        currentMoveState = MoveState.MoveUp;
    }
    public void MoveDown()
    {
        currentMoveState = MoveState.MoveDown;
    }
    public void MoveLeft()
    {
        currentMoveState = MoveState.MoveLeft;
    }
    public void MoveRight()
    {
        currentMoveState = MoveState.MoveRight;
    }
}
