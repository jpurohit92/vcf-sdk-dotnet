# Vcenter.ViJson.OpenApi.Model.HostRuntimeInfoNetStackInstanceRuntimeInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetStackInstanceKey** | **string** | Key of the instance  | 
**State** | **string** | State of the instance See *HostRuntimeInfoNetStackInstanceRuntimeInfoState_enum* for valid values.  | [optional] 
**VmknicKeys** | **List&lt;string&gt;** | The keys of vmknics that are using this stack  | [optional] 
**MaxNumberOfConnections** | **int** | The maximum number of socket connections can be worked on this instance currently after booting up.  | [optional] 
**CurrentIpV6Enabled** | **bool** | If true then dual IPv4/IPv6 stack enabled else IPv4 only.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

