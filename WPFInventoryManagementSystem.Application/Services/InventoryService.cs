using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WPFInventoryManagementSystem.Application.ServiceInterfaces;
using WPFInventoryManagementSystem.Data;
using WPFInventoryManagementSystem.Domain.Models;

namespace WPFInventoryManagementSystem.Application.Services
{
    public class InventoryService : GenericService<InventoryItem>, IInventoryService
    {

        public InventoryService(InventoryContextFactory contextFactory) : base(contextFactory)
        {

        }

    
    }
}
