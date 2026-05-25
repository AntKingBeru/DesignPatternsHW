using static System.Console;

namespace DesignPatternsHW.StateMachineHW;

public class DeadState : IState
{
    private readonly Enemy _enemy;

    public DeadState(Enemy enemy)
    {
        _enemy = enemy;
    }
    
    public void Enter()
    {
        WriteLine("Uh oh! I'm dead!");
    }

    public void Tick()
    {
        
    }

    public void Exit()
    {
        
    }
}