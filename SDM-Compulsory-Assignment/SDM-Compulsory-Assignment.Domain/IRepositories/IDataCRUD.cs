using SDM_Compulsory_Assignment.Core.Models;
using System.Collections.Generic;

namespace SDM_Compulsory_Assignment.Domain.IRepositories
{
    public interface IDataCRUD
    {
        IEnumerable<Review> ReadAll();
    }
}
