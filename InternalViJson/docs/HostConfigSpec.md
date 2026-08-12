# Vcenter.ViJson.OpenApi.Model.HostConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NasDatastore** | [**List&lt;HostNasVolumeConfig&gt;**](HostNasVolumeConfig.md) | Configurations to create NAS datastores.  | [optional] 
**Network** | [**HostNetworkConfig**](HostNetworkConfig.md) | Network system information.  | [optional] 
**NicTypeSelection** | [**List&lt;HostVirtualNicManagerNicTypeSelection&gt;**](HostVirtualNicManagerNicTypeSelection.md) | Type selection for different VirtualNics.  | [optional] 
**Service** | [**List&lt;HostServiceConfig&gt;**](HostServiceConfig.md) | Host service configuration.  | [optional] 
**Firewall** | [**HostFirewallConfig**](HostFirewallConfig.md) | Firewall configuration.  | [optional] 
**Option** | [**List&lt;OptionValue&gt;**](OptionValue.md) | Host configuration options as defined by the *OptionValue* data object type.  | [optional] 
**DatastorePrincipal** | **string** | Datastore principal user.  | [optional] 
**DatastorePrincipalPasswd** | **string** | Password for the datastore principal.  | [optional] 
**Datetime** | [**HostDateTimeConfig**](HostDateTimeConfig.md) | DateTime Configuration.  | [optional] 
**StorageDevice** | [**HostStorageDeviceInfo**](HostStorageDeviceInfo.md) | Storage system information.  | [optional] 
**License** | [**HostLicenseSpec**](HostLicenseSpec.md) | License configuration for the host.  | [optional] 
**Security** | [**HostSecuritySpec**](HostSecuritySpec.md) | Security specification.  | [optional] 
**UserAccount** | [**List&lt;HostAccountSpec&gt;**](HostAccountSpec.md) | List of users to create/update with new password.  | [optional] 
**UsergroupAccount** | [**List&lt;HostAccountSpec&gt;**](HostAccountSpec.md) | List of users to create/update with new password.  | [optional] 
**Memory** | [**HostMemorySpec**](HostMemorySpec.md) | Memory configuration for the host.  | [optional] 
**ActiveDirectory** | [**List&lt;HostActiveDirectory&gt;**](HostActiveDirectory.md) | Active Directory configuration change.  | [optional] 
**GenericConfig** | [**List&lt;KeyAnyValue&gt;**](KeyAnyValue.md) | Advanced configuration.  | [optional] 
**GraphicsConfig** | [**HostGraphicsConfig**](HostGraphicsConfig.md) | Graphics configuration for a host.  | [optional] 
**AssignableHardwareConfig** | [**HostAssignableHardwareConfig**](HostAssignableHardwareConfig.md) | Assignable Hardware configuration for the host  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

