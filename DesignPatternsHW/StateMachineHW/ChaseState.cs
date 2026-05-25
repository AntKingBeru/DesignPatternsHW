using static System.Console;

namespace DesignPatternsHW.StateMachineHW;

public class ChaseState : IState
{
    private readonly Enemy _enemy;

    public ChaseState(Enemy enemy)
    {
        _enemy = enemy;
    }
    
    public void Enter()
    {
        WriteLine("Started Chasing");
    }

    public void Tick()
    {
        WriteLine("Chasing...");
    }

    public void Exit()
    {
        WriteLine("Stopped Chasing");
    }
}