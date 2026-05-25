using static System.Console;

namespace DesignPatternsHW.StateMachineHW;

public class IdleState : IState
{
    private readonly Enemy _enemy;

    public IdleState(Enemy enemy)
    {
        _enemy = enemy;
    }

    public void Enter()
    {
        WriteLine("Entered Idle State");
    }

    public void Tick()
    {
        WriteLine("Idling...");
    }

    public void Exit()
    {
        WriteLine("Exited Idle State");
    }
}