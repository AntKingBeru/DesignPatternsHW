using static System.Console;

namespace DesignPatternsHW.StateMachineHW;

public class CombatIdle : IState
{
    private readonly Enemy _enemy;
    private float _cooldownTimer;

    public CombatIdle(Enemy enemy)
    {
        _enemy = enemy;
    }
    
    public void Enter()
    {
        WriteLine("Waiting for attack cooldown");
    }

    public void Tick()
    {
        WriteLine("Still waiting...");
    }

    public void Exit()
    {
        WriteLine("Ready to attack!");
    }
}