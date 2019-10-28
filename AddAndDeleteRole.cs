//add user role
public void setUserRolesByUserId(Guid UserRole, Guid UserId)
        {
            try
            {
                using (var organizationService = CRMServiceHelper.GetServiceProxy())
                {
                    using (var orgContext = new OrganizationServiceContext(organizationService))
                    {
                        organizationService.Associate(
                                 "systemuser",
                                 UserId,
                                 new Relationship("systemuserroles_association"),
                                 new EntityReferenceCollection() { new EntityReference(Role.EntityLogicalName, UserRole) });

                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
   //delete user role     
    public void deleteUserRolesByUserId(Guid UserRole, Guid UserId)
        {
            try
            {
                using (var organizationService = CRMServiceHelper.GetServiceProxy())
                {
                    using (var orgContext = new OrganizationServiceContext(organizationService))
                    {
                        organizationService.Disassociate(
                                 "systemuser",
                                 UserId,
                                 new Relationship("systemuserroles_association"),
                                 new EntityReferenceCollection() { new EntityReference(Role.EntityLogicalName, UserRole) });

                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }   
        
        
        
        
      
