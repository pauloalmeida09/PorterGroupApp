using PorterGroupApp.Models.Request;
using System.Collections.Generic;

namespace PorterGroupApp.Interfaces
{
    public interface IListObjectUnicRepository
    {
        List<ObjectUserRequest> RemoveRepeatObjects(List<ObjectUserRequest> payload);
    }
}
