using UnityEngine;

public class PlayerLocomotion : PlayerComponent
{
    [SerializeField] float speed;

    public void Move(Vector2 target)
    {
        transform.position += new Vector3(target.x * speed * Time.deltaTime, 0, 0);
    }
}
