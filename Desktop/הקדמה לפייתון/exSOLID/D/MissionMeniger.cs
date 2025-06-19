using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static exSOLID.D.Ilogger;

namespace exSOLID.D
{
    internal class MissionMeniger
    {
        public class MissionController
        {
            private ILogger logger;

            public MissionController(ILogger logger)
            {
                this.logger = logger;
            }

            public void RunMission()
            {
                
                logger.Log("successfully");
            }
        }

    }
}
