using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TFL.DAL;

namespace TFL.BAL
{
    public interface IConsumeAsyncTfl
    {
        Task<List<Repository>> RoadStatusCheckTask();
    }
}
