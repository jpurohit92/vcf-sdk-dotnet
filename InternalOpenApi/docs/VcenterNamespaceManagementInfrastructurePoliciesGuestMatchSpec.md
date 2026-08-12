# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementInfrastructurePoliciesGuestMatchSpec
The Vcenter.NamespaceManagement.InfrastructurePolicies.GuestMatchSpec schema contains matching criteria for guest operating systems.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GuestId** | [**VcenterNamespaceManagementInfrastructurePoliciesStringMatchSpec**](VcenterNamespaceManagementInfrastructurePoliciesStringMatchSpec.md) | Matches the workload&#39;s guest ID. For a complete list of supported values, please refer to GuestOsIdentifier enumerated type from the VIM API.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no guest ID matching is performed. | [optional] 
**GuestFamily** | [**VcenterNamespaceManagementInfrastructurePoliciesGuestFamilyMatchSpec**](VcenterNamespaceManagementInfrastructurePoliciesGuestFamilyMatchSpec.md) | Matches the workload&#39;s guest family defined in *Vcenter.NamespaceManagement.InfrastructurePolicies.GuestFamilyType*  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no guest family matching is performed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

