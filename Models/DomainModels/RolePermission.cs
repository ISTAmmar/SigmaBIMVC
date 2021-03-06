﻿namespace Models.DomainModels
{
    public class RolePermission
    {
        public long RolePermissionId { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public virtual AspNetRole AspNetRole { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
