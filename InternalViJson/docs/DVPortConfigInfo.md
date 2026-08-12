# Vcenter.ViJson.OpenApi.Model.DVPortConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the port.  | [optional] 
**Scope** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Deprecated as of vSphere API 5.5.  The eligible entities that can connect to the port.  If unset, there is no restriction on which entity can connect to the port. If set, only the entities in the specified list or their child entities are allowed to connect to the port. If scopes are defined at both port and portgroup level, they are taken as an \&quot;AND\&quot; relationship. If such a relationship doesn&#39;t make sense, the reconfigure operation will raise an exception.  Refers instances of *ManagedEntity*.  | [optional] 
**Description** | **string** | A description string of the port.  | [optional] 
**Setting** | [**DVPortSetting**](DVPortSetting.md) | The network configuration of the port.  | [optional] 
**ConfigVersion** | **string** | The version string of the configuration.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

