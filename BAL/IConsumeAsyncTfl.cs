using System.Collections.Generic;
using System.Threading.Tasks;
using TFL.DAL;

namespace TFL.BAL
{
    public interface IConsumeAsyncTfl
    {
        Task<List<Repository>> RoadStatusCheckTask();
    }
}
