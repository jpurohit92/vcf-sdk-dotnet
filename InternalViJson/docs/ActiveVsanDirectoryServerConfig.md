# Vcenter.ViJson.OpenApi.Model.ActiveVsanDirectoryServerConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveDirectoryDomainName** | **string** | Microsoft Active Directory Domain name which will be used for authentication for Kerberos based NFS share and SMB shares.  The active directory domain name should be of the form &#39;example.com&#39;.  | [optional] 
**Username** | **string** | Username that is used to connect and configure the directory service.  This user is required to have sufficient privileges in provided Organizational Unit to: - Create and delete Computer Objects. - Read and Write ms-DS-PrincipleName. - Read and Write uPNSuffixes.  | [optional] 
**Password** | **string** | Password for the domain user.  | [optional] 
**OrganizationalUnit** | **string** | Active Directory&#39;s Organizational Unit.  This is where all file server computer objects will be created. If it is not specified while creating File Service Domain, by default Computers OU will be used. We recommend an OU must be pre-created in Active Directory and default Computers OU should not be used. Best way to get your OU name right is by following below convention: https://support.microsoft.com/en-in/help/909264/naming-conventions-in-active-directory-for-computers-domains-sites-and As best practice for security and manageability, we recommend: - Create a dedicated OU for vSAN file service. - Create a basic domain user. - Mark the OU managed by this domain user.    Note in the case of nested OU, \&quot;/\&quot; can be used as separator.  | [optional] 
**PreferredADServers** | **List&lt;string&gt;** | Preferred AD servers which are used to do username/password validation.  IP or FQDN is required for each AD server. For now, only IP format is supported.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

