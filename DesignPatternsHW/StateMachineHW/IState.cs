namespace DesignPatternsHW.StateMachineHW;

public interface IState
{
    void Enter();
    void Tick();
    void Exit();
}