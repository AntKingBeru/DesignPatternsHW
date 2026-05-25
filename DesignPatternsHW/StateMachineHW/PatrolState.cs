using static System.Console;

namespace DesignPatternsHW.StateMachineHW;

public class PatrolState : IState
{
    private readonly Enemy _enemy;

    public PatrolState(Enemy enemy)
    {
        _enemy = enemy;
    }
    
    public void Enter()
    {
        WriteLine("Started Patrol");
    }

    public void Tick()
    {
        WriteLine("Patrolling...");
    }

    public void Exit()
    {
        WriteLine("Stopped Patrolling");
    }
}