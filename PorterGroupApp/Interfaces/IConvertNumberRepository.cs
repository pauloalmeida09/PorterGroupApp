using PorterGroupApp.Models.Request;

namespace PorterGroupApp.Interfaces
{
    public interface IConvertNumberRepository
    {
        string ConvertNumberToWord(NumbersToWordRequest payload);
    }
}
