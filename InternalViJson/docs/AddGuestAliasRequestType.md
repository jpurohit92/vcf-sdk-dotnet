# Vcenter.ViJson.OpenApi.Model.AddGuestAliasRequestType
The parameters of *GuestAliasManager.AddGuestAlias*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.ModifyAliases  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data for this operation. See *GuestAuthentication*. These credentials must satisfy authentication requirements for a guest account on the specified virtual machine.  | 
**Username** | **string** | Username for the guest account on the virtual machine.  | 
**MapCert** | **bool** | Indicates whether the certificate associated with the alias should be mapped. If an alias certificate is mapped, guest operation requests that use that alias do not have to specify the guest account username in the *SAMLTokenAuthentication* object. If mapCert is false, the request must specify the username.  | 
**Base64Cert** | **string** | X.509 certificate from the VMware SSO Server, in base64 encoded DER format. The ESXi Server uses this certificate to authenticate guest operation requests.  | 
**AliasInfo** | [**GuestAuthAliasInfo**](GuestAuthAliasInfo.md) | Specifies the subject name for authentication. The subject name (when present) corresponds to the value of the Subject element in SAML tokens. The ESXi Server uses the subject name to authenticate guest operation requests.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

