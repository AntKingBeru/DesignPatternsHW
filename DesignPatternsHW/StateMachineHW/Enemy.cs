namespace DesignPatternsHW.StateMachineHW;

public class Enemy
{
    private StateMachine _stateMachine;
    
    // Transition Conditions
    private bool _isIdle;
    private bool _detectedPlayer;
    private bool _inRange;
    private bool _killedPlayer;

    public Enemy(StateMachine stateMachine)
    {
        _stateMachine = stateMachine;
        _stateMachine.ChangeState(new IdleState(this));
        
        // Initialize variables
        _isIdle = true;
        _detectedPlayer = false;
        _inRange = false;
        _killedPlayer = false;
    }
    
    public void Tick()
    {
        _stateMachine.Tick();
    }

    public void DetectPlayer(bool detected)
    {
        _detectedPlayer = detected;
    }

    public void InRange(bool inRange)
    {
        _inRange = inRange;
    }

    public void Die()
    {
        _stateMachine.ChangeState(new DeadState(this));
    }

    public void KilledPlayer(bool killed)
    {
        _killedPlayer = killed;
    }
    
    public void SetIdle(bool isIdle)
    {
        _isIdle = isIdle;
    }
}