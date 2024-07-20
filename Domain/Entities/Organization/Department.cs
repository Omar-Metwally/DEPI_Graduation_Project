﻿using smERP.Domain.Entities.User;

namespace smERP.Domain.Entities.Organization;

public class Department : BaseEntity
{
    public string Name { get; set; }
    public string DepartmentHeadID { get; set; }
    public Employee DepartmentHead { get; set; }
    public ICollection<Employee> DepartmentEmployees { get; set; }
}
