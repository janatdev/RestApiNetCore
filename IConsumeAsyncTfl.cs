using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TFL
{
    public interface IConsumeAsyncTfl
    {
        Task<List<Repository>> RoadStatusCheckTask();
    }
}
