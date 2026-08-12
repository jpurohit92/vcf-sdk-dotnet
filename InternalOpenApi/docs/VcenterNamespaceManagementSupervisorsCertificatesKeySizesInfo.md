# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsCertificatesKeySizesInfo
The Vcenter.NamespaceManagement.Supervisors.Certificates.KeySizes.Info schema contains information on the current signing key size for Supervisor internal certificates and The list of supported key sizes that you can use to update Supervisor internal certificates key size using the #internalCertsKeySize API.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentKeySize** | **string** | *Vcenter.NamespaceManagement.Supervisors.Certificates.KeySizes.Info.current_key_size* get signing key size for Supervisor internal certificates.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**SupportedKeySizes** | **List&lt;string&gt;** | *Vcenter.NamespaceManagement.Supervisors.Certificates.KeySizes.Info.supported_key_sizes* retrieves the list of supported signing key sizes for Supervisor internal certificates. Each item identifies a unique algorithm and key size you can configure the Supervisor certificates using the #internalCertsKeySize API.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

