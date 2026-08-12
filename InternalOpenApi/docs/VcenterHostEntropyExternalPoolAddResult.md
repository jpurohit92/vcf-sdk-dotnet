# Vcenter.Automation.OpenApi.Model.VcenterHostEntropyExternalPoolAddResult
The Vcenter.Host.Entropy.ExternalPool.AddResult schema provides result of the *POST /vcenter/host/{host}/entropy/external-pool?action=add* operation.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capacity** | **long** | Capacity of external entropy pool in bytes.  This property was added in __vSphere API 8.0.1.0__. | 
**CurrentlyAvailable** | **long** | Currently available amount of entropy in bytes in the external entropy pool.  This property was added in __vSphere API 8.0.1.0__. | 
**LowWatermark** | **long** | A threshold value in bytes. An audit record will be logged when *Vcenter.Host.Entropy.ExternalPool.AddResult.currently_available* drops below this value.  This property was added in __vSphere API 8.0.1.0__. | 
**InactiveSourceTimeout** | **long** | A timeout period in seconds within which the client must call *GET /vcenter/host/{host}/entropy/external-pool* operation or *POST /vcenter/host/{host}/entropy/external-pool?action&#x3D;add* operation. If no call is received before the timeout lapses an audit record will be created.    This is the timeout to detect any connection lost with the client.  This property was added in __vSphere API 8.0.1.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

