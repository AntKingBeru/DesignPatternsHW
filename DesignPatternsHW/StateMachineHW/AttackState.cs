using static System.Console;

namespace DesignPatternsHW.StateMachineHW;

public class AttackState : IState
{
    private readonly Enemy _enemy;
    private float _attackTimer;

    public AttackState(Enemy enemy)
    {
        _enemy = enemy;
    }
    
    public void Enter()
    {
        WriteLine("Attacking!!!");
    }

    public void Tick()
    {
        WriteLine("Attack in progress");
    }

    public void Exit()
    {
        WriteLine("Attack done");
    }
}