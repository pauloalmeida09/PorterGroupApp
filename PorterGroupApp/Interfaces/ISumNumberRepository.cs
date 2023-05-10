using PorterGroupApp.Models.Request;
namespace PorterGroupApp.Interfaces
{
    public interface ISumNumberRepository
    {
        int SumNumbersArray(SumArrayRequest payload);
    }
}
