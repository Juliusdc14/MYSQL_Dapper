using System;
using System.Collections.Generic;

namespace introSQL
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartsments();
    }
}

