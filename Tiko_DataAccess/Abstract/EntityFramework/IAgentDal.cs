﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Tiko_Entities.Concrete;
using Tiko_Entities.DTOs;

namespace Tiko_DataAccess.Abstract.EntityFramework
{
    public interface IAgentDal : IRepository<Agent>
    {
        Task<List<AgentDetail>> GetAgentDetails();
    }
}