# Vcenter.ViJson.OpenApi.Model.HostService

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Brief identifier for the service.  | 
**Label** | **string** | Display label for the service.  | 
**Required** | **bool** | Flag indicating whether the service is required and cannot be disabled.  | 
**Uninstallable** | **bool** | Deprecated this flag is unimplemented and will always be set to false.  Flag indicating whether the service can be uninstalled.  | 
**Running** | **bool** | Flag indicating whether the service is currently running.  | 
**Ruleset** | **List&lt;string&gt;** | List of firewall rulesets used by this service.  Must come from the list of rulesets in *HostFirewallInfo.ruleset*.  | [optional] 
**Policy** | **string** | Service activation policy.  See also *HostServicePolicy_enum*.  | 
**SourcePackage** | [**HostServiceSourcePackage**](HostServiceSourcePackage.md) | The source package associated with the service  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

