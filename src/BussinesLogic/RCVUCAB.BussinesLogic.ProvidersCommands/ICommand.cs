

namespace RCVUCAB.BussinesLogic.ProvidersCommands
{
    public interface ICommand<TOut>
    {
        void Execute();
        TOut GetResult();
    }
}
