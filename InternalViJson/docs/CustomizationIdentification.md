# Vcenter.ViJson.OpenApi.Model.CustomizationIdentification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JoinWorkgroup** | **string** | The workgroup that the virtual machine should join.  If this value is supplied, then the domain name and authentication fields must be empty.  | [optional] 
**JoinDomain** | **string** | The domain that the virtual machine should join.  If this value is supplied, then domainAdmin and domainAdminPassword must also be supplied, and the workgroup name must be empty.  | [optional] 
**DomainAdmin** | **string** | This is the domain user account used for authentication if the virtual machine is joining a domain.  The user does not need to be a domain administrator, but the account must have the privileges required to add computers to the domain.  | [optional] 
**DomainAdminPassword** | [**CustomizationPassword**](CustomizationPassword.md) | This is the password for the domain user account used for authentication if the virtual machine is joining a domain.  | [optional] 
**DomainOU** | **string** | This is the MachineObjectOU which specifies the full LDAP path name of the OU to which the computer belongs.  For example, OU&#x3D;MyOu,DC&#x3D;MyDom,DC&#x3D;MyCompany,DC&#x3D;com Refer to: https://docs.microsoft.com/en-us/windows-hardware/customize/ desktop/unattend/microsoft-windows-unattendedjoin- identification-machineobjectou  ***Since:*** vSphere API Release 8.0.2.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

