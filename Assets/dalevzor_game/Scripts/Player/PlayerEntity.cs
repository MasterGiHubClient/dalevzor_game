
public class PlayerEntity : PlayerComponent
{
    public PlayerLocomotion Controller { get; private set; }

    private void Awake()
    {
        Controller = GetComponent<PlayerLocomotion>();
        var components = GetComponentsInChildren<PlayerComponent>();
        foreach(PlayerComponent component in components)
        {
            component.Init(this);
        }
    }
}
