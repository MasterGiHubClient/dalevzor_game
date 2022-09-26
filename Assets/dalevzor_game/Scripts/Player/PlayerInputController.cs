using UnityEngine;

public class PlayerInputController : PlayerComponent
{
    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        Player.Controller.Move(new Vector2(x, 0));
    }
}
