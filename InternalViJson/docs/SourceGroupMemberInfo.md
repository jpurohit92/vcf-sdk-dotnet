# Vcenter.ViJson.OpenApi.Model.SourceGroupMemberInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceId** | [**DeviceId**](DeviceId.md) | Identifier of the source device.  May be a Virtual Volume, a Virtual Disk or a Virtual Machine  | 
**TargetId** | [**List&lt;TargetDeviceId&gt;**](TargetDeviceId.md) | Target devices, key&#39;ed by the fault domain id.  TODO: It is not clear if we really need this information, since the target side query can return the target -&amp;gt; source relation information.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

