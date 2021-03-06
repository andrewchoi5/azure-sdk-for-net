// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Authorization.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Role assignment create parameters.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RoleAssignmentCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the RoleAssignmentCreateParameters
        /// class.
        /// </summary>
        public RoleAssignmentCreateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleAssignmentCreateParameters
        /// class.
        /// </summary>
        /// <param name="roleDefinitionId">The role definition ID used in the
        /// role assignment.</param>
        /// <param name="principalId">The principal ID assigned to the role.
        /// This maps to the ID inside the Active Directory. It can point to a
        /// user, service principal, or security group.</param>
        /// <param name="principalType">The principal type of the assigned
        /// principal ID. Possible values include: 'User', 'Group',
        /// 'ServicePrincipal', 'Unknown', 'DirectoryRoleTemplate',
        /// 'ForeignGroup', 'Application', 'MSI', 'DirectoryObjectOrGroup',
        /// 'Everyone'</param>
        /// <param name="canDelegate">The delegation flag used for creating a
        /// role assignment</param>
        public RoleAssignmentCreateParameters(string roleDefinitionId, string principalId, string principalType = default(string), bool? canDelegate = default(bool?))
        {
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
            PrincipalType = principalType;
            CanDelegate = canDelegate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the role definition ID used in the role assignment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.roleDefinitionId")]
        public string RoleDefinitionId { get; set; }

        /// <summary>
        /// Gets or sets the principal ID assigned to the role. This maps to
        /// the ID inside the Active Directory. It can point to a user, service
        /// principal, or security group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.principalId")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the principal type of the assigned principal ID.
        /// Possible values include: 'User', 'Group', 'ServicePrincipal',
        /// 'Unknown', 'DirectoryRoleTemplate', 'ForeignGroup', 'Application',
        /// 'MSI', 'DirectoryObjectOrGroup', 'Everyone'
        /// </summary>
        [JsonProperty(PropertyName = "properties.principalType")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// Gets or sets the delegation flag used for creating a role
        /// assignment
        /// </summary>
        [JsonProperty(PropertyName = "properties.canDelegate")]
        public bool? CanDelegate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RoleDefinitionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RoleDefinitionId");
            }
            if (PrincipalId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PrincipalId");
            }
        }
    }
}
