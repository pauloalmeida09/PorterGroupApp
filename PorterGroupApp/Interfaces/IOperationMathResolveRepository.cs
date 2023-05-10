using PorterGroupApp.Models.Request;
namespace PorterGroupApp.Interfaces
{
    public interface IOperationMathResolveRepository
    {
        int ResolveMathOperationStringArray(OperationsMathRequest payload);
    }
}
